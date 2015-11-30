using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.ConstructorDeClases;
using AerolineaFrba.CapaADO;
using System.Data;

using AerolineaFrba.ConstructorDeClases;

namespace AerolineaFrba.CapaADO
{
    public class DAOCancelacion : SqlConnector
    {
        public static DataTable getButacas(Cancelacion cancelacion)
        {

            return retrieveDataTable("spMostrar_butacas_pasaje_compra", cancelacion.NumeroPasaje,cancelacion.NumeroDeCompraPNR);

        }
    }
}
