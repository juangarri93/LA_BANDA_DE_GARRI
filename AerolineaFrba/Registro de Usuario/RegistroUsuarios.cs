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

namespace AerolineaFrba.Registro_de_Usuario
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


              //  DAOUsuario.AgregarUsuario(CargarUsuario());
                MessageBox.Show("El Usuario se agregó correctamente.");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            limpiar();
        }


        private void textTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private Persona CargarUsuario()
        {
             
            return new Persona(1, textNombre.Text, textApellido.Text, Convert.ToInt32(textDNI.Text), textDir.Text, Convert.ToInt32(textTel.Text), textMail.Text, dtpFechaNac.Value,cbPerfil.Text);

        }

        private void limpiar()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textDNI.Text = "";
            textDir.Text = "";
            textMail.Text = "";
            textTel.Text = "";


        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            cbPerfil.DataSource = DAOUsuario.getPerfilRol().DefaultView;
            cbPerfil.DisplayMember = "Rol";
        }

        
        
    }
}
