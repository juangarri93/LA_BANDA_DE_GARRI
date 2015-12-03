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

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();

            List<String> estadisticas = new List<string>();
            estadisticas.Add("Destinos con mas pasajes comprados");
            estadisticas.Add("Destinos con aeronaves mas vacias");
            estadisticas.Add("Clientes con mas puntos acumulados a la fecha");
            estadisticas.Add("Destinos con pasajes cancelados");
            estadisticas.Add("Aeronaves con mayor cantidad de dias fuera de servicio");
            this.cmbListado.DataSource = estadisticas;

            List<String> semestres = new List<string>();
            semestres.Add("Primer semestre");
            semestres.Add("Segundo semestre");
            this.cbSemestre.DataSource = semestres;

            List<String> anios = new List<String>();
             
            for (int i = 2020; i >= 1900; i--)
            {
                anios.Add(Convert.ToString(i));
            }
            this.cbAño.DataSource = anios;

        }

        private void cmbListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indice = cmbListado.SelectedIndex + 1;
            decimal anio = Convert.ToDecimal(cbAño.Text);
            int semestre = Convert.ToInt32(cbSemestre.SelectedIndex + 1);

            switch (indice)
            {
                case 1:
                    MessageBox.Show("TOP 5 de Destinos con mas pasajes comprados en el " + cbSemestre.Text + " de " + cbAño.Text);
                    dgvListado.DataSource = DAOEstadistica.estadisticaDestinosconPasPasajesComprados(anio,semestre);
                    break;
                
                case 2:
                    MessageBox.Show("TOP 5 de Destinos con aeronaves mas vacias en el " + cbSemestre.Text + " de " + cbAño.Text);
                    dgvListado.DataSource = DAOEstadistica.estadisticaDestinosConAeronavesMasVacias(anio, semestre);
                    break;
                case 3:
                    MessageBox.Show("TOP 5 de Clientes con mas puntos acumulados a la fecha en el " + cbSemestre.Text + " de " + cbAño.Text);
                    dgvListado.DataSource = DAOEstadistica.estadisticaClientesConMasPuntosAcumulados(anio, semestre);
                    break;
                case 4:
                    MessageBox.Show("TOP 5 de Destinos con pasajes cancelados en el " + cbSemestre.Text + " de " + cbAño.Text);
                    dgvListado.DataSource = DAOEstadistica.estadisticaDestinosConPasajesCancelados(anio, semestre);
                    break;
                case 5:
                    MessageBox.Show("TOP 5 de Aeronaves con mayor cantidad de dias fuera de servicio en el " + cbSemestre.Text + " de " + cbAño.Text);
                    dgvListado.DataSource = DAOEstadistica.estadisticaAeronavesConMayorCantidadDeDiasFueraDeServicio(anio, semestre);
                    break;

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
