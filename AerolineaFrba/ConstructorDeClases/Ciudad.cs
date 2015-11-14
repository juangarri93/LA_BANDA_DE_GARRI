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
        private Boolean _Habilitado;

        public Boolean Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        public Ciudad(){}
        public Ciudad(int codigoCiudad, string nombre,Boolean habilitado) 
        {
            IdentificadorCiudad = codigoCiudad;
            Nombre =  nombre;
            Habilitado = habilitado;

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

      
    }
}
