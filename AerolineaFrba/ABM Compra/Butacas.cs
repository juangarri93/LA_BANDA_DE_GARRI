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
using AerolineaFrba.CapaADO;
using AerolineaFrba.ConstructorDeClases;


namespace AerolineaFrba.ABM_Compra
{
    public partial class Butacas : Form
    {
        Compra _compraActual;
        int restan = 0;
        int restanEnco = 0;
              
        List<Butaca> listaDeButacasLibres;
        List<Butaca> listaDeSeleccionadas;
        DataTable butacas;

        public Butacas(Compra compraActual)
        {
            
            this._compraActual = compraActual;
            restan = _compraActual.CantidadPasajes;
            restanEnco = _compraActual.CantidadKG;
            butacas = DAOButaca.ButacasLibres(this._compraActual.ViajeSeleccionado);
            CrearListaDeButacasLibres();
            listaDeSeleccionadas = new List<Butaca>();
            
            InitializeComponent();
            
        }

        private void CrearListaDeButacasLibres()
        {


            listaDeButacasLibres = new List<Butaca>(butacas.Rows.Count);

            foreach (DataRow row in butacas.Rows)
            {
            
                var values = row.ItemArray;
                Butaca butaca = new Butaca();
                butaca.Id = (int)values[0];
                butaca.Numero = (decimal)values[1];
                butaca.Piso = (decimal)values[3];
                butaca.Tipo = (int)values[2];
                butaca.Aeronave_id = (int)values[4];



                this.listaDeButacasLibres.Add(butaca);
            }
           
         
        }

        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }



        private void Butacas_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = butacas;
            comboBox1.DisplayMember = "Nro";
            comboBox1.ValueMember = "Id";
          
        }


        private void btnPago_Click(object sender, EventArgs e)
        {
              label5.Text = "Restan seleccionar: " + Convert.ToString(restan);
            if (listaDeButacasLibres != null)
            {
                Butaca seleccionada = listaDeButacasLibres.Find(c => (c.Numero == Convert.ToDecimal(comboBox1.Text)));
                if (seleccionada != null)
                {
                    label2.Text = "Tipo: " + Convert.ToString(seleccionada.Tipo);
                    label4.Text = "Piso: " + Convert.ToString(seleccionada.Piso);

                    label5.Text = "Restan seleccionar: " + Convert.ToString(restan);
                    this.listaDeSeleccionadas.Add(seleccionada);
                   // DAOButaca.MarcarComoOcupada(seleccionada);
                    this.CrearListaDeButacasLibres();
                   
                    if (restan > 0)
                    {
                        this.restan--;
                        label5.Text = "Restan seleccionar: " + Convert.ToString(restan);
                        
                    }
                    else
                    {
                        label5.Text = "Ya no quedan butacas por seleccionar.";
                        
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentran vuelos disponibles");
                    return;
                }
            }
        }

        private void limpiar()
        {
            label2.Text = "Tipo: ";
            label4.Text = "Piso: "  ;

            label5.Text = "Restan seleccionar: " + Convert.ToString(restan);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (listaDeSeleccionadas.Count()!=0)
            {
                _compraActual.ButacasSeleccionadas = listaDeSeleccionadas;
                this.Hide();
                var ventanafin = new DatosCompra(_compraActual);
                FormsHerramientas.mostrarVentanaNueva(ventanafin, this);
            }
            else
            {
                MessageBox.Show("No se han seleccionado butacas");
                return;
            }
        }

        

       

        
    }
}
