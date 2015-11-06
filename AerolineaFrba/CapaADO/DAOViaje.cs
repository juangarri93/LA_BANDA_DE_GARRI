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

        public static DataTable getRutaAereaEspecifica(int id)
        {
            return retrieveDataTable("spMostrar_RutaAerea_esp",id);
        }

        public static DataTable Mostrar()
        {
            return retrieveDataTable("spmostrar_Viajes");
        }

        public static DataTable Buscar(DateTime fecha, string origen1, string destino1)
        {
            DataTable ro = DAOCiudad.buscarCiudad(origen1);
            DataTable rd = DAOCiudad.buscarCiudad(destino1);
            return retrieveDataTable("spbuscar_fechaOrigenDestino", fecha, ro.Rows[0].Field<int>("CodigoCiudad"), rd.Rows[0].Field<int>("CodigoCiudad"));
             
           // return retrieveDataTable("spbuscar_fechaOrigenDestino",fecha,origen ,destino );
        }

        public static void AgregarViaje(Viaje viaje)
        {
            /*executeProcedure("spinsertar_Viaje", 1, Convert.ToDateTime(viaje.FechaSalida.ToString("yyyy-MM-dd")), Convert.ToDateTime(viaje.FechaLlegada.ToString("yyyy-MM-dd")), Convert.ToDateTime(viaje.FechaLlegadaEstimada.ToString("yyyy-MM-dd")), viaje.Aeronave, viaje.Ruta, viaje.Habilitado);*/
            executeProcedure("spinsertar_Viaje", 1, viaje.FechaSalida, viaje.FechaLlegada, viaje.FechaLlegadaEstimada, viaje.Aeronave, viaje.Ruta, viaje.Habilitado);

        }


    }
}
