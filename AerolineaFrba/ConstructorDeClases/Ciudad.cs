using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AerolineaFrba.ConstructorDeClases
{

    public class Ciudad
    {
        private int _id_ciudad;
        private string _nombre;
        private string _pais;

        public Ciudad(int codigoCiudad, string nombre,string  pais) 
        {
            IdentificadorCiudad = codigoCiudad;
            Nombre =  nombre;
            Pais = pais;

        }

        public int IdentificadorCiudad
        {
            get { return _id_ciudad; }
            set { _id_ciudad = value; }
        }

        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
    }
}
