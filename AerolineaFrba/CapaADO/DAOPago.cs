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
            executeProcedure("spinsertar_pago", pago.Pnr, pago.Id_viaje, pago.Id_cliente , pago.ImportePasaje,  pago.Fecha_compra, pago.Tipo_pago);
        }

        public static void AgregarPagoEncomienda(Pago pago)
        {
            executeProcedure("spinsertar_pago", pago.Pnr, pago.Id_viaje, pago.Id_cliente ,   pago.ImporteEncomienda, pago.Fecha_compra, pago.Tipo_pago);
        }

    }
}
