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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ABMCiudadAlta : Form
    {
        public ABMCiudadAlta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
         

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            
            try
            {

              
                DAOCiudad.AgregarCiudad(CargarCiudad());
                MessageBox.Show("La Ciudad se agregó correctamente.");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

       
        
        private Ciudad CargarCiudad() 
        {

            return new Ciudad(1, textNombre.Text);
                                 
        }

        private void limpiar()
        {
          
            textNombre.Text = "";

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

       
    }


      
}
