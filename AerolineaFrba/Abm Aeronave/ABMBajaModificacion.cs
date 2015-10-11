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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
            this.cmbBajaPorVidaUtil.ValueMember = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["BajaPorVidaUtil"].Value);
            this.dtFechaFueraDeServicio.Value = Convert.ToDateTime(this.dataListadoAeronaves.CurrentRow.Cells["FechaDeFueraDeServicio"].Value);
            this.dtFechaDeReinicio.Value = Convert.ToDateTime(this.dataListadoAeronaves.CurrentRow.Cells["FechaDeReinicioDeServicio"].Value);
            this.dtFechaBajaDefinitiva.Value = Convert.ToDateTime(this.dataListadoAeronaves.CurrentRow.Cells["FechaDeBajaDefinitiva"].Value);
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
                //limpiar();

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
                                       txtMatricula.Text, txtMatricula.Text, dtFechaFueraDeServicio.Value, dtFechaDeReinicio.Value, dtFechaBajaDefinitiva.Value, Convert.ToInt32(txtCantidadDeButacas.Text), Convert.ToInt32(txtCantidadDeKG.Text));              
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "ABM de Aeronaves", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(Opcion == DialogResult.OK)
                {
                    string Codigo;
                    
                    foreach (DataGridViewRow row in dataListadoAeronaves.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            DAOAerolinea.EliminarAeronave(Convert.ToInt32(Codigo));
                        
                        }

                        Mostrar();
                        this.dataListadoAeronaves.Columns[0].Visible = true;
                        


                    
                    }

                
                }
            }

            catch 
            {
            
            }


        }

        private void ABMBajaModificacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
            cmbBajaFueraDeServicio.Items.Add("Habilitado");
            cmbBajaFueraDeServicio.Items.Add("Deshabilitado");
            cmbBajaPorVidaUtil.Items.Add("Deshabilitado");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
