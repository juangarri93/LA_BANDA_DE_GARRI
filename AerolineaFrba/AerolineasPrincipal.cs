using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Abm_Aeronave;
using AerolineaFrba.Abm_Rol;
using AerolineaFrba.Abm_Ciudad;
using AerolineaFrba.Abm_Ruta;
using AerolineaFrba.Canje_Millas;
using AerolineaFrba.Herramientas;
using AerolineaFrba.Registro_de_Usuario;
using AerolineaFrba.Generacion_Viaje;
using AerolineaFrba.Abm_Compra;
using AerolineaFrba.Login;
using AerolineaFrba.Consulta_Millas;

namespace AerolineaFrba
{
    public partial class AerolineasPrincipal : Form
    {
        public AerolineasPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnABM_Rol_Click(object sender, EventArgs e)
        {
            var nuevaVentanaRol = new ABMRol();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaRol, this);
        }

        private void btnABM_Aeronaves_Click(object sender, EventArgs e)
        {
            var nuevaVentanaAeronaves = new ABMAeronave();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaAeronaves, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevaVentanaCiudad = new ABMCiudad();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaCiudad, this);
        }

        private void btnABMRutaAerea_Click(object sender, EventArgs e)
        {
            var nuevaVentanaRutaArea = new ABMRuta();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaRutaArea, this);
        }

        private void btnGenerarViaje_Click(object sender, EventArgs e)
        {

            var nuevaVentanaGenerarViae = new GenerarViaje();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaGenerarViae, this);

        }

        private void btnRegistrosDeUsuarios_Click(object sender, EventArgs e)
        {
            var nuevaVentanaRegistroUsuarios = new ABMUsuario();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaRegistroUsuarios, this);
        }

        private void btnRegistroDeLlegadaDestino_Click(object sender, EventArgs e)
        {

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            var nuevaVentanaCompra = new AltaCompra();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaCompra, this);
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
        }

        private void btn_consulta_millas_Click(object sender, EventArgs e)
        {
            var nuevaVentanaCalcMillas = new ConsultaMillas();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaCalcMillas, this);
        }

       
    }
}
