using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    class Millas
    {
        int _Id_Cliente;
        int _Cantidad;
        DateTime _fecha_Exp;

        public Millas(int idCliente, int cantidad, DateTime fechaExp)
        {
            this._Id_Cliente = idCliente;
            this._Cantidad = cantidad;
            this._fecha_Exp = fechaExp;
        }

        public int Id_Cliente
        {
            get { return _Id_Cliente; }
            set { _Id_Cliente = value; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public DateTime Fecha_Exp
        {
            get { return _fecha_Exp; }
            set { _fecha_Exp = value; }
        }
    }
}
