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
                //limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);               
            }
        }

        private  Ruta cargarRuta()
        {
           return new Ruta(txtCodigoRuta.Text,txtTipoServicio.Text,cbOrigen.ValueMember,cbDestino.ValueMember,txtPrecioKG.Text,txtPrecioBase.Text);
        }

    }
}
