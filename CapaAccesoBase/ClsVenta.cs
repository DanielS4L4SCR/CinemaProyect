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
            dtProd = conecta.ejecutar("Select id_Proyeccion, Peliculas_idPelicula, idSala, HoraInicio, HoraFinalizacion,FechaProyeccion,Precio from proyecciones where id_Proyeccion=" + identificacion + " and Activo=1;");
            return dtProd;
        }

        public DataTable llenarCliente()
        {
            DataTable dtTipoCliente;
            dtTipoCliente = conecta.ejecutar("Select idCliente,Persona_idPersona,TipoCliente_idTipoCliente from cliente where Activo=1");
            return dtTipoCliente;
        }

        public DataTable llenarEmpleado()
        {
            DataTable dtEmpleado;
            dtEmpleado = conecta.ejecutar("Select id_Empleado,Usuario_NombreUsuario,Usuario_Persona_idPersona from empleado where Activo=1");
            return dtEmpleado;
        }

        public DataTable consultaTipoCliente(int cliente)
        {
            DataTable dtTipoCliente;
            dtTipoCliente = conecta.ejecutar("Select TipoCliente_idTipoCliente from cliente where idCliente=" + cliente + " and Activo=1");
            return dtTipoCliente;
        }
        public DataTable consultaUltimaFactura()
        {
            DataTable dtTipoCliente;
            dtTipoCliente = conecta.ejecutar("SELECT MAX(idFactura) FROM factura");
            return dtTipoCliente;
        }
        public DataTable cargaPrecios(int proyeccion)
        {
            DataTable dtPrecios;
            dtPrecios = conecta.ejecutar("SELECT (Precio) FROM proyecciones where id_Proyeccion=" +proyeccion+ " and Activo=1");
            return dtPrecios;
        }
        public bool insertarFactura(int idCliente, String idPersona, String fecha, Double montoTotal, int idEmpleado, int idTipoCLiente)
        {
            CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
            return conecta.ejecutarInsert("INSERT INTO factura(Cliente_idCliente, Cliente_Persona_idPersona, FechaVenta, Monto, Empleado_id_Empleado, idTipoCliente)VALUES(" + idCliente + ",'"+idPersona+"','" + fecha + "'," + montoTotal + ","+idEmpleado+","+idTipoCLiente+")");
        }

        public DataTable consultaPromoción(int tipoCliente,int proyeccion)
        {
            DataTable dtPromo;
            dtPromo = conecta.ejecutar("Select idPromocion,Descripcion, PorcentajeDescuento from promocion where TipoCliente_idTipoCliente =" + tipoCliente+ " and Proyecciones_id_Proyeccion = " + proyeccion+ " and Activo=1");
            return dtPromo;
        }
        public DataTable consultaSalas(int proyeccion)
        {
            DataTable dtSala;
            dtSala = conecta.ejecutar("Select idSala from proyecciones where id_Proyeccion =" + proyeccion + " and Activo=1");
            return dtSala;
        }
        public DataTable consultaAsientos(String sala)
        {
            DataTable dtSala;
            dtSala = conecta.ejecutar("Select idAsiento from asiento where id_Sala = '" + sala + "' and Activo=1");
            return dtSala;
        }
        public bool insertarDetalle(int factura,int proyeccion,Double precio,String asiento)
        {
            CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
            return conecta.ejecutarInsert("insert into detalle(Factura_idFactura, Proyecciones_id_Proyeccion, Precio, idAsiento)values(" + factura+"," + proyeccion+","+precio+",'"+asiento+"')");
        }
    }
}