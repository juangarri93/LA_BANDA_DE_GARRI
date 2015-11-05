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
    public partial class ABMRolBajaModificacion : Form
    {

        private Rol _rol;

        public ABMRolBajaModificacion()
        {
            InitializeComponent();
        }

        private void dataListadoAeronaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String nombreAnt = Convert.ToString(cbNombre.Text);

                DAORol.EditarNombreRol(nombreAnt, txtNuevoRol.Text);
                MessageBox.Show("Rol Modificado correctamente.");

                cbNombre.DataSource = DAORol.getRol().DefaultView;
                cbNombre.DisplayMember = "Rol";

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hubo un error." + ex.Message);     
            }
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

        private void CargarRol(int id)
        {
            _rol = DAORol.getRol(id);
        }

        private void ABMRolBajaModificacion_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            Funcionalidades.Enabled = false;
            cbNombre.DataSource = DAORol.getRol().DefaultView;
            cbNombre.DisplayMember = "Rol";
            mostarListaFuncionalidades();
          
        }

        private void EditarFuncionalidad_Click(object sender, EventArgs e)
        {
            Funcionalidades.Enabled = true;
            btnGuardar.Enabled = true;

            try
            {
                DAORol.ActualizarRolFuncionalidad(GenerarRol());
                MessageBox.Show("Rol modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
                
        }

        //Genero un nuevo Rol con la lista de funcionalidades que son enteros --> Son los que selecciono
        private Rol GenerarRol()
        {
            var lista = Funcionalidades.CheckedIndices.Cast<int>().ToList();
            return new Rol(cbNombre.Text, lista);
        }

    }
}
