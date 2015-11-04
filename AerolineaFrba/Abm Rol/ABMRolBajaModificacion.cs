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
                //DAORol.EditarModificarRol(generarRol());
                MessageBox.Show("Rol agregado correctamente.");
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
            cbNombre.DataSource = DAORol.getRol().DefaultView;
            cbNombre.DisplayMember = "Rol";
            Funcionalidades.Enabled = false;
            mostarListaFuncionalidades();
        }

    }
}
