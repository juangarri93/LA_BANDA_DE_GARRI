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
        AerolineasPrincipal Aerolineas;

        public ABMAeronave(AerolineasPrincipal aerolineas)
        {
            InitializeComponent();
            Aerolineas = aerolineas;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventanaAltaAeronave = new ABMAeronaveAlta(this);
            FormsHerramientas.mostrarVentanaNueva(ventanaAltaAeronave, this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var ventanaBajaModificacionAeronave = new ABMBajaModificacion(this);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Aerolineas.Focus();
            this.Hide();
        }
   
    }
}
