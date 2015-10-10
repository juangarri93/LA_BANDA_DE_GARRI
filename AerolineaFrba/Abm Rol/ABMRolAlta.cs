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

namespace AerolineaFrba.Abm_Rol
{
    public partial class ABMRolAlta : Form
    {
        public ABMRolAlta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DAORol.AgregarRol(GenerarRol());
                MessageBox.Show("Rol agregado correctamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);        
            }


        }

        private Rol GenerarRol()
        {
            var lista = Funcionalidades.CheckedIndices.Cast<int>().ToList();
            return new Rol(txtNombre.Text,lista);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
