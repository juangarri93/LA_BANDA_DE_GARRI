using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.CapaADO;
using AerolineaFrba.ConstructorDeClases;

namespace AerolineaFrba.Abm_Rol
{
    public partial class ModificarFuncionalidadParaUnRol : Form
    {
        private Rol _rol;

        public Rol Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        public ModificarFuncionalidadParaUnRol(int idSeleccionado)
        {
            InitializeComponent();
            labelMuestraNombre.Text = "capeon";
           // CargarRol(idSeleccionado);
           // mostarListaFuncionalidades();
        }

        private void Funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mostarListaFuncionalidades()
        {
            Funcionalidades.DataSource = DAOFuncionalidades.getFuncionalidades().DefaultView;
            Funcionalidades.DisplayMember = "Nombre";
            Funcionalidades.ValueMember = "Id";

            foreach (var func in _rol.Funcionalidades)
            {
                Funcionalidades.SetItemChecked(func, true);
            }

        }

        //Genero un nuevo Rol con la lista de funcionalidades que son enteros --> Son los que selecciono
        private Rol GenerarRol()
        {
            var lista = Funcionalidades.CheckedIndices.Cast<int>().ToList();
            return new Rol(Rol.Nombre, lista);
        }

        private void CargarRol(int id)
        {
            Rol = DAORol.getRol(id);
        }

    }
}
