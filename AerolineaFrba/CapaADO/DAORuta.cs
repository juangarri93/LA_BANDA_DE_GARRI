using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AerolineaFrba.CapaADO
{
    public class DAORuta:SqlConnector
    {
        public static DataTable getCiudades()
        {
            return retrieveDataTable("spMostrar_Ciudad_sin_baja_util");
        }

        public static void AgregarRuta(ConstructorDeClases.Ruta ruta)
        {
            throw new NotImplementedException();
        }
    }
}
