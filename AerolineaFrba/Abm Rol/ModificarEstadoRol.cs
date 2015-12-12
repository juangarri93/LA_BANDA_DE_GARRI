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
            cbHabilitado.Items.Add("false");
            cbHabilitado.Items.Add("true");
            //textBox3.ReadOnly = true;
            dgRolesEstado.ReadOnly = true;

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones()) return;
                DAORol.EditarEstadoRol(cargarRol());
                MessageBox.Show("Rol Modificado correctamente.");
                this.dgRolesEstado.DataSource = DAORol.getRol();

          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

        private bool Validaciones()
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("NO INGRESO INFORMACION PARA EDITAR, POR FAVOR SIGA LAS INSTRUCCIONES DEL MENU DE AYUDA,MUCHAS GRACIAS");
                return true;

            }

            if (cbHabilitado.Text == "")
            {
                MessageBox.Show("ELIJA UNA OPCION PARA EL HABILITADO");
                return true;

            }
           
            return false;
        }


        private Rol cargarRol()
        {
            return new Rol(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToBoolean(cbHabilitado.Text));
        }

        private void dgRolesEstado_DoubleClick(object sender, EventArgs e)
        {

            //dgRolesEstado.ReadOnly = false;

            textBox1.Text = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Id"].Value);
            textBox2.Text = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Rol"].Value);
            cbHabilitado.SelectedItem = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Habilitado"].Value);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para modificar el estado de un rol siga los siguientes pasos:" + Environment.NewLine +
                                  "  ● Hacer Doble click en el Rol a editar para mostrarlo en los textbox de la derecha" + Environment.NewLine +
                                  "  ● Elegir del combobox la opcion deseada" + Environment.NewLine +
                                  "  ● Finalmente Aceptar");
        }
    }
}
