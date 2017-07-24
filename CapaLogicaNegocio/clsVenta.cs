using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocios
{
    public class clsVenta
    {
        CapaDatos.ClsVenta ventas = new CapaDatos.ClsVenta();
        public DataTable llenarProyec()
        {
            return ventas.llenarProyec();
        }

        public DataTable llenarProducto(int idProyeccion)
        {
            return ventas.llenarProduct(idProyeccion);
        }

        public DataTable llenarCliente()
        {
            return ventas.llenarCliente();
        }

        public DataTable llenarEmpleado()
        {
            return ventas.llenarEmpleado();
        }

        public DataTable consultaTipoCliente(int cliente)
        {
            return ventas.consultaTipoCliente(cliente);
        }
        public DataTable consultaUltimaFactura()
        {
            return ventas.consultaUltimaFactura();
        }
        public DataTable consultaPromo(int tipoCliente, int proyeccion)
        {
            return ventas.consultaPromoción(tipoCliente,proyeccion);
        }
            public bool insertarFactura(int idCliente, String idPersona, String fecha, Double montoTotal, int idEmpleado, int idTipoCliente)
        {
            return ventas.insertarFactura(idCliente, idPersona, fecha, montoTotal, idEmpleado, idTipoCliente);
        }

        public bool insertarDetalle(int detalle,int factura, int proyeccion, Double precio, int cantidad)
        {
            return ventas.insertarDetalle(detalle,factura, proyeccion, precio, cantidad);
        }
    }
}
