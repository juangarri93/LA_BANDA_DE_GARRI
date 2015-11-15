using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    public class Persona
    {
        //Cli_Nombre	Cli_Apellido	Cli_Dni	Cli_Dir	Cli_Telefono	Cli_Mail	Cli_Fecha_Nac
        //AARON	Lucero	50782882	Avenida Montes de Oca5685	97134963	aaron@gmail.com	1932-11-15 00:00:00.000

        private int _idPersona;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _direccion;
        private int _telefono;
        private string _email;
        private DateTime _fechaNac;
        private string _estado;
        private string _contraseña;
        private string _rol;

        
        public Persona() { }
        public Persona(int idpersona, string nombre, string apellido, int dni, string direccion, int telefono, string email, DateTime fechanac,string rol) {

            Id = idpersona;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaNac = fechanac;
            Estado = "Habilitado";
            Rol = rol;

        }

        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        } 
        public int Id
        {
            get { return _idPersona; }
            set { _idPersona = value; }
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

        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }

        }
        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }


    }
}
