using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    public class Ruta
    {
        private string _CodigoRuta;
        private string _TipoServicio;    
        private string _CiudadOrigen;
        private string _CiudadDestino;
        private string _PrecioKG;
        private string _PrecioBase;

        public Ruta(string codigoRuta, string tipoDeServicio, string ciudadOrigen, string ciudadDestino, string precioKG, string precioBase)
        {
            // TODO: Complete member initialization
            this.CodigoRuta = codigoRuta;
            this.TipoServicio = tipoDeServicio;
            this.CiudadOrigen = ciudadOrigen;
            this.CiudadDestino = ciudadDestino;
            this.PrecioKG = precioKG;
            this.PrecioBase = precioBase;
        }

        public string CodigoRuta
        {
            get { return _CodigoRuta; }
            set { _CodigoRuta = value; }
        }

        public string TipoServicio
        {
            get { return _TipoServicio; }
            set { _TipoServicio = value; }
        }

        public string CiudadOrigen
        {
            get { return _CiudadOrigen; }
            set { _CiudadOrigen = value; }
        }

        public string CiudadDestino
        {
            get { return _CiudadDestino; }
            set { _CiudadDestino = value; }
        }

        public string PrecioKG
        {
            get { return _PrecioKG; }
            set { _PrecioKG = value; }
        }

        public string PrecioBase
        {
            get { return _PrecioBase; }
            set { _PrecioBase = value; }
        }
    }
}
