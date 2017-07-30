using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class ClsInhabilitador
    {
        CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
        
        public DataTable CargarPersona()
        {
            DataTable dtPersona;
            dtPersona = conecta.ejecutar("Select idPersona from persona");
            return dtPersona;
        }
        public DataTable CargarCliente()
        {
            DataTable dtTipoCliente;
            dtTipoCliente = conecta.ejecutar("Select Persona_idPersona from cliente");
            return dtTipoCliente;
        }

        public DataTable CargarEmpleado()
        {
            DataTable dtEmpleado;
            dtEmpleado = conecta.ejecutar("Select Usuario_Persona_idPersona from empleado");
            return dtEmpleado;
        }
        public DataTable cargarPromoción()
        {
            DataTable dtPromo;
            dtPromo = conecta.ejecutar("Select idPromocion from promocion");
            return dtPromo;
        }
        public DataTable cargarSala()
        {
            DataTable dtSala;
            dtSala = conecta.ejecutar("Select idSala from sala");
            return dtSala;
        }
        public DataTable cargarTipoSala()
        {
            DataTable dtSala;
            dtSala = conecta.ejecutar("Select idTipoSala, Descripcion from tiposala");
            return dtSala;
        }
        public DataTable CargarProyec()
        {
            DataTable dtProd;
            dtProd = conecta.ejecutar("Select id_Proyeccion from proyecciones");
            return dtProd;
        }
        public DataTable cargarTipoPelicula()
        {   
            DataTable dtTipoPeli;
            dtTipoPeli = conecta.ejecutar("Select idTipoPelicula,Descripcion from tipopelicula");
            return dtTipoPeli;
        }
        public DataTable cargarPelicula()
        { 
            DataTable dtPeli;
            dtPeli = conecta.ejecutar("Select Nombre from peliculas");
            return dtPeli;
        }
        public DataTable cargarGeneroPeli()
        {  
            DataTable dtPeli;
            dtPeli = conecta.ejecutar("Select idGenero, Descripcion from generopelicula");
            return dtPeli;
        }

        public DataTable cargarTipoPago()
        {
            DataTable dtPago;
            dtPago = conecta.ejecutar("Select idTipoPago, Descripcion from tipopago");
            return dtPago;
        }
        public DataTable cargarUsuario()
        {
            DataTable dtUsuario;
            dtUsuario = conecta.ejecutar("Select NombreUsuario from usuario");
            return dtUsuario;
        }
        public bool estadoPersona(int activo,String idpersona)
        {
            bool estadoPersona = conecta.ejecutarInsert("Update persona Set Activo = "+activo+" Where idPersona = '"+idpersona+"'");
            if (estadoPersona)
            {
                return true;
            }
            return false;
        }
        public bool estadoCliente(int activo, String idCliente)
        {
            bool estadoCliente = conecta.ejecutarInsert("Update cliente Set Activo = " + activo + " Where Persona_idPersona = '" + idCliente + "'");
            if (estadoCliente)
            {
                return true;
            }
            return false;
        }
        public bool estadoEmpleado(int activo, String idEmpleado)
        {
            bool estadoEmpleado = conecta.ejecutarInsert("Update empleado Set Activo = " + activo + " Where Usuario_Persona_idPersona = '" + idEmpleado + "'");
            if (estadoEmpleado)
            {
                return true;
            }
            return false;
        }
        public bool estadoCorreo(int activo, String idPersona)
        {
            bool estadoCorreo = conecta.ejecutarInsert("Update correo Set Activo = " + activo + " Where Persona_idPersona = '" + idPersona + "'");
            if (estadoCorreo)
            {
                return true;
            }
            return false;
        }
        public bool estadoDireccion(int activo, String idPersona)
        {
            bool estadoDireccion = conecta.ejecutarInsert("Update direccion Set Activo = " + activo + " Where Persona_idPersona = '" + idPersona + "'");
            if (estadoDireccion)
            {
                return true;
            }
            return false;
        }
        public bool estadoTelefono(int activo, String idPersona)
        {
            bool estadoTelefono = conecta.ejecutarInsert("Update telefono Set Activo = " + activo + " Where Persona_idPersona = '" + idPersona + "'");
            if (estadoTelefono)
            {
                return true;
            }
            return false;
        }
        public bool estadoPelicula(int activo, String pelicula)
        {
            bool estadoPelicula = conecta.ejecutarInsert("Update peliculas Set Activo = " + activo + " Where Nombre = '" + pelicula + "'");
            if (estadoPelicula)
            {
                return true;
            }
            return false;
        }
        public bool estadoTipoPelicula(int activo, int TipoPelicula)
        {
            bool estadoTipoPelicula = conecta.ejecutarInsert("Update tipopelicula Set Activo = " + activo + " Where idTipoPelicula = " + TipoPelicula + "");
            if (estadoTipoPelicula)
            {
                return true;
            }
            return false;
        }
        public bool GeneroPelicula(int activo, int generoPelicula)
        {
            bool GeneroPelicula = conecta.ejecutarInsert("Update generopelicula Set Activo = " + activo + " Where idGenero = " + generoPelicula + "");
            if (GeneroPelicula)
            {
                return true;
            }
            return false;
        }
        public bool estadoProyeccion(int activo, int proyeccion)
        {
            bool estadoProyeccion = conecta.ejecutarInsert("Update proyecciones Set Activo = " + activo + " Where id_Proyeccion= " + proyeccion + "");
            if (estadoProyeccion)
            {
                return true;
            }
            return false;
        }
        public bool estadoSala(int activo, String Sala)
        {
            bool estadoSala = conecta.ejecutarInsert("Update sala Set Activo = " + activo + " Where idSala= '" + Sala + "'");
            if (estadoSala)
            {
                return true;
            }
            return false;
        }

        public bool estadoTipoSala(int activo, int TipoSala)
        {
            bool estadoTipoSala = conecta.ejecutarInsert("Update tiposala Set Activo = " + activo + " Where idTipoSala= " + TipoSala + "");
            if (estadoTipoSala)
            {
                return true;
            }
            return false;
        }

        public bool estadoTipoPago(int activo, int pago)
        {
            bool estadoTipoPago = conecta.ejecutarInsert("Update tipopago Set Activo = " + activo + " Where idTipoPago= " + pago + "");
            if (estadoTipoPago)
            {
                return true;
            }
            return false;
        }

        public bool estadoUsuario(int activo, String usuario)
        {
            bool estadoTipoPago = conecta.ejecutarInsert("Update usuario Set Activo = " + activo + " Where NombreUsuario= '" + usuario+ "'");
            if (estadoTipoPago)
            {
                return true;
            }
            return false;
        }
    }
}
