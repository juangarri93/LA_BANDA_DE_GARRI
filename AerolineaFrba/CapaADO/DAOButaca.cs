using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.ConstructorDeClases;
using AerolineaFrba.CapaADO;
using System.Data;


namespace AerolineaFrba.CapaADO
{
    class DAOButaca : SqlConnector
    {
        public static DataTable ButacasLibres(int id_viaje)
        {

            return retrieveDataTable("sp_butacas_libres", id_viaje);

        }

        public static void MarcarComoOcupada(Butaca butaca)
        {
            executeProcedure("spmarcar_butaca_ocupada", butaca.Id);
        }


    }
}
