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
using AerolineaFrba.Herramientas;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ABMCiudadBajaModif : Form
    {

        private bool IsFiltroNombreCiudad = false; 

        public ABMCiudadBajaModif()
        {
            InitializeComponent();
        }

        private void deshabilitarTextBox()
        {
            txtPais.Enabled = false;
            txtNomb.Enabled = false;
            txtCodigo.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
 

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarCiudad();
        }

        private void buscarCiudad()
        {
            if (IsFiltroNombreCiudad)
            {
                this.dataListadoCiudades.DataSource = DAOCiudad.buscarCiudad(this.txtBuscar.Text);
                this.OcultarColumnas();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoCiudades.Rows.Count);
            }
        }

     
        
        private void Mostrar()
        {
            this.dataListadoCiudades.DataSource = DAOCiudad.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoCiudades.Rows.Count); 
        }

        private void OcultarColumnas()
        {
            this.dataListadoCiudades.Columns[0].Visible = false;
            this.dataListadoCiudades.Columns[1].Visible = true;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoCiudades.Rows.Count);

        }
     
        private void dataListadoCiudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoCiudades.Columns["dataGridViewCheckBoxColumn1"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListadoCiudades.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
      
        private void dataListadoCiudades_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dataListadoCiudades.CurrentRow.Cells["Id"].Value);
            this.txtNomb.Text = Convert.ToString(this.dataListadoCiudades.CurrentRow.Cells["Nombre"].Value);
   
            this.tabControl1.SelectedIndex = 1;
        }
 

         private Ciudad cargarCiudadParaEditar()
        {
            Boolean val = true;
            return new Ciudad(Convert.ToInt32(txtCodigo.Text), txtNomb.Text,val);
        }

         private void btnGuardar_Click_1(object sender, EventArgs e) 
        {

            try
            {
                DAOCiudad.EditarCiudad(cargarCiudadParaEditar());
                MessageBox.Show("La Ciudad se agrego correctamente.");
                deshabilitarTextBox();
                limpiarTextBox();
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;

            }
            catch(Exception ex)
            {

                MessageBox.Show("Hubo un error." + ex.Message); 
            
            }
        }

         private void limpiarTextBox()
         {
            txtCodigo.Text = "";
 
            txtNomb.Text = "";
         }

        private void btnBajaLogica_Click(object sender, EventArgs e)
        {

        }

        private void bajaLogica1_CheckedChanged(object sender, EventArgs e)
        {

        }

      

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNomb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.IsFiltroNombreCiudad = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;

            habilitarTextBox();
        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            limpiarTextBox();
            deshabilitarTextBox();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
        }


        private void habilitarTextBox()
        {
            txtNomb.Enabled = true;
            txtPais.Enabled = true;

        }
      
           

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         if (checkBoxbajaLogica1.Checked)
            {
                botonBajaLogica.Enabled = true;
                this.dataListadoCiudades.Columns[0].Visible = true;
            }
            else
            {
                botonBajaLogica.Enabled = false;
                this.dataListadoCiudades.Columns[0].Visible = false;
            }
        }

        private void botonBajaLogica_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea dar de baja definitiva la Ciudad", "Sistema de Aerolineas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;

                    foreach (DataGridViewRow row in dataListadoCiudades.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            DAOCiudad.darDeBajaCiudad(Codigo);


                        }

                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

            checkBoxbajaLogica1.Checked = false;

        }


        private void ABMBajaModificacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
            botonBajaLogica.Enabled = false;
            btnCancelar.Enabled = false;
            btnCancelar.Enabled = false;
            txtCodigo.ReadOnly = true;
            btnGuardar.Enabled = false;
            deshabilitarTextBox();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

  

    }
}
