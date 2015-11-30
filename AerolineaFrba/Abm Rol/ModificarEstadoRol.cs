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
    public partial class ModificarEstadoRol : Form
    {

        public ModificarEstadoRol()
        {
            InitializeComponent();
        }

        private void ModificarEstadoRol_Load(object sender, EventArgs e)
        {

            this.dgRolesEstado.DataSource = DAORol.getRol();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                DAORol.EditarEstadoRol(cargarRol());
                MessageBox.Show("Rol Modificado correctamente.");
                this.dgRolesEstado.DataSource = DAORol.getRol();

          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

        private Rol cargarRol()
        {
            return new Rol(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToBoolean(textBox3.Text));
        }

        private void dgRolesEstado_DoubleClick(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Id"].Value);
            textBox2.Text = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Rol"].Value);
            textBox3.Text = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Habilitado"].Value);

        }
    }
}
