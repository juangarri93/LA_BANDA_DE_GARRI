﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    public class Viaje
    {
        private int _id;
        private DateTime _FechaSalida;
        private DateTime _FechaLlegada;
        private DateTime _FechaLlegadaEstimada;
        private string _Aeronave;
        private decimal _Ruta;
        private string _habilitado;


        public Viaje() {
            this.Habilitado = "Habilitado";
        }

        public Viaje(DateTime fechasalida, DateTime fechallegada, DateTime fechallegadaestimada, string aeronave, decimal ruta, string habilitado)
        {
            if (ValidarDatos(fechasalida,fechallegada,fechallegadaestimada)==true)
            {
                this._FechaSalida = fechasalida;
                this._FechaLlegada = fechallegada;
                this._FechaLlegadaEstimada = fechallegadaestimada;
                this._Aeronave = aeronave;
                this._Ruta = ruta;
                this._habilitado = habilitado;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool ValidarDatos(DateTime fechaSalida, DateTime fechaLlegada, DateTime fechaLlegadaEstimada)
        {

            return true;

            if ((fechaSalida.Year == fechaLlegada.Year) &&
             (fechaSalida.Month == fechaLlegada.Month) &&
             ((fechaLlegada.Day - fechaSalida.Day) <= 1) &&
             ((fechaSalida.Year == fechaLlegadaEstimada.Year) &&
             (fechaSalida.Month == fechaLlegadaEstimada.Month) &&
             (fechaLlegadaEstimada.Day - fechaSalida.Day) <= 1)) 
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


        public string Aeronave
        {
            get { return _Aeronave; }
            set { _Aeronave = value; }
        }


        public decimal Ruta
        {
            get { return _Ruta; }
            set { _Ruta = value; }
        }



    }
}
