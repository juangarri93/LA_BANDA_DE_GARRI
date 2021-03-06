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

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class ABMCiudadAlta : Form
    {
        ABMCiudad ciudad;

        public ABMCiudadAlta(ABMCiudad Ciudad)
        {
            InitializeComponent();
            ciudad = Ciudad;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            
            try
            {

                if (Validaciones()) return;
                DAOCiudad.AgregarCiudad(CargarCiudad());
                MessageBox.Show("La Ciudad se agregó correctamente.");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error." + ex.Message);
            }
        }

        private bool Validaciones()
        {

            if (textNombre.Text == "")
            {
                MessageBox.Show("NO INGRESO NOMBRE");
                return true;

            }
            if (cbHabilitado.SelectedIndex != 0 && cbHabilitado.SelectedIndex != 1)
            {
                MessageBox.Show("Establecer si la ciudad se encuentra habilitada");
                return true;

            }

          

            return false;
        }

        
        private Ciudad CargarCiudad() 
        {
            
            Boolean var = true;

            if (cbHabilitado.SelectedIndex == 1) var = true;

            else var = false;


            return new Ciudad(1, textNombre.Text,var);
                                 
        }

        private void limpiar()
        {
          
            textNombre.Text = "";

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void ABMCiudadAlta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cbHabilitado.Items.Add("Deshabilitado");
            cbHabilitado.Items.Add("Habilitado");
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            ciudad.Focus();
            this.Hide();
        }

       
    }


      
}
