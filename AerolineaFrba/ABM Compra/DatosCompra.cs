using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Registro_de_Usuario;
using AerolineaFrba.ConstructorDeClases;
using AerolineaFrba.Herramientas;

namespace AerolineaFrba.ABM_Compra
{
    public partial class DatosCompra : Form
    {
        public DatosCompra()
        {
            InitializeComponent();
        }

        public void BorrarTodo()
        {
            txtDni.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtMail.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            dtFechaNac.Value = DateTime.Now;
        }

        public void Autocompletar(Persona cliente)
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDni.Text = cliente.Dni.ToString();
            txtMail.Text = cliente.Email;
            txtDireccion.Text = cliente.Direccion;
            txtTelefono.Text = cliente.Telefono.ToString();
            dtFechaNac.Value = cliente.FechaNac;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.BorrarTodo();
            this.Hide();
        }

        private void btnButacas_Click(object sender, EventArgs e)
        {
            var ventanaButacas = new Butacas();
            FormsHerramientas.mostrarVentanaNueva(ventanaButacas, this);
            this.Hide();
        }

       
       

      
    }
}
