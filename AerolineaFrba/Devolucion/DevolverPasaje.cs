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
            btnBuscarNroDeCompra.Enabled = true;
        }

        private void btnBuscarNroDeCompra_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                Cancelacion cancelacion = new Cancelacion(dtpFechaDevolucion.Value, Convert.ToInt32(txtNroDeCompra.Text), 4, txtMotivo.Text);

                if (Validaciones()) return;
                var ventanaCancelarPasajes = new CancelarPasajes(cancelacion);
                FormsHerramientas.mostrarVentanaNueva(ventanaCancelarPasajes, this);
            }
            catch (Exception ex)
            {

            }

          
        }

        private bool Validaciones()
        {

            if (txtNroDeCompra.Text == "")
            {
                MessageBox.Show("NO INGRESO NUMERO DE COMPRA");
                return true;
            }

            int nroDeCompra = Convert.ToInt32(txtNroDeCompra.Text);
            
             if (nroDeCompra <= 0)
            {
                MessageBox.Show("El numero de compra no puede ser menor o igual a cero");
                return true;
            }

             if (txtMotivo.Text == "")
            {
                MessageBox.Show("NO INGRESO EL MOTIVO DE LA CANCELACION");
                return true;
            }


            return false;
        }

        private void txtNroDeCompra_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
