using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    class Viaje
    {
        private DateTime _FechaSalida;
        private DateTime _FechaLlegada;
        private DateTime _FechaLlegadaEstimada;
        private Aeronave _Aeronave;
        private Ruta _Ruta;
        private string _habilitado;

        public Viaje(DateTime fechasalida, DateTime fechallegada, DateTime fechallegadaestimada, Aeronave aeronave, Ruta ruta , string habilitado)
        {
            if (ValidarDatos(fechasalida,fechallegada,fechallegadaestimada)==true)
            {
                this._FechaSalida = fechasalida;
                this._FechaLlegada = fechallegada;
                this._FechaLlegadaEstimada = fechallegadaestimada;
                this._Aeronave = aeronave;
                this._Ruta = ruta;
            }
        }
       
        public bool ValidarDatos(DateTime fechasalida, DateTime fechallegada, DateTime fechallegadaestimada){

            if (fechasalida <= fechallegada && fechasalida <= fechallegadaestimada)
            {
                return true;
            }
            else
                return false;


        }

        public string Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public DateTime FechaSalida
        {
            get { return _FechaSalida; }
            set { _FechaSalida = value; }
        }


        public DateTime FechaLlegada
        {
            get { return _FechaLlegada; }
            set { _FechaLlegada = value; }
        }


        public DateTime FechaLlegadaEstimada
        {
            get { return _FechaLlegadaEstimada; }
            set { _FechaLlegadaEstimada = value; }
        }


        public Aeronave Aeronave
        {
            get { return _Aeronave; }
            set { _Aeronave = value; }
        }


        public Ruta Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }



    }
}
