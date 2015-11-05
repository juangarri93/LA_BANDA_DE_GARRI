using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

using AerolineaFrba.Herramientas;

namespace AerolineaFrba.CapaADO
{
    public class SqlConnector
    {

        //Realiza la conexion a la base de datos.

        public static void conexionSql(SqlConnection connection, SqlCommand command)
        {
            try
            {
                string sconcompleto = Global.getConnectionString();
                connection.ConnectionString = sconcompleto; //Establece cabecera de conexion
                command.Connection = connection; // establezco que el comando sql que cree antes use la conexion sql que estableci recien
                connection.Open(); // aca abro la conexion  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Ejecuta un stored procedure y devuelve un datatable con el resultado del mismo.
        // Procedimiento -> Nombre del stored procedure 
        //Argumentos que recibe el stored procedure

        public static DataTable retrieveDataTable(string storedProcedure, params object[] parametros)
        {
            List<string> argumentos = _generateArguments(storedProcedure);
            return _retrieveDataTable(storedProcedure, argumentos, parametros);
        }

        // Ejecuta un stored procedure y devuelve un datatable con el resultado del mismo.

        public static DataTable retrieveDataTable(string procedure)
        {
            return _retrieveDataTable(procedure, null, null);
        }

        //Ejecuta un stored procedure con parametros

        public static void executeProcedure(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            _executeProcedure(procedure, argumentos, values);
        }


        /// Ejecuta un stored procedure sin parametros

        public static void executeProcedure(string procedure)
        {
            _executeProcedure(procedure, null, null);
        }


        /// Ejecuta una consulta (a partir de un stored procedure) y devuelve si encontró datos o no.

        public static bool checkIfExists(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _checkIfExists(procedure, argumentos, values);
        }

        /// Ejecuta una consulta (a partir de un stored procedure) y devuelve si encontró datos o no.

        public static bool checkIfExists(string procedure)
        {
            return _checkIfExists(procedure, null, null);
        }

        /// Ejecuta un stored procedure que devuelve un valor númerico y retorna dicho valor.
        public static int executeProcedureWithReturnValue(string procedure, params object[] values)
        {
            List<string> argumentos = _generateArguments(procedure);
            return _executeProcedureWithReturnValue(procedure, argumentos, values);
        }

        private static void _executeProcedure(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();


            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = procedure; // Ver esto
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cm);
                }
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static bool _checkIfExists(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();

            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cm);
                }
                dr = cm.ExecuteReader();
                return dr.HasRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static int _executeProcedureWithReturnValue(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();


            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cm);
                }
                cm.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                cm.ExecuteNonQuery();
                return (int)cm.Parameters["@RETURN_VALUE"].Value;
            }
            catch (Exception ex)
            {
                return -1;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static DataTable _retrieveDataTable(string procedure, List<string> args, params object[] values)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();

            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = procedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, values, cm);
                }
                dr = cm.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static List<string> _generateArguments(string procedure)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cm = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            List<string> args = new List<string>();
            try
            {
                conexionSql(cn, cm);
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT PARAMETER_NAME FROM information_schema.parameters WHERE SPECIFIC_SCHEMA='dbo' AND SPECIFIC_NAME='" + procedure + "'";
                dr = cm.ExecuteReader();
                dt.Load(dr);
                foreach (DataRow d in dt.Rows)
                {
                    args.Add(d[0].ToString());
                }
                return args;
            }
            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
        private static bool _validateArgumentsAndParameters(List<string> args, params object[] values)
        {
            if (args != null && values != null)
            {
                if (args.Count != values.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }
        private static void _loadSqlCommand(List<string> args, object[] values, SqlCommand cm)
        {
            for (int i = 0; i < args.Count; i++)
            {
                cm.Parameters.AddWithValue(args[i], values[i]);
            }
        }
    }
}