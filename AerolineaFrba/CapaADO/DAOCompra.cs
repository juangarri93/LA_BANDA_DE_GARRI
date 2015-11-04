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
    class DAOCompra : SqlConnector
    {
        public static void AgregarCompra(Compra compra)
        {

            executeProcedure("spinsertar_compra", 1, compra.Nombre, compra.Apellido, compra.Dni, compra.Direccion, compra.Telefono, compra.Email, compra.FechaNac, compra.FechaDeViaje,compra.Origen,compra.Destino,compra.CantidadPasajes,compra.CantidadKG,compra.ViajeSeleccionado,compra.Estado);

        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return retrieveDataTable("spmostrar_compra");
        }

        public static DataTable buscarCompra(string textoBuscar)
        {
            return retrieveDataTable("spbuscar_compra", textoBuscar);
        }



        public static void EditarCompra(Compra compra)
        {
            executeProcedure("speditar_compra", 1, compra.Nombre, compra.Apellido, compra.Dni, compra.Direccion, compra.Telefono, compra.Email, compra.FechaNac, compra.FechaDeViaje, compra.Origen, compra.Destino, compra.CantidadPasajes, compra.CantidadKG, compra.ViajeSeleccionado);
        }

        public static void EliminarCompra(int id)
        {
            executeProcedure("speliminar_compra", id);
        }

        public static void darDeBajaCompra(int id)
        {
            executeProcedure("spbaja_compra", id);
        }
    }
}
