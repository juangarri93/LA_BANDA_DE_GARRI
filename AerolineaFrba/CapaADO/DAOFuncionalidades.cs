using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AerolineaFrba.CapaADO
{
    public class DAOFuncionalidades : SqlConnector
    {
        public static DataTable getFuncionalidades()
        {
            return retrieveDataTable("spMostrar_Funcionalidades");
        }
    }
}
