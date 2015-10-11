using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Herramientas;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ABMAeronave : Form
    {
        public ABMAeronave()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventanaAltaAeronave = new ABMAeronaveAlta();
            FormsHerramientas.mostrarVentanaNueva(ventanaAltaAeronave, this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var ventanaBajaModificacionAeronave = new ABMBajaModificacion();
            FormsHerramientas.mostrarVentanaNueva(ventanaBajaModificacionAeronave , this);
        }

        private void ABMAeronave_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
