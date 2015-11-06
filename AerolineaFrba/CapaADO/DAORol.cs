using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


using AerolineaFrba.ConstructorDeClases;

namespace AerolineaFrba.CapaADO
{
    public class DAORol : SqlConnector
    {
        public static void AgregarRol(Rol rol)
        {
            rol.Codigo = executeProcedureWithReturnValue("spinsertar_rol", rol.Codigo, rol.Nombre, rol.Habilitado);
            
            //Recibo el id del rol donde se inserto en la tabla rol para cargar las funcionalidades en la tabla
            foreach (var funcionalidad in rol.Funcionalidades)
            {
                executeProcedure("spinsertar_rol_funcionalidad", rol.Codigo, funcionalidad + 1);
            }
        }


        public static Rol DameRol(String N)
        {
            var table = retrieveDataTable("sptraer_Rol", N);
            var rol = dataRowToRol(table.Rows[0]);

          //table = retrieveDataTable("getRolFunc", id);

          // var lista = (from DataRow fila in table.Rows select (Convert.ToInt32(fila["Id_Funcionalidad"])) - 1).ToList();
          //  rol.Funcionalidades = lista;
            return rol;
        }

        private static Rol dataRowToRol(DataRow dr)
        {
            return new Rol(Convert.ToInt32(dr["ID"]), dr["Rol"].ToString(), dr["Habilitado"].ToString() == "1");
        }

        public static DataTable getRol()
        {
            return retrieveDataTable("spmostrar_Rol");
        }

        public static void EditarNombreRol(String nombreRolAnterior, String nombreRolNuevo)
        {
            executeProcedure("spinsertar_modificar_nombre_rol", nombreRolAnterior, nombreRolNuevo);
        }

        public static void ActualizarRolFuncionalidad(Rol rol)
        {
            rol.Codigo = executeProcedureWithReturnValue("speliminar_funcionalidades_para_rol", rol.Codigo);

            //Recibo el id del rol donde se inserto en la tabla rol para cargar las funcionalidades en la tabla
            foreach (var funcionalidad in rol.Funcionalidades)
            {
                executeProcedure("spinsertar_rol_funcionalidad", rol.Codigo, funcionalidad + 1);
            }
        }
    }
}
