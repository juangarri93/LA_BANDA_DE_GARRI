using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
             
            for (int i = 1900; i <= 2020; i++)
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

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}
