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
        int kgsDisponibles;
        DataTable butacas;
        string kgComprados = "";
        string CantidadPasajes = "";

        public Butacas(Compra compraActual)
        {
            CantidadPasajes = Convert.ToString(compraActual.CantidadPasajes);
            kgComprados = Convert.ToString(compraActual.CantidadKG);
            this._compraActual = compraActual;
            restan = _compraActual.CantidadPasajes;
            restanEnco = _compraActual.CantidadKG;
            butacas = DAOButaca.ButacasLibres(compraActual.ViajeSeleccionado);
            kgsDisponibles = DAOViaje.getKgDisponibles(this._compraActual.ViajeSeleccionado);
            CrearListaDeButacasLibres();
            listaDeSeleccionadas = new List<Butaca>();
            
            InitializeComponent();
            this.btnFin.Enabled = false;
            if (compraActual.CantidadPasajes == 0)
            {
                this.checkedListBox1.Enabled = false;
            }
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
            this.checkedListBox1.DataSource = butacas;
            checkedListBox1.DisplayMember = "Nro";
            checkedListBox1.ValueMember = "Id";

            label5.Text = "Restan seleccionar: " + CantidadPasajes + "pasajes";
            label3.Text = "Restan seleccionar: " + kgComprados +"kgs";
            KgDisp.Text = "Kg disponibles: " + kgsDisponibles;

        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            
            //label5.Text = "Restan seleccionar: " + Convert.ToString(restan);
            //KgDisp.Text = "Kg disponibles: " + Convert.ToString(kgsDisponibles);
            if (listaDeButacasLibres != null && this._compraActual.CantidadKG <= kgsDisponibles)
            {

                CrearListaDeButacasLibres();
                var lista = checkedListBox1.CheckedIndices.Cast<int>().ToList();

                foreach (int butaquita in lista)
                {
                    this.listaDeSeleccionadas.Add(this.listaDeButacasLibres.ElementAt(butaquita));
                   

                }

                if (listaDeSeleccionadas.Count() > _compraActual.CantidadPasajes)
                {
                    MessageBox.Show("La Cantidad de butacas solicitadas excede a la compra actual,seleccione la cantidad correspondiente");
                    return;
                }

                if (listaDeSeleccionadas.Count() < _compraActual.CantidadPasajes)
                {
                    MessageBox.Show("La Cantidad de butacas solicitadas es menor a la compra actual,seleccion la cantidad correspondiente");
                    return;
                }

                else
                {
                    label5.Text = "Restan seleccionar: 0 pasajes";

                
                    label3.Text = "Restan seleccionar: 0 kgs";
                    KgDisp.Text = "Kg disponibles: " + Convert.ToString(kgsDisponibles - this._compraActual.CantidadKG);

                    MessageBox.Show("Ha finalizado la selección, ya puede realizar el Pago");
                    this.btnFin.Enabled = true;
                    return;
                }


            }
           
            else
            {
                MessageBox.Show("No se encuentran vuelos disponibles");
                return;
            }

        }

      /*  private void btnSeleccion_Click(object sender, EventArgs e)
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
                   DAOButaca.MarcarComoOcupada(seleccionada);
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


        */
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
            if (_compraActual.CantidadKG!=0 || listaDeSeleccionadas.Count()!=0)
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
