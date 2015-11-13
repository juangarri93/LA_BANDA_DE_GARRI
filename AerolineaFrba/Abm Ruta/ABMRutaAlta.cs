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
            cmbHabiltiado.Items.Add("");
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

                DAORuta.AgregarRuta(cargarRuta());
                MessageBox.Show("La Ruta se agrego correctamente.");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);               
            }
        }

        public void limpiar()
        {
            txtCodigoRuta.Text = "";
            txtTipoServicio.Text = "";
            cbOrigen.ValueMember = null;
            cbDestino.ValueMember = null;
            txtPrecioKG.Text = "";
            txtPrecioBase.Text = "";
        }

        private  Ruta cargarRuta()
        {
            return new Ruta(Convert.ToInt32(txtCodigoRuta.Text), txtTipoServicio.Text, cbOrigen.SelectedIndex + 1, cbDestino.SelectedIndex + 1, Convert.ToInt32(txtPrecioKG.Text), Convert.ToInt32(txtPrecioBase.Text), Convert.ToString(cmbHabiltiado.SelectedIndex + 1));
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
