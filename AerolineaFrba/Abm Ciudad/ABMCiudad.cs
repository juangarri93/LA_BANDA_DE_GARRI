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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ABMCiudad : Form
    {

        AerolineasPrincipal Aerolineas;

        public ABMCiudad(AerolineasPrincipal aerolineas)
        {
            InitializeComponent();
            Aerolineas = aerolineas;
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventanaAltaCiudad = new ABMCiudadAlta(this);
            FormsHerramientas.mostrarVentanaNueva(ventanaAltaCiudad, this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var ventanaBajaModif = new ABMCiudadBajaModif(this);
            FormsHerramientas.mostrarVentanaNueva(ventanaBajaModif, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aerolineas.Focus();
            
        }
    }
}
