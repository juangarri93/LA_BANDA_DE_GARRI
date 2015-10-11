using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace AerolineaFrba.Herramientas
{
    public class FormsHerramientas
    {

        public static void  mostrarVentanaNueva(Form ventanaNueva, Form ventanaPadre){

            ventanaNueva.Visible = true;
        
        }
  
            //Mostrar Mensaje de Confirmacion
            public static void MensajeOk(string mensaje)
            {

                MessageBox.Show(mensaje, "Sistema de Aerolinea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Mostraar Mensaje de Error
            public static void MensajeError(string mensaje)
            {

                MessageBox.Show(mensaje, "Sistema de Aerolinea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
}
