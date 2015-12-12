using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.ConstructorDeClases;
using AerolineaFrba.CapaADO;

namespace AerolineaFrba.Devolucion
{
    public partial class CancelarPasajes : Form
    {

        Cancelacion Cancelacion;

        public CancelarPasajes(Cancelacion cancelacion)
        {
          
            InitializeComponent();
            dtButacasCompradas.DataSource = DAOCancelacion.getButacas(cancelacion);
            Cancelacion = cancelacion;
        }

        private void CancelarPasajes_Load(object sender, EventArgs e)
        {
            txtId.ReadOnly = true;
            txtViaje.ReadOnly = true;
            txtButaca.ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtButacasCompradas_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(this.dtButacasCompradas.CurrentRow.Cells["Id"].Value);
            txtViaje.Text = Convert.ToString(this.dtButacasCompradas.CurrentRow.Cells["id_Viaje"].Value);
            txtButaca.Text = Convert.ToString(this.dtButacasCompradas.CurrentRow.Cells["id_Butaca"].Value);
        }

        private void btnCancelarPasajes_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "") MessageBox.Show("Por favor haga doble click en alguna fila de la tabla, en caso de no haber niguna fila es porque el PNR era incorrecto, vuelva a la pantalla anterior e ingrese bien el PNR");
                
                Cancelacion cn = new Cancelacion(Cancelacion.fechaDevolucion, Cancelacion.NumeroDeCompraPNR, Convert.ToInt32(txtButaca.Text), Cancelacion.motivoCancelacion);
                MessageBox.Show("El pasaje se ha cancelado con exito!");
                int numeroRespuesta = DAOCancelacion.cancelaPasaje(cn);
                dtButacasCompradas.DataSource = DAOCancelacion.getButacas(Cancelacion);
               
            }
            catch (Exception ex)
            {

            }



        }
    }
}
