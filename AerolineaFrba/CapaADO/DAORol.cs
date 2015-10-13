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
            MessageBox.Show(Convert.ToString(rol.Codigo));
        }
    }
}
