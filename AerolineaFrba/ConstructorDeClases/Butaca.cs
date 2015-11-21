using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    public class Butaca
    {
        int _id;
        decimal _numero;
        int _tipo;
        decimal _piso;
        int _Aeronave_id;


        public Butaca() { }
        public Butaca(int id, decimal numero, int tipo, decimal piso, int aernoave) 
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
            Piso = piso;
            Aeronave_id = aernoave;

        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public decimal Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public decimal Piso
        {
            get { return _piso; }
            set { _piso = value; }
        }

        public int Aeronave_id
        {
            get { return _Aeronave_id; }
            set { _Aeronave_id = value; }
        }
    }
}
