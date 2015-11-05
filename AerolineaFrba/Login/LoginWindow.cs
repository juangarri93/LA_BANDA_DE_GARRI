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

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = new Login();

            try
            {
                login.validateUser();
            }
            catch (Exception excep)
            {
                if (excep.Message.Equals("LOGIN_ERROR_PASSWORD"))
                {
  
                }

                if (excep.Message.Equals("LOGIN_ERROR"))
                {

                }
                if (excep.Message.Equals("LOGIN_MAS_TRES_VECES"))
                {

                }

                if (excep.Message.Equals("LOGIN_OFF"))
                {

                }

            }
        }
    }
}
