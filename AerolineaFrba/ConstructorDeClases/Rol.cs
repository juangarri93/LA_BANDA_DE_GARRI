using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.ConstructorDeClases
{
    public class Rol
    {

        private int _Codigo;
        private string _Nombre;
        private bool _Habilitado;
        private List<int> _Funcionalidades; // Funcionalidades nuevas para la persona

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        public List<int> Funcionalidades
        {
            get { return _Funcionalidades; }
            set { _Funcionalidades = value; }
        }


        public Rol(string nombre, List<int> funcionalidades) 
        {
            Nombre = nombre;
            Funcionalidades = funcionalidades;
            Habilitado = true;
        
        }

        public Rol(int cod, string nombre, bool habilitado)
        {
            Codigo = cod;
            Nombre = nombre;
            Habilitado = habilitado;
        }



    }
}
