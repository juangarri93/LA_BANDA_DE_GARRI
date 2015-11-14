using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using AerolineaFrba.ConstructorDeClases;

namespace AerolineaFrba.CapaADO
{
    public class DAORuta:SqlConnector
    {
        public static DataTable getCiudades()
        {
            return retrieveDataTable("spMostrar_Ciudad_sin_baja_util");
        }

        public static void AgregarRuta(Ruta ruta)
        {
            executeProcedure("spinsertar_Ruta", 1,ruta.CodigoRuta,ruta.TipoServicio,ruta.CiudadOrigen,ruta.CiudadDestino,ruta.PrecioKG,ruta.PrecioBase,ruta.Habilitado);
            
        }

        public static DataTable Mostrar()
        {
            return retrieveDataTable("spmostrar_Ruta_Aerea");
        }

       public static void EditarRuta(Ruta ruta)
        {

            bool flag = false;

            if(ruta.Habilitado == 1)
            {
                flag = true;
            }else
            {
                flag = false;
            }
            executeProcedure("speditar_Ruta", ruta.Id, ruta.CodigoRuta, ruta.TipoServicio, ruta.CiudadOrigen, ruta.CiudadDestino, ruta.PrecioKG, ruta.PrecioBase, flag);
        }

        public static string obtenerCiudad(int idCiudad)
        {
            string resultado = "";

            var table = retrieveDataTable("sptraerCiudad", idCiudad);

            var ciudad = dataRowToRol(table.Rows[0]);

            resultado = ciudad.Nombre;

            return resultado;
        }

        private static Ciudad dataRowToRol(DataRow dr)
        {
            return new Ciudad(Convert.ToInt32(dr["Id"]), dr["Nombre"].ToString(), dr["Habilitada"].ToString() == "1");
        }
    }
}
