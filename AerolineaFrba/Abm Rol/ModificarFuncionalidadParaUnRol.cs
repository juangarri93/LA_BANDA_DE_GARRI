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
            labelMuestraNombre.Text = Nombre;
            CargarRol(Nombre);
            mostarListaFuncionalidades();
        }

        private void Funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mostarListaFuncionalidades()
        {
            Funcionalidades.DataSource = DAOFuncionalidades.getFuncionalidades().DefaultView;
            Funcionalidades.DisplayMember = "Nombre";
            Funcionalidades.ValueMember = "Id";

            foreach (var func in Rol.Funcionalidades)
            {
                Funcionalidades.SetItemChecked(func, true);
            }

        }

        //Genero un nuevo Rol con la lista de funcionalidades que son enteros --> Son los que selecciono
        private Rol GenerarRol()
        {
            var lista = Funcionalidades.CheckedIndices.Cast<int>().ToList();
            Rol.Funcionalidades = lista;
            return Rol;
        }

        private void CargarRol(String N)
        {
            Rol = DAORol.DameRol(N);
        }

        private void ModificarFuncionalidadParaUnRol_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DAORol.actualizarRol(GenerarRol());
                MessageBox.Show("Rol agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

    }
}
