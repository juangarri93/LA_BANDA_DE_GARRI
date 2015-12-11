using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AerolineaFrba.Herramientas;

using AerolineaFrba.ConstructorDeClases;

namespace AerolineaFrba.CapaADO
{
    public class DAOAerolinea : SqlConnector
    {

        public static void AgregarAeronave(Aeronave aeronave)
        {

            executeProcedure("spinsertar_aeronave",1,aeronave.FechaAlta, aeronave.NumeroAeronave, aeronave.Modelo,
                            aeronave.Matricula, aeronave.Fabricante, aeronave.TipoDeServicio, aeronave.CantidadButacaVentana,aeronave.CantidadButacaPasillo,
                             aeronave.BajaPorFueraDeServicio,aeronave.FechaDeFueraDeServicio,
                             aeronave.KGDisponible);


           // SqlConnector.executeProcedure("spinsertar_aeronave", 1, aeronave.NumeroAeronave);

        }
        
        //Metodo Mostrar
        public static DataTable Mostrar()
        {


            return retrieveDataTable("spmostrar_aeronave");
        }


        public static DataTable buscarNumeroAeronave(string textoBuscar)
        {
            return retrieveDataTable("spbuscarNombre_aeronave", textoBuscar);
        }

        public static DataTable buscarFabricante(string textoBuscar)
        {
            return retrieveDataTable("spbuscarFabricante_aeronave", textoBuscar);
        }

        public static DataTable buscarModelo(string textoBuscar)
        {
            return retrieveDataTable("spbuscarModelo_aeronave", textoBuscar);
        }

        public static int EditarAeronave(Aeronave aeronave)
        {
            int aux = executeProcedureWithReturnValue("speditar_aeronave", aeronave.CodigoAeronave, aeronave.FechaAlta, aeronave.NumeroAeronave, aeronave.Matricula, aeronave.Modelo,
                            aeronave.Fabricante, aeronave.TipoDeServicio, aeronave.CantidadButacaVentana, aeronave.CantidadButacaPasillo,aeronave.KGDisponible,aeronave.BajaPorFueraDeServicio,
                            aeronave.FechaDeFueraDeServicio, aeronave.FechaDeReinicioDeServicio,
                            aeronave.FlagBajaFueraServicio);
            return aux;
        }

        public static void EliminarAeronave(Int32 codigoAeronave)
        {
            executeProcedure("speliminar_aeronave", codigoAeronave);
        }

        public static void darDeBajaAerolinea(int Codigo)
        {
            executeProcedure("spdardebaja_aerolinea", Codigo);
        }

        public static DataTable getFabricante()
        {
            return retrieveDataTable("spmostrar_fabricante");
        }



        public static DataTable getModelo()
        {
            return retrieveDataTable("spmostrar_modelo");
        }

        public static DataTable getTipoServicio()
        {
            return retrieveDataTable("spmostrar_tipo_servicio");
        }

      
    }

}
