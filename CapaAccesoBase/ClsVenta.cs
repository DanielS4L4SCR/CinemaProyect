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

        public bool insertarFactura(int idFactura,int proyeccion, int idCliente, String nombCliente, String fecha, Double montoTotal, int idEmpleado, int idTipoCLiente, Double montoProyeccion, int cantidadBoletos)
        {
            bool creandoFact, creandoDetalle;
            creandoFact = conecta.ejecutarInsert("insert into factura(Cliente_idCliente, Cliente_Persona_idPersona, FechaVenta, Monto, Empleado_id_Empleado, tipoPersona_idTipoPersona) values("+idFactura+", "+idCliente+", '"+fecha+"', "+montoTotal+", "+idEmpleado+", "+idTipoCLiente+")");
            creandoDetalle = conecta.ejecutarInsert("insert into detalle(Factura_idFactura,Proyecciones_id_Proyeccion,Precio,Cantidad) values ("+idFactura+","+proyeccion+","+montoProyeccion+","+cantidadBoletos+")");
            if (creandoFact && creandoDetalle)
            {
                return true;
            }
            return false;
        }
    }
}