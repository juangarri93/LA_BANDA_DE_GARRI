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
        private bool existe;
        private List<Persona> ClientesRegistrados;

        public DatosCompra(Compra compra)
        {
            clientes = DAOCliente.buscarClientes();

            if (clientes != null)
            {
                ClientesRegistrados = this.crearListaDeUsuarios();
            }
 
            compraActual = compra;
 

            InitializeComponent();
            cmbTipo.Items.Add("T");
            cmbTipo.Items.Add("E");
            cmbCuotas.Items.Add(1);
            cmbCuotas.Items.Add(3);
            cmbCuotas.Items.Add(6);
            cmbCuotas.Items.Add(9);
            cmbCuotas.Items.Add(12);
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
            if ( !EsNumero(txtDni.Text))
            {
                
                MessageBox.Show("El Dni debe incluir solo números");
                return false;
            }

            if (txtApellido.Text == "" && EsNumero(txtApellido.Text))
            {
                
                MessageBox.Show("Apellido incorrecto");
                return false;
            }

            if (txtDireccion.Text == "")
            {
                
                MessageBox.Show("Direcion incorrecta");
                return false;
            }

           

            if (txtNombre.Text == "" && EsNumero(txtApellido.Text))
            {
                
                MessageBox.Show("Nombre incorrecto");
                return false;
            }

            if (!EsNumero(txtTelefono.Text))
            {
                
                MessageBox.Show("Telefono incorrecto");
                return false;
            }

            if (rbTarjeta.Checked == true && txtNum.Text == "" && !EsNumero(txtNum.Text))
            {

                MessageBox.Show("Numero de tarjeta incorrecto");
                return false;
            }

            if (rbTarjeta.Checked == true && txtVenc.Text == "" && !EsNumero(txtVenc.Text))
            {

                MessageBox.Show("Fecha de vencimiento de Tarjeta incorrecta");
                return false;
            }

           

            return true;
        }


        private void btnButacas_Click(object sender, EventArgs e)
        {
          
        }

        public Boolean IsEmpty (List<Persona> source)
        {
            if (source == null)
                return true;  
            return !source.Any();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            

        }


        private bool EsNumero(string cadena)
        {
            var regex = new Regex(@"^-*[0-9,\.]+$");
            return regex.IsMatch(cadena);
        }

        private List<Persona> crearListaDeUsuarios()
        {
            List<Persona> lista = new List<Persona>();

            foreach (DataRow row in clientes.Rows)
            {
                //la talba premios viene asi: int id,string nombre, int stock, int costomillas
                var values = row.ItemArray;
                Persona persona = new Persona();
                persona.Id = (int)values[0];
                persona.Nombre = (string)values[1];
                persona.Apellido = (string)values[2];
                persona.Dni = (decimal)values[3];
                persona.Direccion = (string)values[4];
                persona.Telefono = (decimal)values[5];
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




        private void completarCompra()
        {
            /* private int _idCompra;
        private string _nombre;
        private string _apellido;
        private decimal _dni;
        private string _direccion;
        private int _telefono;
        private string _email;
        private DateTime _fechaNac;
 
        private int _viajeSeleccionado;
        private decimal _importe;
        private int _tipopago;
        private int _idButaca;
             * */

            Persona esteCliente = crearCliente();
            Pago estePago = CrearPago();

            compraActual.Apellido = esteCliente.Apellido;
            compraActual.Nombre = esteCliente.Nombre;
            compraActual.Dni = esteCliente.Dni;
            compraActual.Direccion = esteCliente.Direccion;
            compraActual.Email = esteCliente.Email;
            compraActual.Telefono = esteCliente.Telefono;
            compraActual.FechaNac = esteCliente.FechaNac;
            compraActual.ViajeSeleccionado = estePago.Id_viaje;
            compraActual.Importe = estePago.Importe;
            compraActual.Tipopago = estePago.Tipo_pago;
            
          

        }



        private Persona crearCliente()
        {
            Persona cliente = new Persona();
          
            cliente.Apellido = txtApellido.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Dni = Convert.ToDecimal(txtDni.Text);
            cliente.Direccion = txtDireccion.Text;
            cliente.Email = txtMail.Text;
            cliente.Telefono = Convert.ToDecimal(txtTelefono.Text);
            cliente.FechaNac = dtFechaNac.Value;

            return cliente;

        }


        private Pago CrearPago()
        {
            Pago pago = new Pago();
            decimal precioBasePasaje=0;
            decimal precioBaseKG=0;
            int id_usuario= 0;
            pago.Id_viaje = compraActual.ViajeSeleccionado;

                /*
            int _id;
            int _pnr;
            int _id_viaje;
            int _id_cliente;
            int _importe;
            DateTime _fecha_compra;
            char _tipo_pago;*/


            DataTable viaje = DAOViaje.getViajeEspecifico(pago.Id_viaje);
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

            Random rnd = new Random(1);
            pago.Pnr = (int)rnd.Next();
            pago.Id_viaje = compraActual.ViajeSeleccionado;
            pago.Importe =(( precioBasePasaje * Convert.ToDecimal(compraActual.CantidadPasajes))+ (precioBaseKG * Convert.ToDecimal(compraActual.CantidadKG)));
           
            DataTable usuario = DAOCliente.buscarClientePorDni(compraActual.Dni);
            if (usuario.DataSet != null)
            {
                DataRow rowsuario = usuario.Rows[0];
                id_usuario = rowsuario.Field<int>("Id");
                
            }

           
            pago.Fecha_compra = DateTime.Now;
            bool pagoT = rbTarjeta.Checked ? true : false;



            bool pagoEfe = rbEfectivo.Checked ? true : false;


            if (pagoT)
                pago.Tipo_pago = 'T';
            else if (pagoEfe)
                pago.Tipo_pago = 'E';


            return pago;
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (EsNumero(this.txtDni.Text))
            {


                if (!IsEmpty(ClientesRegistrados))
                {
                   // clienteActual = ClientesRegistrados.
                    
                    foreach(Persona personita in ClientesRegistrados)
                    {
                        if (personita.Dni == Convert.ToDecimal(txtDni.Text))
                        {
                            clienteActual = personita;
                        }
                    }
                    if (clienteActual != null)
                    {
                        Autocompletar(clienteActual);
                    }
                }


            }
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNum.Enabled = false;
            this.txtVenc.Enabled = false;
            this.cmbTipo.Enabled = false;
            this.cmbCuotas.Enabled = false;
            
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNum.Enabled = true;
            this.txtVenc.Enabled = true;
            this.cmbTipo.Enabled = true;
            this.cmbCuotas.Enabled = true;
           
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (estaTodoLLeno())
            {
                completarCompra();
                    try
                    {
                        
                        DAOCompra.AgregarCompra(compraActual);

                        MessageBox.Show("Felicitaciones has realizado tu compra");
                        this.Hide();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error." + ex.Message);
                    }


                }
          

            else
            {
                MessageBox.Show("Debe ingresar todos los datos obligatorios");
                return;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
