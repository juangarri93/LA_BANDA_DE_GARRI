using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.ConstructorDeClases;
using System.Data;

namespace AerolineaFrba.CapaADO
{
    class DAOMillas : SqlConnector
    {

        public static void AgregarMillas(Millas millas)
        {
            executeProcedure("spinsertar_millas", 1, millas.Id_Cliente, millas.Cantidad, millas.Fecha_Exp);
        }
       
        public static DataTable MostrarTodas()
        {
            return retrieveDataTable("spmostrar_millas");
        }

        public static DataTable buscarMillasDeCliente(int dni_cliente)
        {
            return retrieveDataTable("spbuscarMillas_cliente", dni_cliente);
        }

        public static void darDeBajaMillas(int dni_cliente)
        {
            executeProcedure("spbaja_millas", dni_cliente);
        }

        public static void restarMillas(int dni_cliente, int cantidad)
        {
            executeProcedure("sprestar_millas", dni_cliente, cantidad);
        }

        public static int Calcular_Millas(int dni_cliente)
        {
            return executeProcedureWithReturnValue("spcalcular_millas", dni_cliente);
        }


    }
    
}
