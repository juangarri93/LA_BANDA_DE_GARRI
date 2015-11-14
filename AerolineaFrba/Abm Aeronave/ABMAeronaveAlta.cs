using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.CapaADO;
using AerolineaFrba.ConstructorDeClases;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ABMAeronaveAlta : Form
    {
        
        public ABMAeronaveAlta()
        {
            InitializeComponent();
        }

        private void ABMAeronaveAlta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cargarComboBox();

        }

        private void cargarComboBox()
        {
            cbFabricante.DataSource = DAOAerolinea.getFabricante().DefaultView;
            cbFabricante.DisplayMember = "Nombre";
                
            cbModelo.DataSource = DAOAerolinea.getModelo().DefaultView;
            cbModelo.DisplayMember = "Nombre";
            
            cbTipoServicio.DataSource = DAOAerolinea.getTipoServicio().DefaultView;
            cbTipoServicio.DisplayMember = "Tipo_Servicio";
         
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
          
            try
            {
                if (Validaciones()) return;
                DAOAerolinea.AgregarAeronave(CargarAerolinea());
                MessageBox.Show("La Aeronave se agrego correctamente.");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
                    
            }
        }

        


        private bool Validaciones()
        {
          
            if (txtNumeroAeronave.Text == "")
            {
                MessageBox.Show("NO INGRESO NUMERO DE AERONAVE");
                return true;

            }

            int numero = Convert.ToInt32(txtNumeroAeronave.Text);

            if (numero < 0)
            {
                MessageBox.Show("EL NUMERO INGRESADO ES NEGATIVO");
                return true;
            }

            if(txtMatricula.Text == "")
            {
                MessageBox.Show("NO INGRESO EL NUMERO DE MATRICULA");
                return true;
            }

            if(txtCantidadButacasVentana.Text == "")
            {
                MessageBox.Show("NO INGRESO LA CANTIDAD DE BUTACAS VENTANA");
                return true;
            }

            int butacasVentana = Convert.ToInt32(txtCantidadButacasVentana.Text);

            if(butacasVentana < 0)
            {
                MessageBox.Show("La CANTIDAD DE BUTACAS VENTANA NO PUEDEN SER UN VALOR MENOR O IGUAL A CERO");
                return true;
            }

            if (txtCantidadDeButacasPasillo.Text == "")
            {
                MessageBox.Show("NO INGRESO LA CANTIDAD DE BUTACAS PASILLO");
                return true;
            }

            int butacasPasillo = Convert.ToInt32(txtCantidadDeButacasPasillo.Text);

            if (butacasPasillo < 0)
            {
                MessageBox.Show("La CANTIDAD DE BUTACAS PASILLO NO PUEDEN SER UN VALOR MENOR O IGUAL A CERO");
                return true;
            }

            if (txtCantidadDeKG.Text == "")
            {
                MessageBox.Show("NO INGRESO LA CANTIDAD DE KG DISPONIBLES");
                return true;
            }

            int cantidadKG = Convert.ToInt32(txtCantidadDeKG.Text);

            if (cantidadKG < 0)
            {
                MessageBox.Show("La CANTIDAD DE KG DISPONIBLES NO PUEDE SER UN VALOR MENOR O IGUAL A CERO");
                return true;
            }

            if (dtpFECHA.Value == DateTime.MinValue)
            {
                MessageBox.Show("LA FECHA DE ALTA DE SERVICIO NO ES VALIDA");
                return true;
            }

            return false;
        }

        private Aeronave CargarAerolinea() 
        {

            return new Aeronave(1,
                                dtpFECHA.Value, 
                                Convert.ToInt32(txtNumeroAeronave.Text),
                                (cbModelo.SelectedIndex + 1),
                                txtMatricula.Text,
                                (cbFabricante.SelectedIndex + 1),
                                (cbTipoServicio.SelectedIndex + 1),
                                "Habilitado",
                                dtpFECHA.Value,
                                dtpFECHA.Value,
                                Convert.ToInt32(txtCantidadDeButacasPasillo.Text),
                                Convert.ToInt32(txtCantidadButacasVentana.Text),
                                Convert.ToInt32(txtCantidadDeKG.Text),0);
                                 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            limpiar();
         
        }

        private void limpiar() 
        {
            txtNumeroAeronave.Text = "";
            dtpFECHA.Value = DateTime.Today;
            txtMatricula.Text = ""; 
            txtCantidadDeButacasPasillo.Text = "";
            txtCantidadButacasVentana.Text = "";
            txtCantidadDeKG.Text = "";
        
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
