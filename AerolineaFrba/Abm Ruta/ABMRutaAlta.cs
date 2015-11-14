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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class ABMRutaAlta : Form
    {
        public ABMRutaAlta()
        {
            InitializeComponent();
        }

        private void ABMRutaAlta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cbTipoDeServicio.DataSource = DAOAerolinea.getTipoServicio().DefaultView;
            cbTipoDeServicio.DisplayMember = "Tipo_Servicio";

            cmbHabiltiado.Items.Add("Habilitado");
            cmbHabiltiado.Items.Add("Deshabilitado");
            cargarComboBox();

        }

        private void cargarComboBox() 
        {
            cbOrigen.DataSource = DAORuta.getCiudades().DefaultView;
            cbOrigen.DisplayMember = "Nombre";

            cbDestino.DataSource = DAORuta.getCiudades().DefaultView;
            cbDestino.DisplayMember = "Nombre";
                 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
              try
            {
                if (Validaciones()) return;
                DAORuta.AgregarRuta(cargarRuta());
                MessageBox.Show("La Ruta se agrego correctamente.");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);               
            }
        }

        private bool Validaciones()
        {
            if(txtCodigo.Text == "")
            {
                MessageBox.Show("FALTA AGREGAR EL CAMPO CODIGO");
                return true;
            }

            int codigo = Convert.ToInt32(txtCodigo.Text);

            if(codigo <= 0)
            {
                MessageBox.Show("EL CODIGO INGRESADO NO PUEDE SER MENOR O IGUAL A 0");
                return true;
            }

            if (txtPrecioKG.Text == "")
            {
                MessageBox.Show("FALTA AGREGAR EL PRECIO POR KG");
                return true;
            }

            int precioKG = Convert.ToInt32(txtPrecioKG.Text);

            if (precioKG <= 0)
            {
                MessageBox.Show("EL PRECIO POR KG NO PUEDE SER MENOR O IGUAL A 0");
                return true;
            }

            if (txtPrecioBase.Text == "")
            {
                MessageBox.Show("FALTA AGREGAR EL CAMPO PRECIO BASE");
                return true;
            }

            int precioBase = Convert.ToInt32(txtPrecioBase.Text);

            if (precioBase <= 0)
            {
                MessageBox.Show("EL PRECIO BASE NO PUEDE SER MENOR A 0");
                return true;
            }
            return false;
        }

        public void limpiar()
        {
       
            txtPrecioKG.Text = "";
            txtPrecioBase.Text = "";
        }

        private  Ruta cargarRuta()
        {
            return new Ruta(1, Convert.ToInt32(txtCodigo.Text),cbTipoDeServicio.SelectedIndex + 1, cbOrigen.Text, cbDestino.Text, Convert.ToInt32(txtPrecioKG.Text), Convert.ToInt32(txtPrecioBase.Text),cmbHabiltiado.SelectedIndex);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
