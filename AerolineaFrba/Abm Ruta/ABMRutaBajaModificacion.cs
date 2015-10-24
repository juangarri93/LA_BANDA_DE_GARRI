﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            limpiar();
        }

        public void limpiar()
        {

            txtTipoServicio.Text = "";
            cbOrigen.ValueMember = null;
            cbDestino.ValueMember = null;
            txtPrecioKG.Text = "";
            txtPrecioBase.Text = "";
        }
    }
}