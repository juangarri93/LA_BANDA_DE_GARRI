﻿using System;
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
using AerolineaFrba.Herramientas;
using AerolineaFrba.ABM_Compra;
using System.Text.RegularExpressions;

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
            cmbDestino.ValueMember = "CodigoCiudad"; //cambiar a Id para la base original
            cmbOrigen.DisplayMember = "Nombre";
            cmbOrigen.ValueMember = "CodigoCiudad";
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


        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
      {
            if (dtpFechaViaje.Value.Date < DateTime.Now.Date)
                MessageBox.Show("Fecha incorrecta");
            else if (cmbDestino.SelectedValue == cmbOrigen.SelectedValue)
                MessageBox.Show("Las ciudades origen y destino no pueden coincidir");
           
            else
            {
                try
                {
                    /*DataTable ciudadLevantadaOrigen = DAOCiudad.buscarCiudad(cmbOrigen.ValueMember);
                    DataTable ciudadLevantadaDestino = DAOCiudad.buscarCiudad(cmbDestino.ValueMember);
                    DataRow rowOrigen = ciudadLevantadaOrigen.Rows[0];
                    DataRow rowDestino = ciudadLevantadaDestino.Rows[0];
                    Ciudad origen = new Ciudad(rowOrigen.Field<int>(0), rowOrigen.Field<string>("Nombre"), rowOrigen.Field<Boolean>("Habilitada"));
                    Ciudad destino = new Ciudad(rowDestino.Field<int>(0), rowDestino.Field<string>("Nombre"),rowDestino.Field<Boolean>("Habilitada"));
                    */
                   this.dgvCompra.DataSource = DAOViaje.Buscar(dtpFechaViaje.Value,cmbOrigen.SelectedText,cmbDestino.SelectedText);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error." + ex.Message);
                }
            }
        }

        private bool EsNumero(string cadena)
        {
            var regex = new Regex(@"^-*[0-9,\.]+$");
            return regex.IsMatch(cadena); 
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            try
            {
                if (EsNumero(txtCantKG.Text))
                {
                    int kgs = chkEncomienda.Checked ? Convert.ToInt32(txtCantKG.Text) : 0;
               
                                
                    
                    int pasajes = chkPasajes.Checked ? (cantPasajes.SelectedIndex) : 0;

                    if (kgs + pasajes > 0)
                    {
                        var ventanaDatosUsuario = new DatosCompra();
                        FormsHerramientas.mostrarVentanaNueva(ventanaDatosUsuario, this);
                    }
                    else MessageBox.Show("Debe ingresar una cantidad valida de pasajes y/o encomiendas");
            
                }
                else MessageBox.Show("El número ingresado es inválido.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
             

            
      }

        private void chkPasajes_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkEncomienda_CheckedChanged(object sender, EventArgs e)
        {
            txtCantKG.Enabled = chkEncomienda.Checked;
            txtCantKG.Text = "0";
        }

        private void dgvCompra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvCompra.Columns[e.ColumnIndex].Name == "Id")
            {
                this.dgvCompra.Columns[e.ColumnIndex].Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}