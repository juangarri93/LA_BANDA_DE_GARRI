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

        string matricula  = "";
        string codigo_viaje = "";

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
            cbAeronave.DisplayMember = "Matricula";
            cbRutaAerea.DataSource = DAOViaje.getRutaAerea().DefaultView;
            cbRutaAerea.DisplayMember = "Codigo";
            

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
            codigo_viaje = cbRutaAerea.SelectedItem.ToString();
        }


        private Viaje CargarViaje()
        {
            return new Viaje(dtFechaSalida.Value, dtFechaLLegada.Value, dtFechaLLegadaEstimada.Value, Convert.ToString(cbAeronave.Text), Convert.ToDecimal(cbRutaAerea.Text), "Habilitado");
        }

        private void btnGenerarViaje_Click(object sender, EventArgs e)
        {
            // if (!ValidacionesAeronave()) return;
            try
            {
                int resultado= DAOViaje.AgregarViaje(CargarViaje());
                if (resultado  == 2)
                {
                    MessageBox.Show("El Viaje se generó correctamente.");
                    limpiar();
                }
                else if(resultado ==0)
                {
                    MessageBox.Show("EL SERVICIO DE LA RUTA AEREA NO COINCIDE CON EL DE LA AERONAVE");
                    limpiar();
                }
                else if(resultado == 1)
                {
                    MessageBox.Show("LA AERONAVE NO SE ENCUENTRA DISPONIBLE EN ESA FECHA");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Hubo un error.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);

            }
        }

        private void cbAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {
            matricula = cbAeronave.SelectedItem.ToString();
        }
 
    }
}
