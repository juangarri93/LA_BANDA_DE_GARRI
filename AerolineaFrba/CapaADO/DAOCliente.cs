using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.ConstructorDeClases;
using System.Data;

namespace AerolineaFrba.CapaADO
{
    class DAOCliente : SqlConnector
    {
        public static void AgregarCliente(Persona cliente)
        {
            bool flag = false;

            if (cliente.Estado == "Habilitado")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            executeProcedure("spinsertar_cliente", 1, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Direccion, cliente.Telefono, cliente.Email, cliente.FechaNac);

        }

        //Metodo Mostrar
        public static DataTable MostrarClientes()
        {
            return retrieveDataTable("spmostrar_clientes");
        }

        public static DataTable buscarClientePorDni(decimal dni)
        {
            return retrieveDataTable("spmostrar_clientes_pordni", dni);
        }
    }
}
