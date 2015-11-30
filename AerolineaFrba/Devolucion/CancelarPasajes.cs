using System;
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

namespace AerolineaFrba.Devolucion
{
    public partial class CancelarPasajes : Form
    {
        public CancelarPasajes(Cancelacion cancelacion)
        {
          
            InitializeComponent();
            dtButacasCompradas.DataSource = DAOCancelacion.getButacas(cancelacion);
        }
    }
}
