using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.Herramientas;
using AerolineaFrba.ConstructorDeClases;


namespace AerolineaFrba.ABM_Compra
{
    public partial class Butacas : Form
    {
        Compra _compraActual;
        
        public Butacas(Compra compraActual)
        {
            this._compraActual = compraActual;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ventanaDatosUsuario = new DatosCompra(_compraActual);
            FormsHerramientas.mostrarVentanaNueva(ventanaDatosUsuario, this);
        }

        private void btnPago_Click(object sender, EventArgs e)
        {

        }

      

       

        
    }
}
