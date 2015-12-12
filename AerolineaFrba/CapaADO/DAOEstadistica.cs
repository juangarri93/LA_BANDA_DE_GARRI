using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AerolineaFrba.CapaADO
{
    class DAOEstadistica: SqlConnector
    {
        public static DataTable estadisticaDestinosconPasPasajesComprados(DateTime desde, DateTime hasta)
            {
 
               return retrieveDataTable("sp_estadistico_destinos_mas_pasajes_comprados", desde,hasta);

            }

      
        public static DataTable estadisticaDestinosConAeronavesMasVacias(DateTime desde, DateTime hasta)
            {

                return retrieveDataTable("sp_estadistico_destinos_mas_pasajes_comprados", desde, hasta);

            }

        public static DataTable estadisticaClientesConMasPuntosAcumulados(DateTime desde, DateTime hasta)
         {

             return retrieveDataTable("sp_estadistico_clientes_mas_puntos_acumulados", desde, hasta);

         }

        public static DataTable estadisticaDestinosConPasajesCancelados(DateTime desde, DateTime hasta)
         {

             return retrieveDataTable("sp_estadistico_destinos_mas_pasajes_cancelados", desde, hasta);

         }

        public static DataTable estadisticaAeronavesConMayorCantidadDeDiasFueraDeServicio(DateTime desde, DateTime hasta)
         {

             return retrieveDataTable("sp_estadistico_aeronave_fuera_servicio ", desde, hasta);

         }

    } 
    
}
