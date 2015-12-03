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
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace AerolineaFrba.Canje_Millas
{
    public partial class CanjeMillas : Form
    {


        private List<Premio> PremiosDisponibles;


        public CanjeMillas()
        {
            InitializeComponent();
          //  llenarComboBoxPremios();
           
        }


        public void llenarComboBoxPremios()
        {
            cbPremios.Items.Clear();
            PremiosDisponibles = crearListaDePremios();

            foreach (Premio premio in PremiosDisponibles)
            {
                cbPremios.Items.Add(premio);
            }

            cbPremios.DisplayMember = "Nombre";
       
           
        }


        private List<Premio> crearListaDePremios()
        {
            DataTable premios = DAOPremio.MostrarTodos();
            List<Premio> lista = new List<Premio>(premios.Rows.Count);

            foreach (DataRow row in premios.Rows)
            {
                //la talba premios viene asi: int id,string nombre, int stock, int costomillas
                var values = row.ItemArray;
                Premio Premio = new Premio();
                Premio.Id = (int)values[0];
                Premio.Nombre = (string)values[1];
                Premio.Cantidad = (int)values[2];
                Premio.Cantidad_millas = (int)values[3];
                lista.Add(Premio);
            }

            return lista;
        }
 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool EsNumero(string cadena)
        {
            var regex = new Regex(@"^-*[0-9,\.]+$");
            return regex.IsMatch(cadena);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Premio premio = PremiosDisponibles.ElementAt(Convert.ToInt32(cbPremios.SelectedIndex));

            if (!EsNumero(txtDni.Text))
            {
                MessageBox.Show("Debe Ingresar un valor numerico");
                return;
            }
            
            int dni = Convert.ToInt32(txtDni.Text);
            int millas = DAOMillas.Calcular_Millas(dni);
            int millas_necesarias = millas * (Convert.ToInt32(cbCantidad.Text));

            if (millas < millas_necesarias)
            {
                MessageBox.Show("No tiene suficientes millas");
                return;
            }
          
            
            if(DAOPremio.restarCantidadPremios(premio.Id, millas_necesarias)>0 )
            {
                // if (!ValidacionesAeronave()) return;
                try
                {
                    DAOPremio.InsertarCanje(premio);
                    MessageBox.Show("Canje realizado con exito");
                    DAOMillas.restarMillas(dni, millas_necesarias);

                    // limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error." + ex.Message);

                }
               
            }
        }

        private void cbPremios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Premio premioseleccionado = PremiosDisponibles.ElementAt(Convert.ToInt32(cbPremios.SelectedIndex));

            this.cbCantidad.Value = premioseleccionado.Cantidad;
            
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_canje_ValueChanged(object sender, EventArgs e)
        {

        }

        
      
    }
}
