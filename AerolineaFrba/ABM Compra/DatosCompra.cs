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
        private DataTable clientes;
        private  Compra compraActual;
        private Persona clienteActual;
        private bool existe=false;
        private List<Persona> ClientesRegistrados;

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
            existe = true;
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
                clientes = DAOCliente.buscarClientePorDni(Convert.ToInt32(this.txtDni.Text));
                ClientesRegistrados = this.crearListaDeUsuarios();

                if (!IsEmpty(ClientesRegistrados))
                {
                    clienteActual = ClientesRegistrados.ElementAt(0);
                    Autocompletar(clienteActual);
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
            List<Persona> lista = new List<Persona>(clientes.Rows.Count);

            foreach (DataRow row in clientes.Rows)
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
                DAOCliente.AgregarCliente(clienteActual);
                DAOCompra.AgregarCompra(compraActual);
                DAOPago.AgregarPago(CrearPago());
                MessageBox.Show("Felicitaciones has realizado tu compra");
                this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
             
        }


        private Pago CrearPago()
        {
            Pago pago = new Pago();
            decimal precioBasePasaje=0;
            decimal precioBaseKG=0;
            int id_usuario= 0;

                /*
            int _id;
            int _pnr;
            int _id_viaje;
            int _id_cliente;
            int _importe;
            DateTime _fecha_compra;
            char _tipo_pago;*/


            DataTable viaje = DAOViaje.getRutaAereaEspecifica(pago.Id_viaje);
            if(viaje!=null){

                DataRow rowviaje = viaje.Rows[0];
                int id_ruta = rowviaje.Field<int>("Codigo_Ruta_Aerea");
                DataTable ruta = DAORuta.MostrarRutaEspecifica(id_ruta);
                if (ruta != null)
                {
                    DataRow rowruta = ruta.Rows[0];
                    precioBasePasaje = rowruta.Field<decimal>("Precio_base_pasaje");
                    precioBaseKG = rowruta.Field<decimal>("Precio_base_kg");

                }
                
            }
          
            pago.Pnr = Convert.ToInt32(txtNum.Text);
            pago.Id_viaje = compraActual.ViajeSeleccionado;
            pago.Importe =(( precioBasePasaje * Convert.ToDecimal(compraActual.CantidadPasajes))+ (precioBaseKG * Convert.ToDecimal(compraActual.CantidadKG)));
           
            DataTable usuario = DAOCliente.buscarClientePorDni(compraActual.Dni);
            if (usuario != null)
            {
                DataRow rowsuario = usuario.Rows[0];
                id_usuario = rowsuario.Field<int>("Id");
                
            }

            pago.Id_cliente = id_usuario;
            pago.Fecha_compra = DateTime.Now;
            bool pagoT = rbTarjeta.Checked ? true : false;



            bool pagoEfe = rbEfectivo.Checked ? true : false;


            if (pagoT)
                pago.Tipo_pago = 'T';
            else if (pagoEfe)
                pago.Tipo_pago = 'E';


            return pago;
        }
 

      
    }
}
