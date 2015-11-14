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
        Compra compraActual; 

        public AltaCompra()
        {
            this.compraActual = new Compra();
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

            dgvCompra.AutoGenerateColumns = true;
          

        }


        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCompra.Columns["dataGridViewCheckBoxColumn1"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvCompra.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }

        }

        private void dgvCompra_DoubleClick(object sender, EventArgs e)
        {
            // string fechaAlta = Convert.ToString(this.dataListadoAeronaves.CurrentRow.Cells["Fecha_alta"].Value);
            if (dgvCompra.IsAccessible)
            {

                this.compraActual.ViajeSeleccionado = Convert.ToInt32(this.dgvCompra.CurrentRow.Cells["Id"].Value);

                this.compraActual.FechaDeViaje = this.dtpFechaViaje.Value;

                DataTable ciudadorigen = DAOCiudad.buscarCiudad(this.cmbOrigen.SelectedText);
                DataTable ciudaddestino = DAOCiudad.buscarCiudad(this.cmbDestino.SelectedText);

                DataRow row = ciudadorigen.Rows[0];
                Ciudad o = new Ciudad();
                o.IdentificadorCiudad = Convert.ToInt32(row["Id"]);
                o.Nombre = (string)row["Nombre"];
                o.Habilitado = (bool)row["Habilitado"];

                DataRow row2 = ciudaddestino.Rows[0];
                Ciudad o2 = new Ciudad();
                o2.IdentificadorCiudad = Convert.ToInt32(row2["Id"]);
                o2.Nombre = (string)row2["Nombre"];
                o2.Habilitado = (bool)row2["Habilitado"];

                this.compraActual.Origen = o.IdentificadorCiudad;
                this.compraActual.Destino = o2.IdentificadorCiudad;
            }
            else
                return;
             
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
                        this.compraActual.CantidadKG = kgs;
                        this.compraActual.CantidadPasajes = pasajes+1;
                        this.compraActual.FechaDeViaje = dtpFechaViaje.Value;
                       

                        var ventanaDatosUsuario = new Butacas(compraActual);
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
