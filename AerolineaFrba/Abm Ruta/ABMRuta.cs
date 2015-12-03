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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class ABMRuta : Form
    {
        AerolineasPrincipal Aerolineas;

        public ABMRuta(AerolineasPrincipal aerolineas)
        {
            InitializeComponent();
            Aerolineas = aerolineas;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventanaAltaRuta = new ABMRutaAlta();
            FormsHerramientas.mostrarVentanaNueva(ventanaAltaRuta, this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var ventanaBajaModificacionRuta = new ABMRutaBajaModificacion();
            FormsHerramientas.mostrarVentanaNueva(ventanaBajaModificacionRuta, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aerolineas.Focus();
        }
    }
}
