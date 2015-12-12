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
using AerolineaFrba.CapaADO;

namespace AerolineaFrba.Devolucion
{
    public partial class LiberacionDeKGs : Form
    {
        public LiberacionDeKGs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Cancelacion cancelacion = new Cancelacion(dtpFechaDevolucion.Value, Convert.ToInt32(txtNroDeCompra.Text),Convert.ToInt32(txtEncomienda.Text), txtMotivo.Text);

                if (Validaciones()) return;
                DAOCancelacion.cancelarEncomienda(cancelacion);

                MessageBox.Show("Encomienda cancelada con exito!!!!");
                this.Hide();
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

            if(txtEncomienda.Text == "")
            {
                MessageBox.Show("NO INGRESO NUMERO DE ENCOMIENDA");
                return true;
            }


            int nroDeEncomienda = Convert.ToInt32(txtEncomienda.Text);

            if (nroDeEncomienda <= 0)
            {
                MessageBox.Show("El numero de encomienda no puede ser menor o igual a cero");
                return true;
            }


            if (txtMotivo.Text == "")
            {
                MessageBox.Show("NO INGRESO EL MOTIVO DE LA CANCELACION");
                return true;
            }


            return false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
