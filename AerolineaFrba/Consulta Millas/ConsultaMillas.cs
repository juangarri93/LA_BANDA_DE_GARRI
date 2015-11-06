using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AerolineaFrba.CapaADO;

namespace AerolineaFrba.Consulta_Millas
{
    public partial class ConsultaMillas : Form
    {
        public ConsultaMillas()
        {
            InitializeComponent();
        }

        private bool EsNumero(string cadena)
        {
            var regex = new Regex(@"^-*[0-9,\.]+$");
            return regex.IsMatch(cadena);
        }


        //Metodo Mostrar
        private void Mostrar(int dni)
        {

            dtvMillas.DataSource = DAOMillas.buscarMillasDeCliente(dni);
           // this.dtvMillas.Columns[0].Visible = false;
            lTotalViajes.Text = "Total de Viajes: " + Convert.ToString(dtvMillas.Rows.Count);
            
            int aux = (CalcularMillas(dni));
          
            if(aux >= 0)
                lMillas.Text = "Total de Millas: " + Convert.ToString(aux);
            else
                lMillas.Text = "Total de Millas: 0";
        }

        public int CalcularMillas(int dni)
        {
            int resultado = DAOMillas.Calcular_Millas(dni);
            return resultado;
        }

        private void btnConsultarMillas_Click(object sender, EventArgs e)
        {
            int dni;
            if (String.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("El campo DNI no puede estar incompleto");
                return;
            }
            
            if (!EsNumero(txtDni.Text))
            {
                MessageBox.Show("Debe Ingresar un valor numerico");
                return;
            }

            dni = Convert.ToInt32(txtDni.Text);
            this.Mostrar(dni);
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtvMillas.Hide();
            dtvMillas.Show();
            txtDni.Text = "";
            lTotalViajes.Text = "Total de Viajes: "  ;
            lMillas.Text = "Total de Millas: "  ;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

         
 
    }
}
