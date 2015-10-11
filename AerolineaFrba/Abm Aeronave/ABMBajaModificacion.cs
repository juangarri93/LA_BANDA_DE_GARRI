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

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class ABMBajaModificacion : Form
    {

        private bool IsFiltroNumeroAeronave = false;
        private bool IsFiltroModelo = false;
        private bool IsFiltroFabricante = false;
  
        public ABMBajaModificacion()
        {      
            InitializeComponent();
           
        }

        private void deshabilitarTextBox()
        {
            dtpFechaAlta.Enabled = false;
            txtNumeroAeronave.ReadOnly = true;
            txtModelo.ReadOnly = true;
            txtMatricula.ReadOnly = true;
            txtFabricante.ReadOnly = true;
            txtTipoDeServicio.ReadOnly = true;
            cmbBajaFueraDeServicio.Enabled = false;
            dtFechaFueraDeServicio.Enabled = false;
            dtFechaDeReinicio.Enabled = false;
            txtCantidadDeButacas.ReadOnly = true;
            txtCantidadDeKG.ReadOnly = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void dataListadoAeronaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoAeronaves.Columns["dataGridViewCheckBoxColumn1"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListadoAeronaves.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListadoAeronaves.DataSource = DAOAerolinea.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoAeronaves.Rows.Count);
        }

        //Metodo para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListadoAeronaves.Columns[0].Visible = false;
            //this.dataListadoAeronaves.Columns[1].Visible = false;
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoAeronaves.Rows.Count);

        }

        private void dataListadoAeronaves_DoubleClick(object sender, EventArgs e)
        {



            this.txtCodigo.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["CodigoAeronave"].Value);
            this.dtpFechaAlta.Value = Convert.ToDateTime(this.dataListadoAeronaves.CurrentRow.Cells["FechaAlta"].Value);
            this.txtNumeroAeronave.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["NumeroAeronave"].Value);
            this.txtModelo.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Modelo"].Value);
            this.txtMatricula.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Matricula"].Value);
            this.txtFabricante.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Fabricante"].Value);
            this.txtTipoDeServicio.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["TipoDeServicio"].Value);
            this.cmbBajaFueraDeServicio.ValueMember = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["BajaPorFueraDeServicio"].Value);
            this.dtFechaFueraDeServicio.Value = Convert.ToDateTime(this.dataListadoAeronaves.CurrentRow.Cells["FechaDeFueraDeServicio"].Value);
            this.dtFechaDeReinicio.Value = Convert.ToDateTime(this.dataListadoAeronaves.CurrentRow.Cells["FechaDeReinicioDeServicio"].Value);
            this.txtCantidadDeButacas.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["CantidadButacas"].Value);
            this.txtCantidadDeKG.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["KgDisponible"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            this.buscarNumeroAeronave();
            this.buscarFabricante();
            this.buscarModelo();
        }

        private void buscarModelo()
        {
            if (IsFiltroModelo)
            {
                this.dataListadoAeronaves.DataSource = DAOAerolinea.buscarModelo(this.txtBuscar.Text);
                this.OcultarColumnas();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoAeronaves.Rows.Count);
            }  
        }

        private void buscarFabricante()
        {
            if (IsFiltroFabricante)
            {
                this.dataListadoAeronaves.DataSource = DAOAerolinea.buscarFabricante(this.txtBuscar.Text);
                this.OcultarColumnas();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoAeronaves.Rows.Count);
            }  
        }

        private void buscarNumeroAeronave()
        {
            if(IsFiltroNumeroAeronave){
            this.dataListadoAeronaves.DataSource = DAOAerolinea.buscarNumeroAeronave(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListadoAeronaves.Rows.Count);
            }   
        }

        private void FiltroNumero_Click(object sender, EventArgs e)
        {
            IsFiltroNumeroAeronave = true;
            IsFiltroModelo = false;
            IsFiltroFabricante = false;
        }

        private void btnFiltroModelo_Click(object sender, EventArgs e)
        {
            IsFiltroNumeroAeronave = false;
            IsFiltroModelo = true;
            IsFiltroFabricante = false;
        }

        private void btnFabricante_Click(object sender, EventArgs e)
        {
            IsFiltroNumeroAeronave = false;
            IsFiltroModelo = false;
            IsFiltroFabricante = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                DAOAerolinea.EditarAeronave(cargarAerolineParaEditar());
                MessageBox.Show("La Aeronave se agrego correctamente.");
                deshabilitarTextBox();
                limpiarTextBox();

            }
            catch(Exception ex)
            {

                MessageBox.Show("Hubo un error." + ex.Message); 
            
            }



        }

        private Aeronave cargarAerolineParaEditar()
        {

            return new Aeronave(Convert.ToInt32(txtCodigo.Text),dtpFechaAlta.Value, Convert.ToInt32(txtNumeroAeronave.Text),
                                       txtModelo.Text, txtMatricula.Text, txtFabricante.Text, txtTipoDeServicio.Text,
                                       cmbBajaFueraDeServicio.ValueMember,dtFechaFueraDeServicio.Value,dtFechaDeReinicio.Value,Convert.ToInt32(txtCantidadDeButacas.Text), Convert.ToInt32(txtCantidadDeKG.Text));              
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnCancelar.Enabled = true;
            habilitarTextBox();
        }

        private void habilitarTextBox()
        {
            dtpFechaAlta.Enabled = true;
            txtNumeroAeronave.ReadOnly = false;
            txtModelo.ReadOnly = false;
            txtMatricula.ReadOnly = false;
            txtFabricante.ReadOnly = false;
            txtTipoDeServicio.ReadOnly = false;
            cmbBajaFueraDeServicio.Enabled = true;
            dtFechaFueraDeServicio.Enabled = true;
            dtFechaDeReinicio.Enabled = true;
            txtCantidadDeButacas.ReadOnly = false;
            txtCantidadDeKG.ReadOnly = false;
        }

 
        private void ABMBajaModificacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
            btnBajaLogica.Enabled = false;
            cmbBajaFueraDeServicio.Items.Add("");
            cmbBajaFueraDeServicio.Items.Add("Habilitado");
            cmbBajaFueraDeServicio.Items.Add("Deshabilitado");
            btnCancelar.Enabled = false;
            btnCancelar.Enabled = false;
            txtCodigo.ReadOnly = true;
            deshabilitarTextBox(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            deshabilitarTextBox();
        }

        private void limpiarTextBox()
        {
            txtCodigo.Text = "";
            dtpFechaAlta.Enabled = false;
            txtNumeroAeronave.Text = "";
            txtModelo.Text = "";
            txtMatricula.Text = "";
            txtFabricante.Text = "";
            txtTipoDeServicio.Text = "";
            cmbBajaFueraDeServicio.Items.Clear();

            dtFechaFueraDeServicio.Enabled = false;
            dtFechaDeReinicio.Enabled = false;
            txtCantidadDeButacas.Text= "";
            txtCantidadDeKG.Text = "";
        }

        private void btnBajaLogica_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea dar de baja definitiva la aeronave", "Sistema de Aerolineas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                                        
                    foreach (DataGridViewRow row in dataListadoAeronaves.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            DAOAerolinea.darDeBajaAerolinea(Codigo);
                           
                           
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
        
        private void bajaLogica1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxbajaLogica1.Checked)
            {
                btnBajaLogica.Enabled = true;
                this.dataListadoAeronaves.Columns[0].Visible = true;
            }
            else
            {
                btnBajaLogica.Enabled = false;
                this.dataListadoAeronaves.Columns[0].Visible = false;
            }
        }

        
    } 
}
