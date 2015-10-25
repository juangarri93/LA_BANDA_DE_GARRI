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
            MessageBox.Show("2 -" + ruta.CiudadOrigen); 
            executeProcedure("spinsertar_Ruta", 1,ruta.TipoServicio,ruta.CiudadOrigen,ruta.CiudadDestino,ruta.PrecioKG,ruta.PrecioBase);
            
        }

        public static DataTable Mostrar()
        {
            return retrieveDataTable("spmostrar_Ruta");
        }
    }
}
