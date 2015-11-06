using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    class Premio
    {
        private int _id;
        private string _nombre;
        private int _cantidad;
        private int _costo_millas;

        public Premio() { }

        public Premio(int id,string nombre, int stock, int costomillas)
        {
            this._id = id;
            this._nombre = nombre;
            this._cantidad = stock;
            this._costo_millas = costomillas;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public int Cantidad_millas
        {
            get { return _costo_millas; }
            set { _costo_millas = value; }
        }
    }
}


