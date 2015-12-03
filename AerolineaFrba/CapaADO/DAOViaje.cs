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
           
             return executeProcedureWithReturnValue("sp_generar_viaje", 1, viaje.Ruta, viaje.Aeronave, viaje.FechaSalida, viaje.FechaLlegada, viaje.FechaLlegadaEstimada); ;
              
        }
        public static int getKgDisponibles(int id_viaje)
        {
            return executeProcedureWithReturnValue("sp_Kg_disponibles", id_viaje);
         
        }


        public static int CheckearViaje(string matricula, string origen, string destino)
        {
            return executeProcedureWithReturnValue("sp_checkViaje", matricula, origen, destino);

        }

        public static void RegistrarLlegada(string matricula,  DateTime fecha, int viaje)
        {
            executeProcedure("sp_registrar_llegada_destino", matricula,fecha,viaje);
        }

    }
}
