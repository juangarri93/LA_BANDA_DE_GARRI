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

        private string _BajaPorVidaUtil;

        public Ciudad(int codigoCiudad, string nombre) 
        {
            IdentificadorCiudad = codigoCiudad;
            Nombre =  nombre;
            _BajaPorVidaUtil = "Habilitado";

        }
     
 
         public string BajaPorVidaUtil
        {
            get { return _BajaPorVidaUtil; }
            set { _BajaPorVidaUtil = value; }
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
