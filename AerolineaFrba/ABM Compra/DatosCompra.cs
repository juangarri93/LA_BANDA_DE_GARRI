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
        private DataTable usuarios;
        private  Compra compraActual;

        private List<Persona> UsuariosRegistrados;

        public DatosCompra(Compra compra)
        {
            compraActual = compra;
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

        private bool estaTodoLLeno()
        {
            if (txtDni.Text != "" &&
            txtApellido.Text != "" &&
            txtDireccion.Text != "" &&
            txtMail.Text != "" &&
            txtNombre.Text != "" &&
            txtTelefono.Text != "")
                return true;
            else return false;
        }

        private void completarCompra()
        {
            /*private int _idCompra;
        private string _nombre;se cargo ahora
        private string _apellido;se cargo ahora
        private int _dni;se cargo ahora
        private string _direccion;se cargo ahora
        private int _telefono;se cargo ahora
        private string _email;se cargo ahora
        private DateTime _fechaNac;se cargo ahora
        private DateTime _fechaDeViaje; se cargo antes
        private int _origen; se cargo antes
        private int _destino; se cargo antes
        private int _cantidadPasajes; se cargo antes
        private int _cantidadKG; se cargo antes
        private int _viajeSeleccionado; se cargo antes
        private string _estado; 
             * */

            compraActual.Apellido = txtApellido.Text;
            compraActual.Nombre = txtNombre.Text;
            compraActual.Dni = Convert.ToInt32(txtDni.Text);
            compraActual.Direccion = txtDireccion.Text;
            compraActual.Email = txtMail.Text;
            compraActual.Telefono = Convert.ToInt32(txtTelefono.Text);
            compraActual.FechaNac = dtFechaNac.Value;



        }
        private void btnButacas_Click(object sender, EventArgs e)
        {
            if (estaTodoLLeno())
            {
                completarCompra();
                var ventanaButacas = new Butacas(this.compraActual);
                FormsHerramientas.mostrarVentanaNueva(ventanaButacas, this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios");
                
            }
        }

        public Boolean IsEmpty (List<Persona> source)
        {
            if (source == null)
                return true;  
            return !source.Any();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (EsNumero(this.txtDni.Text))
            {
                usuarios=DAOUsuario.buscarUsuario(this.txtDni.Text);
                UsuariosRegistrados = this.crearListaDeUsuarios();

                if (!IsEmpty(UsuariosRegistrados))
                {
                    Autocompletar(UsuariosRegistrados.ElementAt(0));
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DAOCompra.AgregarCompra(compraActual);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
             
        }

      
 

      
    }
}
