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

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class GenerarViaje : Form
    {
        public GenerarViaje()
        {
            InitializeComponent();
          
        }

        private void GenerarViaje_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            limpiar();
            cargarComboBox();
           
        }

        private void deshabilitarTextBox()
        {
            dtFechaLLegada.Enabled = false;
            dtFechaLLegadaEstimada.Enabled = false;
            dtFechaSalida.Enabled = false;
            cbRutaAerea.Enabled = false;
        }

        private void limpiar() 
        {
            dtFechaLLegadaEstimada.Value = DateTime.Today;
            dtFechaLLegada.Value = DateTime.Today;
            dtFechaSalida.Value = DateTime.Today;
            cbAeronave.ValueMember = null;
            cbRutaAerea.ValueMember = null;
        
        }

        private void cargarComboBox()
        {
            cbAeronave.DataSource = DAOViaje.getAeronaves().DefaultView;
            cbAeronave.DisplayMember = "NumeroAeronave";
            cbRutaAerea.DataSource = DAOViaje.getRutaAerea().DefaultView;
            cbRutaAerea.DisplayMember = "id_Ruta";
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbRutaAerea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private Viaje CargarViaje()
        {
            return new Viaje(Convert.ToDateTime(dtFechaSalida.Value), Convert.ToDateTime(dtFechaLLegada.Value), Convert.ToDateTime(dtFechaLLegadaEstimada.Value), Convert.ToInt32(cbAeronave.SelectedText), Convert.ToInt32(cbRutaAerea.SelectedText), "Habilitado");
        }

        private void btnGenerarViaje_Click(object sender, EventArgs e)
        {
            // if (!ValidacionesAeronave()) return;
            try
            {
                DAOViaje.AgregarViaje(CargarViaje());
                MessageBox.Show("El Viaje se generó correctamente.");
                 limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);

            }
        }

        private void dtFechaLLegadaEstimada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFECHA_ValueChanged(object sender, EventArgs e)
        {

        }

     



    }
}
