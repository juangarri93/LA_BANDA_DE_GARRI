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

        public ModificarFuncionalidadParaUnRol(String Nombre)
        {
            InitializeComponent();
            labelMuestraNombre.Text = "capeon";
            CargarRol(Nombre);
            MessageBox.Show("El nombre del Rol es" + Rol.Nombre);
            MessageBox.Show("El id del Rol es" + Convert.ToString(Rol.Codigo));
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

        private void CargarRol(String N)
        {
            Rol = DAORol.DameRol(N);
        }

        private void ModificarFuncionalidadParaUnRol_Load(object sender, EventArgs e)
        {

        }

    }
}
