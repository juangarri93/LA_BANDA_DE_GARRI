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
        public DevolucionOpciones()
        {
            InitializeComponent();
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
    }
}
