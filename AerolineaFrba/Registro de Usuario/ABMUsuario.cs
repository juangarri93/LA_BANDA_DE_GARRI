using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba;
 
using AerolineaFrba.Herramientas;


namespace AerolineaFrba.Registro_de_Usuario
{
    public partial class ABMUsuario : Form
    {
        public AerolineasPrincipal Aerolineas;

        public ABMUsuario(AerolineasPrincipal aerolineas)
        {
            InitializeComponent();
            Aerolineas = aerolineas;
        }

        private void ABMUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventanaAltaUsuarios = new RegistroUsuarios();
            FormsHerramientas.mostrarVentanaNueva(ventanaAltaUsuarios, this);
        }

      
        private void btnBaja_Click(object sender, EventArgs e)
        {

           // var ventanaBajaUsuarios = new ABMBajaModifUsuario();
           // FormsHerramientas.mostrarVentanaNueva(ventanaBajaUsuarios, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aerolineas.Focus();
        }
    }
}
