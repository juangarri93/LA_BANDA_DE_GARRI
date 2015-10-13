using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using AerolineaFrba.CapaADO;

namespace AerolineaFrba.Abm_Rol
{
    public partial class ABMRolBajaModificacion : Form
    {
        public ABMRolBajaModificacion()
        {
            InitializeComponent();
        }

        private void dataListadoAeronaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //DAORol.EditarModificarRol(generarRol());
                MessageBox.Show("Rol agregado correctamente.");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hubo un error." + ex.Message);     
            }
        }
    }
}
