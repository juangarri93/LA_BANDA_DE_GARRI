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
         public static DataTable estadisticaDestinosconPasPasajesComprados(decimal anio,int semestre)
            {
 
               return retrieveDataTable("sp_estadistico_destinos_mas_pasajes_comprados", anio,semestre);

            }

        //Falta sp
         public static DataTable estadisticaDestinosConAeronavesMasVacias(decimal anio, int semestre)
            {
 
               return retrieveDataTable("sp_estadistico_destinos_mas_pasajes_comprados", anio,semestre);

            }

         public static DataTable estadisticaClientesConMasPuntosAcumulados(DateTime desde, DateTime hasta)
         {

             return retrieveDataTable("sp_estadistico_clientes_mas_puntos_acumulados", desde, hasta);

         }

         public static DataTable estadisticaDestinosConPasajesCancelados(decimal anio, int semestre)
         {

             return retrieveDataTable("sp_estadistico_destinos_mas_pasajes_cancelados", anio, semestre);

         }

         public static DataTable estadisticaAeronavesConMayorCantidadDeDiasFueraDeServicio(decimal anio, int semestre)
         {

             return retrieveDataTable("sp_estadistico_aeronave_fuera_servicio ", anio, semestre);

         }

    } 
    
}
