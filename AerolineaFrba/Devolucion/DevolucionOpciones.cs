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

namespace AerolineaFrba.Devolucion
{
    public partial class DevolucionOpciones : Form
    {

        AerolineasPrincipal Aerolineas;

        public DevolucionOpciones(AerolineasPrincipal aerolineas)
        {
            InitializeComponent();
            Aerolineas = aerolineas;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaAlta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ventanaDevolverPasaje= new DevolverPasaje();
            FormsHerramientas.mostrarVentanaNueva(ventanaDevolverPasaje, this);
        }

        private void DevolucionOpciones_Load(object sender, EventArgs e)
        {
            btnDevolverPasaje.Enabled = true;
            btnLiberacionDeKGs.Enabled = true;
        }

        private void btnLiberacionDeKGs_Click(object sender, EventArgs e)
        {
            var ventanaLiberacionDeKgs = new LiberacionDeKGs();
            FormsHerramientas.mostrarVentanaNueva(ventanaLiberacionDeKgs, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aerolineas.Focus();
        }
    }
}
