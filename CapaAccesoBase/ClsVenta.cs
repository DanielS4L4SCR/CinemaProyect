using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class ClsVenta
    {
        CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
        public DataTable llenarProyec()
        {
            DataTable dtProd;
            dtProd = conecta.ejecutar("Select id_Proyeccion from proyecciones");
            return dtProd;
        }
        public DataTable llenarProduct(int identificacion)
        {
            DataTable dtProd;
            dtProd = conecta.ejecutar("Select id_Proyeccion, Peliculas_idPelicula, idSala, HoraInicio, HoraFinalizacion, FechaEstreno, Precio from proyecciones where id_Proyeccion=" + identificacion + ";");
            return dtProd;
        }

        public DataTable llenarCliente()
        {
            DataTable dtTipoCliente;
            dtTipoCliente = conecta.ejecutar("Select idCliente,Persona_idPersona,TipoCliente_idTipoCliente from cliente");
            return dtTipoCliente;
        }

        public DataTable llenarEmpleado()
        {
            DataTable dtEmpleado;
            dtEmpleado = conecta.ejecutar("Select id_Empleado,Usuario_NombreUsuario,Usuario_Persona_idPersona from empleado");
            return dtEmpleado;
        }

        public DataTable consultaTipoCliente(int cliente)
        {
            DataTable dtTipoCliente;
            dtTipoCliente = conecta.ejecutar("Select TipoCliente_idTipoCliente from cliente where idCliente=" + cliente + "");
            return dtTipoCliente;
        }
        public DataTable consultaUltimaFactura()
        {
            DataTable dtTipoCliente;
            dtTipoCliente = conecta.ejecutar("SELECT MAX(idCliente) FROM cliente;");
            return dtTipoCliente;
        }

        public bool insertarFactura(int idCliente, String idPersona, String fecha, Double montoTotal, int idEmpleado, int idTipoCLiente)
        {
            CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
            return conecta.ejecutarInsert("INSERT INTO factura(Cliente_idCliente, Cliente_Persona_idPersona, FechaVenta, Monto, Empleado_id_Empleado, idTipoCliente)VALUES(" + idCliente + ",'"+idPersona+"','" + fecha + "'," + montoTotal + ","+idEmpleado+","+idTipoCLiente+")");
        }

        public DataTable consultaPromoción(int tipoCliente,int proyeccion)
        {
            DataTable dtPromo;
            dtPromo = conecta.ejecutar("Select idPromocion,Descripcion, PorcentajeDescuento from promocion where TipoCliente_idTipoCliente =" + tipoCliente+ " and Proyecciones_id_Proyeccion = " + proyeccion+"");
            return dtPromo;
        }

        public bool insertarDetalle(int detalle, int factura,int proyeccion,Double precio,int cantidad)
        {
            CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
            return conecta.ejecutarInsert("insert into detalle(idDetalle,Factura_idFactura, Proyecciones_id_Proyeccion, Precio, Cantidad)values("+detalle+"," + factura+"," + proyeccion+","+precio+","+cantidad+")");
        }
    }
}