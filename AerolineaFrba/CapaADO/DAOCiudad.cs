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
    public class DAOCiudad : SqlConnector
    {

        public static void AgregarCiudad(Ciudad ciudad)
        {

            executeProcedure("spinsertar_ciudad", 1, ciudad.Nombre ,ciudad.Habilitado);

        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return retrieveDataTable("spmostrar_ciudades");
        }

        public static DataTable buscarCiudad(string textoBuscar)
        {
            return retrieveDataTable("spbuscar_ciudad", textoBuscar);
        }

        public static void EditarCiudad(Ciudad ciudad)
        {
            executeProcedure("speditar_ciudad", 1, ciudad.Nombre );
        }

        public static void EliminarCiudad(Int32 codigoCiudad)
        {
            executeProcedure("speliminar_ciudad", codigoCiudad);
        }
        
        public static void darDeBajaCiudad(int Codigo)
        {
            executeProcedure("spbaja_ciudad", Codigo);
        }

    }
    

}
