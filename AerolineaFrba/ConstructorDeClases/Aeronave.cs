using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AerolineaFrba.ConstructorDeClases
{
    


    public class Aeronave
    {
        private int _CodigoAeronave;
        private DateTime _FechaAlta;
        private int _NumeroAeronave;
        private int _Modelo;
        private string _Matricula;
        private int _Fabricante;
        private int _TipoDeServicio;
        private string _BajaPorFueraDeServicio;
        private string _BajaPorVidaUtil;
        private DateTime _FechaDeFueraDeServicio;
        private DateTime _FechaDeReinicioDeServicio;
        private DateTime _FechaDeBajaDefinitiva;
        private int _CantidadButacaPasillo;
        private int _CantidadDeButacasVentana;
        private int _KGDisponible;

        public Aeronave(int codigoAeronave,DateTime fechaAlta,int numero,int modelo,
                        string matricula,int fabricante,int tipoDeServicio,string bajaPorFueraDeServicio,
                        DateTime fechaDeFueraDeServicio,DateTime fechaDeReinicioDeServicio,
                        int cantidadButacaVentana,int cantidadButacaPasillo,int cantidadKG) 
        {
            CodigoAeronave = codigoAeronave;
            FechaAlta = fechaAlta;
            NumeroAeronave = numero;
            Modelo = modelo;
            Matricula = matricula;
            Fabricante = fabricante;
            TipoDeServicio = tipoDeServicio;
            BajaPorFueraDeServicio = bajaPorFueraDeServicio;
            FechaDeFueraDeServicio = fechaDeFueraDeServicio;
            FechaDeReinicioDeServicio = fechaDeReinicioDeServicio;
            CantidadButacaVentana = cantidadButacaVentana;
            CantidadButacaPasillo = cantidadButacaPasillo;
            KGDisponible = cantidadKG;
        }

        public int CodigoAeronave
        {
            get { return _CodigoAeronave; }
            set { _CodigoAeronave = value; }
        }

        public int KGDisponible
        {
          get { return _KGDisponible; }
          set { _KGDisponible = value; }
        }

        public int CantidadButacaVentana
        {
            get { return _CantidadDeButacasVentana; }
            set { _CantidadDeButacasVentana = value; }
        }

        public int CantidadButacaPasillo
        {
            get { return _CantidadButacaPasillo; }
            set { _CantidadButacaPasillo = value; }
        }

        public DateTime FechaDeBajaDefinitiva
        {
          get { return _FechaDeBajaDefinitiva; }
          set { _FechaDeBajaDefinitiva = value; }
        }

        public DateTime FechaDeReinicioDeServicio
        {
          get { return _FechaDeReinicioDeServicio; }
          set { _FechaDeReinicioDeServicio = value; }
        }

        public DateTime FechaDeFueraDeServicio
        {
          get { return _FechaDeFueraDeServicio; }
          set { _FechaDeFueraDeServicio = value; }
        }

        public string BajaPorVidaUtil
        {
          get { return _BajaPorVidaUtil; }
          set { _BajaPorVidaUtil = value; }
        }


        public string BajaPorFueraDeServicio
        {
          get { return _BajaPorFueraDeServicio; }
          set { _BajaPorFueraDeServicio = value; }
        }

        public int TipoDeServicio
        {
          get { return _TipoDeServicio; }
          set { _TipoDeServicio = value; }
        }

        public int Fabricante
        {
          get { return _Fabricante; }
          set { _Fabricante = value; }
        }

        public string Matricula
        {
          get { return _Matricula; }
          set { _Matricula = value; }
        }

        public int Modelo
        {
          get { return _Modelo; }
          set { _Modelo = value; }
        }


        public int NumeroAeronave
        {
          get { return _NumeroAeronave; }
          set { _NumeroAeronave = value; }
        }
        
        public DateTime FechaAlta
            {
                get { return _FechaAlta; }
                set { _FechaAlta = value; }
            }


    }
}
