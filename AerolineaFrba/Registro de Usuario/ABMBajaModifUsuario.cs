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

namespace AerolineaFrba.Registro_de_Usuario
{
    public partial class ABMBajaModifUsuario : Form
    {
  /*

        public ABMBajaModifUsuario()
        {
            InitializeComponent();
        }


        private void ABMBajaModifUsuario_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
            botonBajaLogica.Enabled = false;
            btnCancelar.Enabled = false;
 
            txtCodigo.ReadOnly = true;
            btnGuardar.Enabled = false;
            deshabilitarTextBox();

        } 


        private void Mostrar()
        {
            this.dataListadoUsuarios.DataSource = DAOUsuario.Mostrar();
            this.OcultarColumnas();
          
        }

        private void deshabilitarTextBox()
        {
            textNombre.Enabled = false;
            textApellido.Enabled = false;
            textDni.Enabled = false;
            textDir.Enabled = false;
            textTel.Enabled = false;
            txtCodigo.Enabled = false;
            dtpFechaNac.Enabled = false;
            textMail.Enabled = false;

        }

        private void habilitarTextBox()
        {
            textNombre.Enabled = true;
            textApellido.Enabled = true;
            textDni.Enabled = true;
            textDir.Enabled = true;
            textTel.Enabled = true;
            dtpFechaNac.Enabled = true;
            textMail.Enabled = true;

        }

        private void limpiarTextBox()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textDni.Text = "";
            textDir.Text = "";
            textTel.Text = "";
            txtCodigo.Text = "";
            textMail.Text = "";

        }

        private void buscarUsuario()
        {
              this.dataListadoUsuarios.DataSource = DAOUsuario.buscarUsuario(this.txtBuscar.Text);
              this.OcultarColumnas();
           
        }

        private void OcultarColumnas()
        {
            this.dataListadoUsuarios.Columns[0].Visible = false;
            this.dataListadoUsuarios.Columns[1].Visible = true;
           
        }

        private void dataListadoUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoUsuarios.Columns["dataGridViewCheckBoxColumn1"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListadoUsuarios.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }



        private void dataListadoUsuarios_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dataListadoUsuarios.CurrentRow.Cells["CodigoPersona"].Value);
            this.textNombre.Text = Convert.ToString(this.dataListadoUsuarios.CurrentRow.Cells["Nombre"].Value);
            this.textApellido.Text = Convert.ToString(this.dataListadoUsuarios.CurrentRow.Cells["Apellido"].Value);
            this.textDni.Text = Convert.ToString(this.dataListadoUsuarios.CurrentRow.Cells["Dni"].Value);
            this.textDir.Text = Convert.ToString(this.dataListadoUsuarios.CurrentRow.Cells["Direccion"].Value);
            this.textTel.Text = Convert.ToString(this.dataListadoUsuarios.CurrentRow.Cells["Telefono"].Value);
            this.dtpFechaNac.Text = Convert.ToString(this.dataListadoUsuarios.CurrentRow.Cells["FechaNac"].Value);
            this.textMail.Text = Convert.ToString(this.dataListadoUsuarios.CurrentRow.Cells["Email"].Value);
        }

        private Persona cargarPersonaParaEditar()
        {

            return new Persona(Convert.ToInt32(txtCodigo.Text), textNombre.Text, textApellido.Text, Convert.ToInt32(textDni.Text), textDir.Text, Convert.ToInt32(textTel.Text), textMail.Text, dtpFechaNac.Value);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarUsuario();
        }

      

        private void botonBajaLogica_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea dar de baja definitiva al Usuario", "Sistema de Aerolineas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;

                    foreach (DataGridViewRow row in dataListadoUsuarios.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            DAOUsuario.darDeBajaUsuario(Codigo);


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

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DAOUsuario.EditarUsuario(cargarPersonaParaEditar());
                MessageBox.Show("El usuario se agregó correctamente.");
                deshabilitarTextBox();
                limpiarTextBox();
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error." + ex.Message);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;

            habilitarTextBox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            deshabilitarTextBox();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void checkBoxbajaLogica1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxbajaLogica1.Checked)
            {
                botonBajaLogica.Enabled = true;
                this.dataListadoUsuarios.Columns[0].Visible = true;
            }
            else
            {
                botonBajaLogica.Enabled = false;
                this.dataListadoUsuarios.Columns[0].Visible = false;
            }
        }
        */
    }
    
}
