using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    public class Ruta
    {
        private int _CodigoRuta;
        private string _TipoServicio;    
        private int _CiudadOrigen;
        private int _CiudadDestino;
        private int _PrecioKG;
        private int _PrecioBase;
        private int _habilitado;

        public Ruta(int codigoRuta, string tipoDeServicio, int ciudadOrigen, int ciudadDestino, int precioKG, int precioBase,int habilitado)
        {
            // TODO: Complete member initialization
            this.CodigoRuta = codigoRuta;
            this.TipoServicio = tipoDeServicio;
            this.CiudadOrigen = ciudadOrigen;
            this.CiudadDestino = ciudadDestino;
            this.PrecioKG = precioKG;
            this.PrecioBase = precioBase;
            this.Habilitado = habilitado;
        }

        public int Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public int CodigoRuta
        {
            get { return _CodigoRuta; }
            set { _CodigoRuta = value; }
        }

        public string TipoServicio
        {
            get { return _TipoServicio; }
            set { _TipoServicio = value; }
        }

        public int CiudadOrigen
        {
            get { return _CiudadOrigen; }
            set { _CiudadOrigen = value; }
        }

        public int CiudadDestino
        {
            get { return _CiudadDestino; }
            set { _CiudadDestino = value; }
        }

        public int PrecioKG
        {
            get { return _PrecioKG; }
            set { _PrecioKG = value; }
        }

        public int PrecioBase
        {
            get { return _PrecioBase; }
            set { _PrecioBase = value; }
        }
    }
}
