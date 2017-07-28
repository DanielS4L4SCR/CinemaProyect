using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocios
{
    public class clsPago
    {
        CapaDatos.ClsPago pago = new CapaDatos.ClsPago();
        public DataTable consultaUltimaFactura()
        {
            return pago.consultaUltimaFactura();
        }

        public DataTable consultaMontoFactura(int factura)
        {
            return pago.consultaMontoFactura(factura);
        }
        public bool insertarPago(int factura, int TipoPago)
        {
            return new CapaDatos.ClsPago().insertarPago(factura,TipoPago);
        }
    }
}
