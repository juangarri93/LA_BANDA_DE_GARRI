using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AerolineaFrba.ConstructorDeClases;


namespace AerolineaFrba.CapaADO
{
    class DAOPremio : SqlConnector
    {
        

        public static DataTable MostrarTodos()
        {
            return retrieveDataTable("spmostrar_premios");
        }

        public static DataTable buscarPremio(string nombre)
        {
            return retrieveDataTable("spmostrar_premios_nombre", nombre);
        }

        public static void darDeBajapremio(int id_Premio)
        {
            executeProcedure("spbaja_premio", id_Premio);
        }

        public static int restarCantidadPremios(int id_Premio, int cantidad)
        {
            return executeProcedureWithReturnValue("sprestar_premio", id_Premio, cantidad);
        }


       
    }
}
