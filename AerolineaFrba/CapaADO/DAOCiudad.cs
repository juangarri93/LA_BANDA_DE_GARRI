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

            executeProcedure("spinsertar_ciudad", 1, ciudad.Nombre,ciudad.Pais);

        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
              return retrieveDataTable("spmostrar_ciudad");
        }



        public static void EditarCiudad(Ciudad ciudad)
        {
            executeProcedure("speditar_ciudad", 1, ciudad.Nombre, ciudad.Pais);
        }

        public static void EliminarCiudad(Int32 codigoCiudad)
        {
            executeProcedure("speliminar_ciudad", codigoCiudad);
        }
    }
    

}
