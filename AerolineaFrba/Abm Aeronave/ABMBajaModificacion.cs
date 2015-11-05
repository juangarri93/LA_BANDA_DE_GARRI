using System;
using System.Windows.Forms;

using AerolineaFrba.CapaADO;
using AerolineaFrba.ConstructorDeClases;

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
            txtNumeroAeronave.Enabled = false;
            cbFabricante.Enabled = false;
            cbModelo.Enabled = false;
            txtMatricula.Enabled = false;
            cbTipoDeServicio.Enabled = false;
            cmbBajaFueraDeServicio.Enabled = false;
            dtFechaFueraDeServicio.Enabled = false;
            dtFechaDeReinicio.Enabled = false;
            txtCantidadDeButacasVentana.Enabled = false;
            txtCantidadDeButacasPasillo.Enabled = false;
            txtCantidadDeKG.Enabled = false;
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
            string fechaAlta = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Fecha_alta"].Value);
            DateTime fechaActual = DateTime.Now;

            string numero = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Numero"].Value);
            string cantidad_butacas_pasillo = this.txtCantidadDeButacasPasillo.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Cantidad_Ventanas_Pasillo"].Value);
            string cantidad_butacas_ventana = this.txtCantidadDeButacasVentana.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Cantidad_Butacas_Ventana"].Value);


            this.txtCodigo.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Id"].Value);

            if (fechaAlta == "")
            {
                this.dtpFechaAlta.Value = fechaActual;
            }
            else 
            {
                this.dtpFechaAlta.Value = Convert.ToDateTime(this.dataListadoAeronaves.CurrentRow.Cells["Fecha_alta"].Value);
            }

            if (numero == "")
            {
                this.txtNumeroAeronave.Text = "";
            }
            else 
            {
                this.txtNumeroAeronave.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Numero"].Value);
            }
              
         //   this.txtModelo.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Modelo"].Value);
            this.txtMatricula.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Matricula"].Value);
         //   this.txtFabricante.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Fabricante"].Value);
         //   this.txtTipoDeServicio.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Tipo_Servicio"].Value);

            if (cantidad_butacas_ventana == "")
            {
                this.txtCantidadDeButacasVentana.Text = "";
            }
            else 
            {
                this.txtCantidadDeButacasVentana.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Cantidad_Butacas_Ventana"].Value);
            }

            if (cantidad_butacas_pasillo == "")
            {
                this.txtCantidadDeButacasPasillo.Text = "";
            }
            else 
            {
                this.txtCantidadDeButacasPasillo.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Cantidad_Ventanas_Pasillo"].Value);  
            }

            //this.cmbBajaFueraDeServicio.ValueMember = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Baja_Fuera_Servicio"].Value);

            string fechaFueraServicio = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Fecha_Fuera_Servicio"].Value);
            if (fechaFueraServicio == "")
            {
                this.dtFechaFueraDeServicio.Value = fechaActual;
            }
            else 
            {
                this.dtFechaFueraDeServicio.Value = Convert.ToDateTime(this.dataListadoAeronaves.CurrentRow.Cells["Fecha_Fuera_Servicio"].Value);  
            }

            string fechaDeReinicio = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Fecha_Fuera_Servicio"].Value);
            if (fechaDeReinicio == "")
            {
                this.dtFechaDeReinicio.Value = fechaActual;
            }
            else
            {
                this.dtFechaDeReinicio.Value = Convert.ToDateTime(this.dataListadoAeronaves.CurrentRow.Cells["Fecha_Reinicio"].Value);
            }
          
            string cantidadKG =  Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Kg_Disponibles"].Value);
            if (cantidadKG == "")
            {
                this.txtCantidadDeKG.Text = "";
            }
            else 
            {
                this.txtCantidadDeKG.Text = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Kg_Disponibles"].Value); 
            }
           
            this.tabControl1.SelectedIndex = 1;

            btnEditar.Enabled = true;
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
                 btnGuardar.Enabled = false;
                 btnEditar.Enabled = true;
                 btnCancelar.Enabled = false;

            }
            catch(Exception ex)
            {

                MessageBox.Show("Hubo un error." + ex.Message); 
            
            }



        }

        private Aeronave cargarAerolineParaEditar()
        {

            return new Aeronave(Convert.ToInt32(txtCodigo.Text), 
                                dtpFechaAlta.Value,
                                Convert.ToInt32(txtNumeroAeronave.Text),
                                cbModelo.SelectedIndex + 1,
                                txtMatricula.Text,
                                cbFabricante.SelectedIndex + 1,
                                cbTipoDeServicio.SelectedIndex + 1,
                                cmbBajaFueraDeServicio.Text,
                                dtFechaFueraDeServicio.Value,
                                dtFechaDeReinicio.Value,
                                Convert.ToInt32(txtCantidadDeButacasVentana.Text),
                                Convert.ToInt32(txtCantidadDeButacasPasillo.Text),
                                Convert.ToInt32(txtCantidadDeKG.Text));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;

            habilitarTextBox();
        }

        private void habilitarTextBox()
        {
            dtpFechaAlta.Enabled = true;
            txtNumeroAeronave.ReadOnly = false;
            cbModelo.Enabled = true;
            txtMatricula.ReadOnly = false;
            cbFabricante.Enabled = true;
            cbTipoDeServicio.Enabled = true;
            cmbBajaFueraDeServicio.Enabled = true;
            dtFechaFueraDeServicio.Enabled = true;
            dtFechaDeReinicio.Enabled = true;
            txtCantidadDeButacasPasillo.ReadOnly = false;
            txtCantidadDeButacasVentana.ReadOnly = false;
            txtCantidadDeKG.ReadOnly = false;
            txtCantidadDeButacasVentana.Enabled = true;
            txtNumeroAeronave.Enabled = true;
            txtMatricula.Enabled = true;
            txtCantidadDeButacasPasillo.Enabled = true;
            txtCantidadDeKG.Enabled = true;

        }

 
        private void ABMBajaModificacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
            btnBajaLogica.Enabled = false;
            cmbBajaFueraDeServicio.Items.Add("Habilitado");
            cmbBajaFueraDeServicio.Items.Add("Deshabilitado");
            cargarComboBox();
            btnCancelar.Enabled = false;
            txtCodigo.ReadOnly = true;
            btnGuardar.Enabled = false;
            deshabilitarTextBox(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
            deshabilitarTextBox();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void limpiarTextBox()
        {
            txtCodigo.Text = "";
            dtpFechaAlta.Enabled = false;
            txtNumeroAeronave.Text = "";
            txtMatricula.Text = "";
            dtFechaFueraDeServicio.Enabled = false;
            dtFechaDeReinicio.Enabled = false;
            txtCantidadDeButacasVentana.Text = "";
            txtCantidadDeButacasPasillo.Text= "";
            txtCantidadDeKG.Text = "";
        }

        private void btnBajaLogica_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea dar de baja definitiva la aeronave", "Sistema de Aerolinea", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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

       
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroAeronave_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTipoDeServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoDeServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarComboBox()
        {
            cbFabricante.DataSource = DAOAerolinea.getFabricante().DefaultView;
            cbFabricante.DisplayMember = "Nombre";

            cbModelo.DataSource = DAOAerolinea.getModelo().DefaultView;
            cbModelo.DisplayMember = "Nombre";

            cbTipoDeServicio.DataSource = DAOAerolinea.getTipoServicio().DefaultView;
            cbTipoDeServicio.DisplayMember = "Tipo_Servicio";

        }

        
    } 
}
