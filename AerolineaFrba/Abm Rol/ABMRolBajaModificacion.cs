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

namespace AerolineaFrba.Abm_Rol
{
    public partial class ABMRolBajaModificacion : Form
    {

        public ABMRolBajaModificacion()
        {
            InitializeComponent();
            cbNombre.DataSource = DAORol.getRol().DefaultView;
            cbNombre.DisplayMember = "Rol";
        }

        private void dataListadoAeronaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String nombreAnt = Convert.ToString(cbNombre.Text);

                DAORol.EditarNombreRol(nombreAnt, txtNuevoRol.Text);
                MessageBox.Show("Rol Modificado correctamente.");

                cbNombre.DataSource = DAORol.getRol().DefaultView;
                cbNombre.DisplayMember = "Rol";

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hubo un error." + ex.Message);     
            }
        }

        private void ABMRolBajaModificacion_Load(object sender, EventArgs e)
        {
          
          
          
        }

        private void EditarFuncionalidad_Click(object sender, EventArgs e)
        {


            var ventanaBajaModificacionRol = new ModificarFuncionalidadParaUnRol(cbNombre.Text);
            FormsHerramientas.mostrarVentanaNueva(ventanaBajaModificacionRol, this);
                
        }
    }
}
