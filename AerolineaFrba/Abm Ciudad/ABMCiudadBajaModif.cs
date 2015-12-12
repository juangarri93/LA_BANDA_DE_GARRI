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
        ABMCiudad ciudad;
        
        private bool IsFiltroNombreCiudad = false; 

        public ABMCiudadBajaModif(ABMCiudad Ciudad)
        {
            InitializeComponent();
            ciudad = Ciudad;
        }

        private void deshabilitarTextBox()
        {
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
                if (Validaciones()) return;
                DAOCiudad.EditarCiudad(cargarCiudadParaEditar());
                MessageBox.Show("La Ciudad se agrego correctamente.");
                deshabilitarTextBox();
                limpiarTextBox();
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                Mostrar();

            }
            catch(Exception ex)
            {

                MessageBox.Show("Hubo un error." + ex.Message); 
            
            }
        }


         private bool Validaciones()
         {


             if (txtCodigo.Text == "")
             {
                 MessageBox.Show("NO INGRESO CIUDAD PARA MODIFICAR, POR FAVOR SIGA LAS INSTRUCCIONES DEL MENU DE AYUDA, MUCHAS GRACIAS");
                 return true;

             }


             if (txtNomb.Text == "")
             {
                 MessageBox.Show("NO INGRESO NOMBRE DE CIUDAD");
                 return true;

             }
            

             return false;

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
                    int Codigo = 0;
                    bool habilitado = false;

                    foreach (DataGridViewRow row in dataListadoCiudades.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);

                            habilitado = Convert.ToBoolean(row.Cells[3].Value);

                            if (habilitado == true)
                            {
                                habilitado = false;
                            }
                            else 
                            {
                                habilitado = true;
                            }
                        
                            DAOCiudad.darDeBajaCiudad(Codigo, habilitado);


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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si se desea Habilitar/Deshabilitar una ciudad siga los siguientes pasos:" + Environment.NewLine +
                                 "  ● Hacer clic en el checkbox 'Habilitar-Deshabilitar'" + Environment.NewLine +
                                 "  ● Habilite/Deshabilite las ciudades a su gusto" + Environment.NewLine +
                                 "  ● Finalmente hacer clic en el boton 'Habilitar-Deshabilitar'" + Environment.NewLine + Environment.NewLine +
                            "Si se desea Editar una Ciudad:" + Environment.NewLine +
                          
                            "● Buscar la ciudad" + Environment.NewLine +
                            "● Hacer doble clic sobre la misma" + Environment.NewLine +
                            "● Hacer clic sobre el boton Editar" + Environment.NewLine +
                            "● Edite a su gusto y guarde");

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ciudad.Focus();
            this.Hide();
        }

  

    }
}
