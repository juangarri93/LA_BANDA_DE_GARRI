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
    public class DAOViaje : SqlConnector
    {
        public static DataTable getAeronaves()
        {
            return retrieveDataTable("spMostrar_Aeronaves_sin_baja_util");
        }


        public static DataTable getRutaAerea()
        {
            return retrieveDataTable("spMostrar_RutaAerea_sin_baja_util");
        }

        public static DataTable Mostrar()
        {
            return retrieveDataTable("spmostrar_Viajes");
        }

        public static void AgregarViaje(Viaje viaje)
        {
            executeProcedure("spinsertar_Viaje", 1, viaje.FechaSalida,viaje.FechaLlegada,viaje.FechaLlegadaEstimada,viaje.Aeronave,viaje.Ruta,viaje.Habilitado);

        }


    }
}
