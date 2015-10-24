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
                MessageBox.Show("1 -" + cbOrigen);     
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
            return new Ruta(txtCodigoRuta.Text, txtTipoServicio.Text, Convert.ToString(cbOrigen.SelectedIndex + 1), Convert.ToString(cbDestino.SelectedIndex + 1), txtPrecioKG.Text, txtPrecioBase.Text);
        }

    }
}
