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
           
            return false;
        }


        private Rol cargarRol()
        {
            return new Rol(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToBoolean(textBox3.Text));
        }

        private void dgRolesEstado_DoubleClick(object sender, EventArgs e)
        {

            dgRolesEstado.ReadOnly = false;

            textBox1.Text = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Id"].Value);
            textBox2.Text = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Rol"].Value);
            textBox3.Text = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Habilitado"].Value);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para modificar el estado de un rol siga los siguientes pasos:" + Environment.NewLine +
                                  "  ● Hacer Doble click en el Rol a editar para mostrarlo en los textbox de la derecha (ACLARACION: la funcionalidad de los textbox es solo informativo)" + Environment.NewLine +
                                  "  ● Hacer click en la casilla de 'Habilitado' del Rol a editar" + Environment.NewLine +
                                  "  ● Finalmente Aceptar");
        }
    }
}
