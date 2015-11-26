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
    public partial class ModificarEstadoRol : Form
    {

        Rol rol;

        public ModificarEstadoRol()
        {
            InitializeComponent();
        }

        private void ModificarEstadoRol_Load(object sender, EventArgs e)
        {

            this.dgRolesEstado.DataSource = DAORol.getRol();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                String nombreAnt = "";

                DAORol.EditarNombreRol(nombreAnt,true);
                MessageBox.Show("Rol Modificado correctamente.");

          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

        private void dgRolesEstado_DoubleClick(object sender, EventArgs e)
        {

            rol.Codigo = Convert.ToInt32(this.dgRolesEstado.CurrentRow.Cells["Id"].Value);
            rol.Nombre = Convert.ToString(this.dgRolesEstado.CurrentRow.Cells["Rol"].Value);
            rol.Habilitado = Convert.ToBoolean(this.dgRolesEstado.CurrentRow.Cells["Habilitado"].Value);


        }
    }
}
