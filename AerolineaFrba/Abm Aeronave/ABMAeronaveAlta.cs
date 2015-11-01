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
    public partial class ABMAeronaveAlta : Form
    {
        
        public ABMAeronaveAlta()
        {
            InitializeComponent();
        }

        private void ABMAeronaveAlta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cargarComboBox();

        }

        private void cargarComboBox()
        {
            cbFabricante.DataSource = DAOAerolinea.getFabricante().DefaultView;
            cbFabricante.DisplayMember = "Nombre";
                
            cbModelo.DataSource = DAOAerolinea.getModelo().DefaultView;
            cbModelo.DisplayMember = "Nombre";
            
            cbTipoServicio.DataSource = DAOAerolinea.getTipoServicio().DefaultView;
            cbTipoServicio.DisplayMember = "Tipo_Servicio";
         
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            // if (!ValidacionesAeronave()) return;
            try
            {
                DAOAerolinea.AgregarAeronave(CargarAerolinea());
                MessageBox.Show("La Aeronave se agrego correctamente.");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);               
            }
        }

        


        private bool ValidacionesAeronave()
        {
            
            return false;
        }

        private Aeronave CargarAerolinea() 
        {

            return new Aeronave(1,dtpFechaAlta.Value, Convert.ToInt32(txtNumeroAeronave.Text),
                                        Convert.ToInt32(cbModelo.ValueMember),txtMatricula.Text, Convert.ToInt32(cbFabricante.ValueMember), Convert.ToInt32(cbTipoServicio.ValueMember),
                                        "Habilitado", dtpFechaAlta.Value, dtpFechaAlta.Value,Convert.ToInt32(txtCantidadDeButacasPasillo.Text), Convert.ToInt32(txtCantidadButacasVentana.Text),Convert.ToInt32(txtCantidadDeKG.Text));
                                 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            limpiar();
         
        }

        private void limpiar() 
        {
            txtNumeroAeronave.Text = "";
            txtMatricula.Text = ""; 
            txtCantidadDeButacasPasillo.Text = "";
            txtCantidadButacasVentana.Text = "";
        
        
        }

       
    }
}
