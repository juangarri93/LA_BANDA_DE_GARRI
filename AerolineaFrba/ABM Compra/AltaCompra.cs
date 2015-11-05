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

namespace AerolineaFrba.Abm_Compra
{
    public partial class AltaCompra : Form
    {
        public AltaCompra()
        {
            InitializeComponent();

            cmbOrigen.DataSource = DAOCiudad.Mostrar();
            cmbDestino.DataSource = DAOCiudad.Mostrar();
            cmbDestino.DisplayMember = "Nombre";
            cmbDestino.ValueMember = "Id"; //cambiar a Id para la base original
            cmbOrigen.DisplayMember = "Nombre";
            cmbOrigen.ValueMember = "Id";
            cantPasajes.Items.Add(1);
            cantPasajes.Items.Add(2);
            cantPasajes.Items.Add(3);
            cantPasajes.Items.Add(4);
            cantPasajes.Items.Add(5);
            cantPasajes.Items.Add(6);
            cantPasajes.Items.Add(7);
            cantPasajes.Items.Add(8);
            cantPasajes.Items.Add(9);
            cantPasajes.Items.Add(10);
            txtCantKG.Text = "0";

            dgvCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCompra.AutoGenerateColumns = true;
            dgvCompra.ReadOnly = true;


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtpFechaViaje.Value.Date < DateTime.Now.Date)
                MessageBox.Show("Fecha incorrecta");
            else if (cmbDestino.SelectedValue == cmbOrigen.SelectedValue)
                MessageBox.Show("Las ciudades origen y destino no pueden coincidir");
           
            else
            {
                try
                {
                    DataTable ciudadLevantadaOrigen = DAOCiudad.buscarCiudad(cmbOrigen.ValueMember);
                    DataTable ciudadLevantadaDestino = DAOCiudad.buscarCiudad(cmbDestino.ValueMember);
                    DataRow rowOrigen = ciudadLevantadaOrigen.Rows[0];
                    DataRow rowDestino = ciudadLevantadaDestino.Rows[0];
               //     Ciudad origen = new Ciudad(rowOrigen.Field<int>(0),rowOrigen.Field<string>("Nombre"));
               //     Ciudad destino = new Ciudad(rowDestino.Field<int>(0),rowDestino.Field<string>("Nombre"));

               //     this.dgvCompra.DataSource = DAOViaje.Buscar(dtpFechaViaje.Value, origen, destino);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error." + ex.Message);
                }
            }
        }
    }
}
