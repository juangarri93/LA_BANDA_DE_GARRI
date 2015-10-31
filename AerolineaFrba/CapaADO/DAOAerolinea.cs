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

            executeProcedure("LA_BANDA_DE_GARRI.spinsertar_aeronave", 1, aeronave.FechaAlta, aeronave.NumeroAeronave, aeronave.Modelo,
                             aeronave.Matricula, aeronave.Fabricante, aeronave.TipoDeServicio, aeronave.BajaPorFueraDeServicio,
                             aeronave.FechaDeFueraDeServicio, aeronave.FechaDeReinicioDeServicio,
                             aeronave.CantidadButacaPasillo, aeronave.CantidadButacaVentana,aeronave.KGDisponible);

        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {


            return retrieveDataTable("LA_BANDA_DE_GARRI.spmostrar_aeronave");
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

        public static void EditarAeronave(Aeronave aeronave)
        {
            executeProcedure("speditar_aeronave", aeronave.CodigoAeronave, aeronave.FechaAlta, aeronave.NumeroAeronave, aeronave.Modelo,
                            aeronave.Matricula, aeronave.Fabricante, aeronave.TipoDeServicio, aeronave.BajaPorFueraDeServicio,
                            aeronave.BajaPorVidaUtil, aeronave.FechaDeFueraDeServicio, aeronave.FechaDeReinicioDeServicio, aeronave.FechaDeBajaDefinitiva,
                            aeronave.CantidadButacaPasillo,aeronave.CantidadButacaVentana, aeronave.KGDisponible);
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
            return retrieveDataTable("LA_BANDA_DE_GARRI.spmostrar_fabricante");
        }



        public static DataTable getModelo()
        {
            return retrieveDataTable("LA_BANDA_DE_GARRI.spmostrar_modelo");
        }

        public static DataTable getTipoServicio()
        {
            return retrieveDataTable("LA_BANDA_DE_GARRI.spmostrar_tipo_servicio");
        }
    }

}
