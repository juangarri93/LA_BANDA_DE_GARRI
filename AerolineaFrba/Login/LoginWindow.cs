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
                if (Validaciones())
                {
                    TxtBox_password.Text = "";
                    TxtBox_userName.Text = "";
                    return;
                }
                   
                Aerolineas.actualizaBotones(login.listaFuncionalidades);
                MessageBox.Show("El LOGIN HA SIDO CORRECTO, BIENVENIDO");
                this.Hide();
         
                
            }
            catch (Exception excep)
            {
               

            }
        }


        private bool Validaciones()
        {

            if (TxtBox_userName.Text == "")
            {
                MessageBox.Show("NO INGRESO EL NOMBRE DEL USUARIO");
                return true;

            }

            if (TxtBox_password.Text == "")
            {
                MessageBox.Show("NO INGRESO LA PASSWORD");
                return true;

            }

           
            if (login.auxCase == 2)
            {
                MessageBox.Show("LOS INTENTOS FALLIDOS SUPERAN EL LIMITE DE INTENTOS ESTABLECIDOS");
                return true;

            }

            if (login.auxCase == 1)
            {
                MessageBox.Show("EL USUARIO INGRESADO NO EXISTE EN LA BASE DE DATOS");
                return true;

            }

            if (login.auxCase == 3)
            {
                MessageBox.Show("LA CLAVE INGRESADA NO ES CORRECTA");
                return true;

            }



         

            

            return false;
        }


        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
