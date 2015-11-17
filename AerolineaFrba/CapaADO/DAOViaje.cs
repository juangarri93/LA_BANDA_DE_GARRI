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
            return retrieveDataTable("spmostrar_aeronave");
        }


        public static DataTable getRutaAerea()
        {
            return retrieveDataTable("spMostrar_Ruta_Aerea");
        }

        public static DataTable getViajeEspecifico(int id)
        {
            return retrieveDataTable("spMostrar_viaje_esp",id);
        }

        public static DataTable Mostrar()
        {
            return retrieveDataTable("spmostrar_Viajes");
        }

        public static DataTable Buscar(DateTime fecha, int origen1, int destino1)
        {

            return retrieveDataTable("spbuscar_fechaOrigenDestino", fecha, origen1, destino1);
             
           // return retrieveDataTable("spbuscar_fechaOrigenDestino",fecha,origen ,destino );
        }

        public static int AgregarViaje(Viaje viaje)
        {
             return executeProcedureWithReturnValue("sp_generar_viaje",viaje.Id, viaje.Ruta, viaje.Aeronave, viaje.FechaSalida, viaje.FechaLlegada, viaje.FechaLlegadaEstimada);
              
        }


    }
}
