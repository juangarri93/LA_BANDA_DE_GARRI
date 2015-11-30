using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.ConstructorDeClases;
using AerolineaFrba.Herramientas;

namespace AerolineaFrba.Devolucion
{
    public partial class DevolverPasaje : Form
    {
        public DevolverPasaje()
        {
            InitializeComponent();
        }

        private void DevolverPasaje_Load(object sender, EventArgs e)
        {
            btnBuscarNroDeCompra.Enabled = false;
        }

        private void btnBuscarNroDeCompra_Click(object sender, EventArgs e)
        {
            

            try
            {
                Cancelacion cancelacion = new Cancelacion(dtpFechaDevolucion.Value, Convert.ToInt32(txtNroDeCompra.Text), Convert.ToInt32(txtCodigoPasaje.Text), txtMotivo.Text);

                var ventanaCancelarPasajes = new CancelarPasajes(cancelacion);
                FormsHerramientas.mostrarVentanaNueva(ventanaCancelarPasajes, this);
            }
            catch (Exception ex)
            {

            }

          
        }

        private void txtNroDeCompra_TextChanged(object sender, EventArgs e)
        {
            btnBuscarNroDeCompra.Enabled = true;
        }
    }
}
