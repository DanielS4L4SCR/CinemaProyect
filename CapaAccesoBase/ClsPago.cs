using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class ClsPago
    {
        CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
        public DataTable consultaUltimaFactura()
        {
            DataTable dtFactura;
            dtFactura = conecta.ejecutar("SELECT MAX(idFactura) FROM factura");
            return dtFactura;
        }
        public DataTable consultaMontoFactura(int factura)
        {
            DataTable dtFactura;
            dtFactura = conecta.ejecutar("SELECT Monto FROM factura where idFactura="+factura+"");
            return dtFactura;
        }

        public bool insertarPago(int factura, int TipoPago)
        {
            ClsConexion conectar = new ClsConexion(); 
            return conectar.ejecutarInsert("insert into pago (Factura_idFactura, TipoPago_idTipoPago) values ("+factura+","+TipoPago+")");
        }


    }
}
