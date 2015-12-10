using AerolineaFrba.CapaADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;


namespace AerolineaFrba.Login
{
    class Login : SqlConnector
    {
        internal void validateUser()
        {
           
            try
            {
                var passObtenido = GetUserPassword(userName);

                if (passObtenido == null)
                {
                    auxCase = 1;
                    return;
                }

                if(getValidarLogins(userName) >= 3)
                {
                    auxCase = 2;
                    actualizaIntentosFallidos(userName);
                    return;
                }

                if (passObtenido.Equals(password))
                {
                    resetearContadorLoguin(userName);
                    int idRol = getRolUsuario(userName);

                    listaFuncionalidades = DAORol.dameFuncionalidades(idRol);
                }
                else 
                {
                    auxCase = 3;
                    actualizaIntentosFallidos(userName);
                    return;
                }
            }
            catch
            {

            }
     
        }

        private int getRolUsuario(string userName)
        {
            return executeProcedureWithReturnValue("spdame_idRol",userName);
        }

        public static void resetearContadorLoguin(string userName)
        {
            executeProcedure("sp_resetearLogins",userName);
        }

        public static int getValidarLogins(string userName)
        {
            DataTable dt = retrieveDataTable("sp_dameDatosUsuario", userName);
            return Convert.ToInt32(dt.Rows[0]["intentos_fallidos"]);

        }

        public static string GetUserPassword(string nombreUsuario)
        {
            DataTable dt = retrieveDataTable("sp_dameDatosUsuario", nombreUsuario);

            if (dt.Rows.Count == 0) return null;

            DataRow dr = dt.Rows[0];
            return dr["Password"].ToString();
        }

        private List<int> _listaFuncionalidades;
        public List<int> listaFuncionalidades
        {
            get { return _listaFuncionalidades; }
            set { _listaFuncionalidades = value; }
        }

        private int _auxCase;
        public int auxCase
        {
            get { return _auxCase; }
            set { _auxCase = value; }
        }

        private String _result;
        public String result
        {
            get { return _result; }
            set { _result = value; }
        }

        private String userName;
        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String password;
        public String Password
        {
            get { return password; }
            set { password = SHA256Encrypt(value); } //Ya esta hasheada
        }

        private Boolean habilitado;
        public Boolean Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

        public static string SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

        public static int actualizaIntentosFallidos(String UserName)
        {
            return executeProcedureWithReturnValue("sp_sumarLogins", UserName); ;
        }
    }
}
