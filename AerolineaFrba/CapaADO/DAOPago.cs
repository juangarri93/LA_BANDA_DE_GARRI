using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AerolineaFrba.ConstructorDeClases;

namespace AerolineaFrba.CapaADO
{
    class DAOPago : SqlConnector
    {


        public static void AgregarPago(Pago pago)
        {
            executeProcedure("spinsertar_pago", pago.Pnr, pago.Id_viaje, pago.Id_cliente, pago.Importe, pago.Fecha_compra, pago.Tipo_pago);
        }

    }
}
