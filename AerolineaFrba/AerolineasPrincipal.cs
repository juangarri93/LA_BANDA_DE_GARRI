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
using AerolineaFrba.Registro_Llegada_Destino;
using AerolineaFrba.Consulta_Millas;
using AerolineaFrba.Listado_Estadistico;
using AerolineaFrba.Devolucion;

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
            btnABMAronaves.Enabled = false;
            btnABMRol.Enabled = false;
            btnABM_Ciudad.Enabled = false;
            btnABMRutaAerea.Enabled = false;
            btn_canjear_millas.Enabled = false;
            btn_consulta_millas.Enabled = false;
            btnEstadist.Enabled = false;
            btnRegistrosDeUsuarios.Enabled = false;
            btnGenerarViaje.Enabled = false;
            btnRegistroDeLlegadaDestino.Enabled = false;
            btnCompra.Enabled = false;
            btnCancelacion.Enabled = false;

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
            var nuevaVentanaRegistroDeLLegada = new Registro();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaRegistroDeLLegada, this);
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
            LoginWindow login = new LoginWindow(this);
            login.Show();
        }

        private void btn_consulta_millas_Click(object sender, EventArgs e)
        {
            var nuevaVentanaCalcMillas = new ConsultaMillas();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaCalcMillas, this);
        }

        private void btn_canjear_millas_Click(object sender, EventArgs e)
        {
            var nuevaVentanaCanjearMillas = new CanjeMillas();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaCanjearMillas, this);
        }

        private void btnEstadist_Click(object sender, EventArgs e)
        {
            var nuevaVentanaEstad = new ListadoEstadistico();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaEstad, this);
        }

        private void btnCancelacion_Click(object sender, EventArgs e)
        {
            var nuevaVentanaDevolucion = new DevolucionOpciones();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaDevolucion, this);
        }



        public void actualizaBotones(List<int> list)
        {
            foreach (var valor in list) 
            {
                switch (valor) 
                {
                    case 1: btnABMRol.Enabled = true;
                        break;

                    case 3: btnRegistrosDeUsuarios.Enabled = true;
                        break;

                    case 4: btnABM_Ciudad.Enabled = true;
                        break;

                    case 5: btnABMRutaAerea.Enabled = true;
                        break;

                    case 6: btnABMAronaves.Enabled = true;
                        break;

                    case 7: btnGenerarViaje.Enabled = true;
                        break;

                    case 8: btnRegistroDeLlegadaDestino.Enabled = true;
                        break;

                    case 9: btnCompra.Enabled = true;
                        break;

                    case 10: btnCancelacion.Enabled = true;
                        break;

                    case 11: btn_consulta_millas.Enabled = true;
                        break;

                    case 12: btn_canjear_millas.Enabled = true;
                        break;

                    case 13: btnEstadist.Enabled = true;
                        break;
                }
            }
        }
    }
}
