using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    public class Compra
    {
        private int _idCompra;
        private string _nombre;
        private string _apellido;
        private decimal _dni;
        private string _direccion;
        private decimal _telefono;
        private string _email;
        private DateTime _fechaNac;
        private DateTime _fechaDeViaje;
        private int _origen;
        private int _destino;
        private int _cantidadPasajes;
        private int _cantidadKG;
        private int _viajeSeleccionado;
        private decimal _importe;
        private int _tipopago;
        private int _idButaca;
        private List<Butaca> _butacasSeleccionadas;


        public Compra() { }


        public Compra(int idCompra, string nombre, string apellido, decimal dni, string direccion, decimal telefono, string email, DateTime fechaNac, DateTime fechaDeViaje, int origen, int destino, int cantidadPasajes, int cantidadKG, int viajeSeleccionado, string estado, decimal importe, int tipopago, int idbutaca, List<Butaca> butacasSeleccionadas)
        {
            this._idCompra = idCompra;
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._direccion = direccion;
            this._telefono = telefono;
            this._email = email;
            this._fechaNac = fechaNac;
            this._fechaDeViaje = fechaDeViaje;
            this._origen = origen;
            this._destino = destino;
            this._cantidadPasajes = cantidadPasajes;
            this._cantidadKG = cantidadKG;
            this._viajeSeleccionado = viajeSeleccionado;
            this._importe = importe;
            this.Tipopago = tipopago;
            this.IdButaca = idbutaca;

 


        }

        public List<Butaca> ButacasSeleccionadas
        {
            get { return _butacasSeleccionadas; }
            set { _butacasSeleccionadas = value; }
        }


        public int Tipopago
        {
            get { return _tipopago; }
            set { _tipopago = value; }
        }


        public decimal Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        public int IdButaca
        {
            get { return _idButaca; }
            set { _idButaca = value; }
        }


        public int IdCompra
        {
            get { return _idCompra; }
            set { _idCompra = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public decimal Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public decimal Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public int CantidadPasajes
        {
            get { return _cantidadPasajes; }
            set { _cantidadPasajes = value; }
        }
        public int CantidadKG
        {
            get { return _cantidadKG; }
            set { _cantidadKG = value; }
        }

        public DateTime FechaDeViaje
        {
            get { return _fechaDeViaje; }
            set { _fechaDeViaje = value; }
        }

        public int Origen
        {
            get { return _origen; }
            set { _origen = value; }
        }


        public int Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        public int ViajeSeleccionado
        {
            get { return _viajeSeleccionado; }
            set { _viajeSeleccionado = value; }
        }
        
   

    }
}
