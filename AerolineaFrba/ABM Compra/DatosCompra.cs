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
using AerolineaFrba.CapaADO;

using System.Text.RegularExpressions;

namespace AerolineaFrba.ABM_Compra
{
    public partial class DatosCompra : Form
    {
        DataTable usuarios;
        Compra compraActual;

        private List<Persona> UsuariosRegistrados;

        public DatosCompra(Compra compra)
        {
            this.compraActual = compra;
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

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (EsNumero(this.txtDni.Text))
            {
                usuarios=DAOUsuario.buscarUsuario(this.txtDni.Text);
                UsuariosRegistrados = this.crearListaDeUsuarios();

                if (UsuariosRegistrados.i != null)
                {
                  
                }

            }

        }


        private bool EsNumero(string cadena)
        {
            var regex = new Regex(@"^-*[0-9,\.]+$");
            return regex.IsMatch(cadena);
        }

        private List<Persona> crearListaDeUsuarios()
        {
            List<Persona> lista = new List<Persona>(usuarios.Rows.Count);

            foreach (DataRow row in usuarios.Rows)
            {
                //la talba premios viene asi: int id,string nombre, int stock, int costomillas
                var values = row.ItemArray;
                Persona persona = new Persona();
                persona.Id = (int)values[0];
                persona.Nombre = (string)values[1];
                persona.Apellido = (string)values[2];
                persona.Dni = (int)values[3];
                persona.Direccion = (string)values[4];
                persona.Telefono = (int)values[5];
                persona.Email = (string)values[6];
                persona.FechaNac = (DateTime)values[7];

                lista.Add(persona);
            }

            return lista;
        }
 

      
    }
}
