﻿using System;
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


        public static int VerificarClienteNoEsteVolando(decimal dni, int viaje)
        {
            int aux  = executeProcedureWithReturnValue("spverificarCliente",dni,viaje);
            return aux;
        
        }

        public static void AgregarCompra(Compra compra)
        {

            int auxPNR = executeProcedureWithReturnValue("spdame_PNR");

            auxPNR = auxPNR + 1; //Porque necesito insertar uno nuevo

             foreach (var Butacas in compra.ButacasSeleccionadas)
            {
                executeProcedure("spinsertar_compra", 1,auxPNR, compra.ViajeSeleccionado, compra.Nombre, compra.Apellido, compra.Dni, compra.Direccion, compra.Telefono, compra.Email, compra.FechaNac, compra.CantidadPasajes, compra.CantidadKG, compra.FechaDeViaje, compra.Importe, compra.Tipopago, Butacas.Id);
            }
         
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

        public static void AgregarCompraEncomienda(Compra compra)
        {
            int auxPNR = executeProcedureWithReturnValue("spdame_PNR");

            auxPNR = auxPNR + 1; //Porque necesito insertar uno nuevo

            executeProcedure("spinsertar_compraEncomienda", 1, auxPNR, compra.ViajeSeleccionado, compra.Nombre, compra.Apellido, compra.Dni, compra.Direccion, compra.Telefono, compra.Email, compra.FechaNac, compra.CantidadKG, compra.FechaDeViaje, compra.Importe, compra.Tipopago);
        }
    }
}
