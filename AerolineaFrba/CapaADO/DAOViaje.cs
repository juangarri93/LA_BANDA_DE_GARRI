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

        public static DataTable Buscar(DateTime fecha, string origen1, string destino1)
        {
            DataTable ro = DAOCiudad.buscarCiudad(origen1);
            DataTable rd = DAOCiudad.buscarCiudad(destino1);
            return retrieveDataTable("spbuscar_fechaOrigenDestino", fecha, ro.Rows[0].Field<int>("Id"), rd.Rows[0].Field<int>("Id"));
             
           // return retrieveDataTable("spbuscar_fechaOrigenDestino",fecha,origen ,destino );
        }

        public static int AgregarViaje(Viaje viaje)
        {

            int resultado = 2;
            return executeProcedureWithReturnValue("sp_generar_viaje",1, viaje.Ruta, viaje.Aeronave, viaje.FechaSalida, viaje.FechaLlegada, viaje.FechaLlegadaEstimada, resultado);
              
        }


    }
}
