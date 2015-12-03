using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Login
{
    public partial class LoginWindow : Form
    {
        Login login;

        private AerolineasPrincipal Aerolineas;

        public LoginWindow(AerolineasPrincipal aerolineas)
        {
            InitializeComponent();
            Aerolineas = aerolineas;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = new Login();
            login.UserName = TxtBox_userName.Text;
            login.Password = TxtBox_password.Text;

            try
            {
                login.validateUser();
                Aerolineas.actualizaBotones(login.listaFuncionalidades);
                MessageBox.Show("El LOGIN HA SIDO CORRECTO, BIENVENIDO");
                this.Hide();
         
                
            }
            catch (Exception excep)
            {
                //if (excep.Message.Equals("LOGIN_ERROR_PASSWORD"))
                //{
                //    MessageBox.Show("Error al loguearse. Verifique su usuario y contraseña");
                //    return;
                //}

                //if (excep.Message.Equals("LOGIN_ERROR"))
                //{
                //    MessageBox.Show("Error de login");
                //    return;
                //}
                //if (excep.Message.Equals("LOGIN_MAS_TRES_VECES"))
                //{
                //    MessageBox.Show("Se superó la cantidad de intentos para loguearse.\nEl usuario queda inhabilitado.");
                //    return;
                //}

                //if (excep.Message.Equals("LOGIN_OFF"))
                //{
                //    MessageBox.Show("Usuario inhabilitado.");
                //    return;
                //}

            }
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
