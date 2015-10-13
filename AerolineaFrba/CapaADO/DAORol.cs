using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
