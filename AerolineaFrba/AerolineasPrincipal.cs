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
            btnABMAronaves.Visible = false;
            btnABMRol.Visible = false;
            btnABM_Ciudad.Visible = false;
            btnABMRutaAerea.Visible = false;
            //btn_canjear_millas.Visible = false;
            //btn_consulta_millas.Visible = false;
            btnEstadist.Visible = false;
            btnRegistrosDeUsuarios.Visible = false;
            btnGenerarViaje.Visible = false;
            btnRegistroDeLlegadaDestino.Visible = false;
            //btnCompra.Visible = false;
            btnCancelacion.Visible = false;
            linkLabel2.Enabled = false;

        }

        private void btnABM_Rol_Click(object sender, EventArgs e)
        {
            var nuevaVentanaRol = new ABMRol(this);
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaRol, this);
        }

        private void btnABM_Aeronaves_Click(object sender, EventArgs e)
        {
            var nuevaVentanaAeronaves = new ABMAeronave(this);
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaAeronaves, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevaVentanaCiudad = new ABMCiudad(this);
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaCiudad, this);
        }

        private void btnABMRutaAerea_Click(object sender, EventArgs e)
        {
            var nuevaVentanaRutaArea = new ABMRuta(this);
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaRutaArea, this);
        }

        private void btnGenerarViaje_Click(object sender, EventArgs e)
        {

            var nuevaVentanaGenerarViae = new GenerarViaje();
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaGenerarViae, this);

        }

        private void btnRegistrosDeUsuarios_Click(object sender, EventArgs e)
        {
            var nuevaVentanaRegistroUsuarios = new ABMUsuario(this);
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
            var nuevaVentanaDevolucion = new DevolucionOpciones(this);
            FormsHerramientas.mostrarVentanaNueva(nuevaVentanaDevolucion, this);
        }



        public void actualizaBotones(List<int> list)
        {
            foreach (var valor in list) 
            {
                switch (valor) 
                {
                    case 1: btnABMRol.Visible = true;
                        break;

                    case 3: btnRegistrosDeUsuarios.Visible = true;
                        break;

                    case 4: btnABM_Ciudad.Visible = true;
                        break;

                    case 5: btnABMRutaAerea.Visible = true;
                        break;

                    case 6: btnABMAronaves.Visible = true;
                        break;

                    case 7: btnGenerarViaje.Visible = true;
                        break;

                    case 8: btnRegistroDeLlegadaDestino.Visible = true;
                        break;

                    case 9: btnCompra.Visible = true;
                        break;

                    case 10: btnCancelacion.Visible = true;
                        break;

                    case 11: btn_consulta_millas.Visible = true;
                        break;

                    case 12: btn_canjear_millas.Visible = true;
                        break;

                    case 13: btnEstadist.Visible = true;
                        break;


                }
            }

            linkLabel1.Enabled = false;
            linkLabel2.Enabled = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            MessageBox.Show("SU SESION FUE FINALIZADA, GRACIAS POR USAR NUESTRO SERVICIO");

            btnABMAronaves.Visible = false;
            btnABMRol.Visible = false;
            btnABM_Ciudad.Visible = false;
            btnABMRutaAerea.Visible = false;
            //btn_canjear_millas.Visible = false;
            //btn_consulta_millas.Visible = false;
            btnEstadist.Visible = false;
            btnRegistrosDeUsuarios.Visible = false;
            btnGenerarViaje.Visible = false;
            btnRegistroDeLlegadaDestino.Visible = false;
            //btnCompra.Visible = false;
            btnCancelacion.Visible = false;

            linkLabel1.Enabled = true;
            linkLabel2.Enabled = false;
        }
    }
}
