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
        private int _dni;
        private string _direccion;
        private int _telefono;
        private string _email;
        private DateTime _fechaNac;
        private DateTime _fechaDeViaje;
        private int _origen;
        private int _destino;
        private int _cantidadPasajes;
        private int _cantidadKG;
        private int _viajeSeleccionado;
        private string _estado;

        public Compra(int idCompra, string nombre, string apellido, int dni, string direccion, int telefono, string email, DateTime fechaNac, DateTime fechaDeViaje, int origen, int destino, int cantidadPasajes, int cantidadKG, int viajeSeleccionado, string estado)
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
            this._estado = estado;

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

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public int Telefono
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
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
   

    }
}
