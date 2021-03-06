﻿using System;
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

namespace AerolineaFrba.Abm_Ruta
{
    public partial class ABMRutaBajaModificacion : Form
    {
        public ABMRutaBajaModificacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarTextBox();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            limpiar();
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtCodigoRuta.Text = "";
            cbTipoDeServicio.ValueMember = null;
            cbOrigen.SelectedIndex = 0;
            cbDestino.SelectedIndex = 0;
            txtPrecioKG.Text = "";
            txtPrecioBase.Text = "";
            cbHabilitado.SelectedIndex = 0;
        }

        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataGridView.DataSource = DAORuta.Mostrar();
           
        }

        private void ABMRutaBajaModificacion_Load(object sender, EventArgs e)
        {

            txtId.ReadOnly = true;
            txtCodigoRuta.ReadOnly = true;
            deshabilitarTextBox();
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
          
            cbHabilitado.Items.Add("Deshabilitado");
            cbHabilitado.Items.Add("Habilitado");

            cbTipoDeServicio.DataSource = DAOAerolinea.getTipoServicio().DefaultView;
            cbTipoDeServicio.DisplayMember = "Tipo_Servicio";

            this.dataGridView.Columns[0].Visible = false;
            Mostrar();

            cargarComboBox();
        }

        private void deshabilitarTextBox()
        {

            txtCodigoRuta.Enabled = false;
            cbTipoDeServicio.Enabled = false;
            cbOrigen.Enabled = false;
            cbDestino.Enabled = false;
            txtPrecioKG.Enabled = false;
            txtPrecioBase.Enabled = false;
            cbHabilitado.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            txtCodigoRuta.ReadOnly = false;
            habilitarTextBox();

        }

        private void soloLectura()
        {
          
            cbTipoDeServicio.Enabled = false;
            cbOrigen.Enabled = false;
            cbDestino.Enabled = false;
            txtPrecioKG.ReadOnly = true;
            txtPrecioBase.ReadOnly = true;
            cbHabilitado.Enabled = false;
        }

        private void habilitarTextBox()
        {
            txtCodigoRuta.Enabled  = true;
            cbTipoDeServicio.Enabled = true;
            txtPrecioKG.Enabled = true;
            txtPrecioBase.Enabled = true;
            cbHabilitado.Enabled = true;
            cbOrigen.Enabled = true;
            cbDestino.Enabled = true;
        }

        private void btnBajaLogica_Click(object sender, EventArgs e)
        {
            
        }

       

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataGridView.CurrentRow.Cells["Id"].Value);
            this.txtCodigoRuta.Text = Convert.ToString(this.dataGridView.CurrentRow.Cells["Codigo"].Value);
            this.cbTipoDeServicio.SelectedIndex = Convert.ToInt32(this.dataGridView.CurrentRow.Cells["Id_Tipo_Servicio"].Value) - 1;
            this.txtPrecioBase.Text = Convert.ToString(this.dataGridView.CurrentRow.Cells["Precio_base_pasaje"].Value);
            this.txtPrecioKG.Text = Convert.ToString(this.dataGridView.CurrentRow.Cells["Precio_base_kg"].Value);

            string posicioncbOrigen = DAORuta.obtenerCiudad(Convert.ToInt32(this.dataGridView.CurrentRow.Cells["Ciudad_Origen"].Value));
            string posicioncbDestino = DAORuta.obtenerCiudad(Convert.ToInt32(this.dataGridView.CurrentRow.Cells["Ciudad_Destino"].Value));

            if (Convert.ToBoolean(dataGridView.CurrentRow.Cells["habilitada"].Value) == true)
            {
                this.cbHabilitado.SelectedIndex = this.cbHabilitado.FindString("Habilitado");
            }
            else 
            {
                this.cbHabilitado.SelectedIndex = this.cbHabilitado.FindString("Deshabilitado");
            }
 
            this.cbOrigen.SelectedIndex = this.cbOrigen.FindString(posicioncbOrigen);
            this.cbDestino.SelectedIndex = this.cbDestino.FindString(posicioncbDestino);      
        }

        private void habilitarModificacion()
        {
        
            cbTipoDeServicio.Enabled = true;
            cbOrigen.Enabled = true;
            cbDestino.Enabled = true;
            txtPrecioKG.ReadOnly = false;
            txtPrecioBase.ReadOnly = false;
            cbHabilitado.Enabled = true;
        }

        private void cargarComboBox()
        {
            cbOrigen.DataSource = DAORuta.getCiudades().DefaultView;
            cbOrigen.DisplayMember = "Nombre";

            cbDestino.DataSource = DAORuta.getCiudades().DefaultView;
            cbDestino.DisplayMember = "Nombre";

        }

     

        private Ruta cargarAerolineParaEditar()
        {
            return new Ruta(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtCodigoRuta.Text), cbTipoDeServicio.SelectedIndex + 1, cbOrigen.Text, cbDestino.Text, Convert.ToDecimal(txtPrecioKG.Text), Convert.ToDecimal(txtPrecioBase.Text), cbHabilitado.SelectedIndex);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones()) return;
                DAORuta.EditarRuta(cargarAerolineParaEditar());
                MessageBox.Show("La Ruta se modifico correctamente");
                deshabilitarTextBox();
                limpiar();
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                Mostrar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error." + ex.Message);

            }
        }

        private bool Validaciones()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("FALTA AGREGAR EL CAMPO ID");
                return true;
            }

            if (txtCodigoRuta.Text == "")
            {
                MessageBox.Show("FALTA AGREGAR EL CAMPO Codigo de Ruta");
                return true;
            }

            int codigoRuta = Convert.ToInt32(txtCodigoRuta.Text);

            if(codigoRuta < 0)
            {
                MessageBox.Show("El codigo de ruta ingresado no es valido");
                return true;

            }

            if (cbTipoDeServicio.Text == "")
            {
                MessageBox.Show("Establecer Tipo de Servicio");
                return true;

            }

            if (cbOrigen.Text == "")
            {
                MessageBox.Show("Establecer Origen");
                return true;

            }

            if (cbDestino.Text == "")
            {
                MessageBox.Show("Establecer Destino");
                return true;

            }

            if (txtPrecioKG.Text == "")
            {
                MessageBox.Show("Establecer Precio de KG");
                return true;
            }

            decimal PrecioKG = Convert.ToDecimal(txtPrecioKG.Text);

            if (PrecioKG < 0)
            {
                MessageBox.Show("El PrecioKG ingresado no es valido");
                return true;

            }

            if (txtPrecioBase.Text == "")
            {
                MessageBox.Show("Establecer Precio Base");
                return true;
            }

            decimal PrecioBase = Convert.ToDecimal(txtPrecioBase.Text);

            if (PrecioBase < 0)
            {
                MessageBox.Show("El PrecioBase ingresado no es valido");
                return true;

            }

            if (cbHabilitado.SelectedIndex != 0 && cbHabilitado.SelectedIndex != 1)
            {
                MessageBox.Show("Establecer si la ruta se encuentra habilitada");
                return true;

            }

            if (cbOrigen.Text == cbDestino.Text)
            {
                MessageBox.Show("La ciudad origen y la ciudad destino no pueden ser la misma");
                return true;
            }

            return false;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si se desea editar una Ruta siga los siguientes pasos:" + Environment.NewLine +
                                "  ● Hacer clic sobre la ruta a editar y sobre el boton 'Editar'" + Environment.NewLine +
                                "  ● Finalmente sobre el boton 'Guardar'");
        }

        private void txtCodigoRuta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
