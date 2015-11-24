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

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class Registro : Form
    {
        string matricula;
        string origen;
        string destino;

        public Registro()
        {
            InitializeComponent();
            cargarComboBox();
            this.dtpFecha.Enabled = false;
            this.tpHorario.Enabled = false;

        }

        private void cargarComboBox()
        {
            this.cbOrigen.DataSource = DAOCiudad.Mostrar();
         
            this.cbDestino.DataSource = DAOCiudad.Mostrar();
            cbDestino.DisplayMember = "Nombre";
            cbDestino.ValueMember = "Id"; //cambiar a Id para la base original
            cbOrigen.DisplayMember = "Nombre";
            cbOrigen.ValueMember = "Id";
        }



        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validaciones()
        {
            if (txtMatricula.Text == "")
            {
                MessageBox.Show("El campo matrícula no puede estar vacío.");
                return false;
            }
            if (cbOrigen.Text == cbDestino.Text)
            {
                MessageBox.Show("Las ciudades no pueden coincidir.");
                return false;
            }
            return true;
        }

        private void btnConsultarMatr_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                matricula = Convert.ToString(this.txtMatricula.Text);
                origen = Convert.ToString(cbOrigen.Text);
                destino = Convert.ToString(cbDestino.Text);

                int aux = DAOViaje.CheckearViaje(matricula, origen, destino);

                if (aux == 0)
                {
                    MessageBox.Show("No se ha encontrado un Vuelo, intente nuevamente..");
                    this.dtpFecha.Enabled = false;
                    this.tpHorario.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vuelo encontrado, introduzca la fecha y horario de llegada.");
                    this.dtpFecha.Enabled = true;
                    this.tpHorario.Enabled = true;
                }
            }
            else
            {
                return;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtMatricula.Text = "";
            this.dtpFecha.Enabled = false;
            this.tpHorario.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, tpHorario.Value.Hour, tpHorario.Value.Minute, tpHorario.Value.Second);

            int aux = DAOViaje.RegistrarLlegada(matricula, origen, destino, fecha);

            if (aux == 1)
            {
                MessageBox.Show("Se ha registrado el arrivo correctamente.");
                return;
            }
            else
            {
                MessageBox.Show("Se ha producido un error al registrar el arrivo.");
                return;
            }


        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tpHorario_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filtrarMatricula_Enter(object sender, EventArgs e)
        {

        }

      
    }
}
