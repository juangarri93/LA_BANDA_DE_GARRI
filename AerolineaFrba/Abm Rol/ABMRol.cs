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
        AerolineasPrincipal Aerolineas;

        public ABMRol(AerolineasPrincipal aerolineas)
        {
            InitializeComponent();
            Aerolineas = aerolineas;
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
            var ventanaBajaModificacionRol = new ABMRolBajaModificacion();
            FormsHerramientas.mostrarVentanaNueva(ventanaBajaModificacionRol, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aerolineas.Focus();
        }
    }
}
