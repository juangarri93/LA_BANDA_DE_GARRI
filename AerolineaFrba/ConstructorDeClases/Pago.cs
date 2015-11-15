using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    class Pago
    {

     
        int _pnr;
        int _id_viaje;
        int _id_cliente;
        decimal _importe;
        DateTime _fecha_compra;
        char _tipo_pago;

        public Pago() { }

        public Pago(int pnr, int idviaje, int idcliente, decimal importe, DateTime fechacompra, char tipopago)
        {
            Pnr = pnr;
            Id_viaje = idviaje;
            Id_cliente = idcliente;
            Importe = importe;
            Fecha_compra = fechacompra;
            Tipo_pago = tipopago;

        }


 


        public int Pnr
        {
            get { return _pnr; }
            set { _pnr = value; }
        }


        public int Id_viaje
        {
            get { return _id_viaje; }
            set { _id_viaje = value; }
        }


        public int Id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }


        public decimal Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }


        public DateTime Fecha_compra
        {
            get { return _fecha_compra; }
            set { _fecha_compra = value; }
        }


        public char Tipo_pago
        {
            get { return _tipo_pago; }
            set { _tipo_pago = value; }
        }


    }
}
