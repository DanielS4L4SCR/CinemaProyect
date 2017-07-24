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

        public bool insertarFactura(int idFactura, int proyeccion, int idCliente, String nombCliente, String fecha, Double montoTotal, int idEmpleado, int idTipoCLiente, Double montoProyeccion, int cantidadBoletos)
        {
            return ventas.insertarFactura(idFactura,proyeccion,idCliente,nombCliente,fecha,montoTotal,idEmpleado,idTipoCLiente,montoProyeccion,cantidadBoletos);
        }
    }
}
