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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class ABMRutaBajaModificacion : Form
    {
        public ABMRutaBajaModificacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarTextBox();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            limpiar();
        }

        public void limpiar()
        {
            txtCodigoRuta.Text = "";
            txtTipoServicio.Text = "";
            cbOrigen.ValueMember = null;
            cbDestino.ValueMember = null;
            txtPrecioKG.Text = "";
            txtPrecioBase.Text = "";
            cbHabilitado.ValueMember = null;
        }

        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataGridView.DataSource = DAORuta.Mostrar();
           
        }

        private void ABMRutaBajaModificacion_Load(object sender, EventArgs e)
        {
            txtCodigoRuta.ReadOnly = true;
            deshabilitarTextBox();
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            cbHabilitado.Items.Add("");
            cbHabilitado.Items.Add("Habilitado");
            cbHabilitado.Items.Add("Deshabilitado");
            this.dataGridView.Columns[0].Visible = false;
            Mostrar();
        }

        private void deshabilitarTextBox()
        {

            txtCodigoRuta.Enabled = false;
            txtTipoServicio.Enabled = false;
            cbOrigen.Enabled = false;
            cbDestino.Enabled = false;
            txtPrecioKG.Enabled = false;
            txtPrecioBase.Enabled = false;
            cbHabilitado.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            soloLectura();
            habilitarTextBox();

        }

        private void soloLectura()
        {
          
            txtTipoServicio.ReadOnly = true;
            cbOrigen.Enabled = false;
            cbDestino.Enabled = false;
            txtPrecioKG.ReadOnly = true;
            txtPrecioBase.ReadOnly = true;
            cbHabilitado.Enabled = false;
        }

        private void habilitarTextBox()
        {
      
            txtTipoServicio.Enabled = true;
            txtPrecioKG.Enabled = true;
            txtPrecioBase.Enabled = true;
            cbHabilitado.Enabled = false;
        }

        private void btnBajaLogica_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxbajaLogica1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxbajaLogica1.Checked)
            {
                btnBajaLogica.Enabled = true;
                this.dataGridView.Columns[0].Visible = true;
            }
            else
            {
                btnBajaLogica.Enabled = false;
                this.dataGridView.Columns[0].Visible = false;
            }
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {

            habilitarModificacion();

            this.txtCodigoRuta.Text = Convert.ToString(this.dataGridView.CurrentRow.Cells["id_Ruta"].Value);
            this.txtTipoServicio.Text = Convert.ToString(this.dataGridView.CurrentRow.Cells["tipo_servicio"].Value);
            this.txtPrecioBase.Text = Convert.ToString(this.dataGridView.CurrentRow.Cells["precio_base_pasaje"].Value);
            this.txtPrecioKG.Text = Convert.ToString(this.dataGridView.CurrentRow.Cells["precio_base_kg"].Value);
            this.cbHabilitado.ValueMember = Convert.ToString(this.dataGridView.CurrentRow.Cells["habilitado"].Value);
            this.cbOrigen.ValueMember = Convert.ToString(this.dataGridView.CurrentRow.Cells["idCiudadOrigen"].Value);
            this.cbDestino.ValueMember = Convert.ToString(this.dataGridView.CurrentRow.Cells["idCiudadDestino"].Value);
           
            cargarComboBox();
          
        }

        private void habilitarModificacion()
        {
        
            txtTipoServicio.ReadOnly = false;
            cbOrigen.Enabled = true;
            cbDestino.Enabled = true;
            txtPrecioKG.ReadOnly = false;
            txtPrecioBase.ReadOnly = false;
            cbHabilitado.Enabled = true;
        }

        private void cargarComboBox()
        {
            cbOrigen.DataSource = DAORuta.getCiudades().DefaultView;
            cbOrigen.DisplayMember = "Nombre";

            cbDestino.DataSource = DAORuta.getCiudades().DefaultView;
            cbDestino.DisplayMember = "Nombre";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                DAORuta.EditarRuta(cargarAerolineParaEditar());
                MessageBox.Show("La Ruta se modifico correctamente");
                deshabilitarTextBox();
                limpiar();
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error." + ex.Message);

            }



        }

        private Ruta cargarAerolineParaEditar()
        {
            return new Ruta(Convert.ToInt32(txtCodigoRuta.Text), txtTipoServicio.Text, cbOrigen.SelectedIndex + 1, cbDestino.SelectedIndex + 1, Convert.ToInt32(txtPrecioKG.Text), Convert.ToInt32(txtPrecioBase.Text), "papa");
        }
    }
}
