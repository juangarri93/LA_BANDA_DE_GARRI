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
        bool a = false;
        bool b = false;
        bool c = false;
     

        private List<Premio> PremiosDisponibles;


        public CanjeMillas()
        {
            InitializeComponent();
            llenarComboBoxPremios();
          
             this.btnAceptar.Enabled = false;
           
            
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

            cantPremios.Items.Add(1);
            cantPremios.Items.Add(2);
            cantPremios.Items.Add(3);
            cantPremios.Items.Add(4);
            cantPremios.Items.Add(5);
            cantPremios.Items.Add(6);
            cantPremios.Items.Add(7);
            cantPremios.Items.Add(8);
            cantPremios.Items.Add(9);
            cantPremios.Items.Add(10);
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

            Premio premio = (Premio)cbPremios.SelectedItem;
            if (!EsNumero(txtDni.Text))
            {
                MessageBox.Show("Debe Ingresar un valor numerico");
                return;
            }
            
            int dni = Convert.ToInt32(txtDni.Text);
            int millas = DAOMillas.Calcular_Millas(dni);

            int millas_necesarias = premio.Cantidad_millas * (Convert.ToInt32(cantPremios.Text));

            if (millas < millas_necesarias)
            {
                MessageBox.Show("No tiene suficientes millas");
                return;
            }
          
            
            if(DAOPremio.restarCantidadPremios(premio.Id, millas_necesarias)>0 )
            {
                
                try
                {
                   
                    MessageBox.Show("Canje realizado con exito");
                    DAOMillas.restarMillas(dni, millas - millas_necesarias);

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
            a = true;
            
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDni.Text == "")
            {
                b = false;
            }
            else
            {
                b = true;

            }
        }

        private void cbCantidad_ValueChanged(object sender, EventArgs e)
        {
            c = true;

        }

        private void date_canje_ValueChanged(object sender, EventArgs e)
        {


            if (a = b = c = true)
            {
                this.btnAceptar.Enabled = true;
            }
            
        }

        
      
    }
}
