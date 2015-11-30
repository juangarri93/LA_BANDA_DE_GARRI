using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AerolineaFrba.ConstructorDeClases
{
    public class Cancelacion
    {
        private DateTime _fechaDevolucion;
        private int _NumeroDeCompraPNR;
        private int _NumeroPasaje;
        private string _motivoCancelacion;
        private DateTime dateTime;
     

        public Cancelacion(DateTime fecha, int PNR, int codigo, string motivo)
        {
            fechaDevolucion = fecha;
            NumeroDeCompraPNR = PNR;
            NumeroPasaje = codigo;
            motivoCancelacion = motivo;

        }

        public DateTime fechaDevolucion
        {
            get { return _fechaDevolucion; }
            set { _fechaDevolucion = value; }
        }

        public int NumeroDeCompraPNR
        {
            get { return _NumeroDeCompraPNR; }
            set { _NumeroDeCompraPNR = value; }
        }

        public int NumeroPasaje
        {
            get { return _NumeroPasaje; }
            set { _NumeroPasaje = value; }
        }

        public string motivoCancelacion
        {
            get { return _motivoCancelacion; }
            set { _motivoCancelacion = value; }
        }


    }
}
