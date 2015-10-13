using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using AerolineaFrba.CapaADO;
using AerolineaFrba.ConstructorDeClases;


namespace AerolineaFrba.Abm_Rol
{
    public partial class ABMRolAlta : Form
    {
        public ABMRolAlta()
        {
            InitializeComponent();
            mostarListaFuncionalidades();
        }

        //Muestro y cargo Funcionalidades que se encuentran en la tabla --> Las debo ir a buscar a la base
        private void mostarListaFuncionalidades()
        {
            Funcionalidades.DataSource = DAOFuncionalidades.getFuncionalidades().DefaultView;
            Funcionalidades.DisplayMember = "nombre";
            Funcionalidades.ValueMember = "id_funcionalidad";     
        }

        //Cargo y genero un nuevo rol a la lista de funcionalidades
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DAORol.AgregarRol(GenerarRol());
                MessageBox.Show("Rol agregado correctamente.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);        
            }


        }

        //Genero un nuevo Rol con la lista de funcionalidades que son enteros --> Son los que selecciono
        private Rol GenerarRol()
        {
            var lista = Funcionalidades.CheckedIndices.Cast<int>().ToList();
            return new Rol(txtNombre.Text,lista);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ABMRolAlta_Load(object sender, EventArgs e)
        {
            
        }
    }
}
