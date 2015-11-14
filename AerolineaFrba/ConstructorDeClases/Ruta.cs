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
        private int _TipoServicio;    
        private string _CiudadOrigen;
        private string _CiudadDestino;
        private decimal _PrecioKG;
        private decimal _PrecioBase;
        private int _habilitado;
        private int _id;

        public Ruta(int id,int codigoRuta, int tipoDeServicio, string ciudadOrigen, string ciudadDestino, decimal precioKG, decimal precioBase,int habilitado)
        {
            // TODO: Complete member initialization
            this.CodigoRuta = codigoRuta;
            this.TipoServicio = tipoDeServicio;
            this.CiudadOrigen = ciudadOrigen;
            this.CiudadDestino = ciudadDestino;
            this.PrecioKG = precioKG;
            this.PrecioBase = precioBase;
            this.Habilitado = habilitado;
            this.Id = id;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        public int TipoServicio
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

        public decimal PrecioKG
        {
            get { return _PrecioKG; }
            set { _PrecioKG = value; }
        }

        public decimal PrecioBase
        {
            get { return _PrecioBase; }
            set { _PrecioBase = value; }
        }
    }
}
