using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Herramientas;

namespace AerolineaFrba.Abm_Rol
{
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventanaAltaRol = new ABMRolAlta();
            FormsHerramientas.mostrarVentanaNueva(ventanaAltaRol, this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var ventanaBajaModificacionRol = new ABMRolAlta();
            FormsHerramientas.mostrarVentanaNueva(ventanaBajaModificacionRol, this);
        }
    }
}
