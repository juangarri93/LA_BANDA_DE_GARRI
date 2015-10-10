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
        public ABMCiudad()
        {
            InitializeComponent();
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventanaAltaCiudad = new ABMCiudadAlta();
            FormsHerramientas.mostrarVentanaNueva(ventanaAltaCiudad, this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }
    }
}
