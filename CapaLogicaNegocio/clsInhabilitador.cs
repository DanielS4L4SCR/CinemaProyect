using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocios
{
    public class clsInhabilitador
    {
        public DataTable CargarPersona()
        {
            return new CapaDatos.ClsInhabilitador().CargarPersona();
        }

        public DataTable CargarCliente()
        {
            return new CapaDatos.ClsInhabilitador().CargarCliente();
        }
        public DataTable CargarEmpleado()
        {
            return new CapaDatos.ClsInhabilitador().CargarEmpleado();
        }
        public DataTable cargarPromoción()
        {
            return new CapaDatos.ClsInhabilitador().cargarPromoción();
        }
        public DataTable cargarSala()
        {
            return new CapaDatos.ClsInhabilitador().cargarSala();
        }

        public DataTable cargarTipoSala()
        {
            return new CapaDatos.ClsInhabilitador().cargarTipoSala();
        }

        public DataTable CargarProyec()
        {
            return new CapaDatos.ClsInhabilitador().CargarProyec();
        }

        public DataTable cargarTipoPelicula()
        {
            return new CapaDatos.ClsInhabilitador().cargarTipoPelicula();
        }
        public DataTable cargarPelicula()
        {
            return new CapaDatos.ClsInhabilitador().cargarPelicula();
        }

        public DataTable cargarGeneroPeli()
        {
            return new CapaDatos.ClsInhabilitador().cargarGeneroPeli();
        }

        public DataTable cargarTipoPago()
        {
            return new CapaDatos.ClsInhabilitador().cargarTipoPago();
        }

        public DataTable cargarUsuario()
        {
            return new CapaDatos.ClsInhabilitador().cargarUsuario();
        }

        public bool estadoPersona(int activo, String idpersona)
        {
            return new CapaDatos.ClsInhabilitador().estadoPersona(activo, idpersona);
        }

        public bool estadoCliente(int activo, String idCliente)
        {
            return new CapaDatos.ClsInhabilitador().estadoCliente(activo, idCliente);
        }
        public bool estadoEmpleado(int activo, String idEmpleado)
        {
            return new CapaDatos.ClsInhabilitador().estadoEmpleado(activo, idEmpleado);
        }

        public bool estadoCorreo(int activo, String idPersona)
        {
            return new CapaDatos.ClsInhabilitador().estadoCorreo(activo, idPersona);
        }
        public bool estadoDireccion(int activo, String idPersona)
        {
            return new CapaDatos.ClsInhabilitador().estadoDireccion(activo, idPersona);
        }
        public bool estadoTelefono(int activo, String idPersona)
        {
            return new CapaDatos.ClsInhabilitador().estadoTelefono(activo, idPersona);
        }
        public bool estadoPelicula(int activo, String pelicula)
        {
            return new CapaDatos.ClsInhabilitador().estadoPelicula(activo, pelicula);
        }
        public bool estadoTipoPelicula(int activo, int TipoPelicula)
        {
            return new CapaDatos.ClsInhabilitador().estadoTipoPelicula(activo, TipoPelicula);
        }
        public bool GeneroPelicula(int activo, int generoPelicula)
        {
            return new CapaDatos.ClsInhabilitador().GeneroPelicula(activo, generoPelicula);
        }
        public bool estadoProyeccion(int activo, int proyeccion)
        {
            return new CapaDatos.ClsInhabilitador().estadoProyeccion(activo, proyeccion);
        }
        public bool estadoSala(int activo, String Sala)
        {
            return new CapaDatos.ClsInhabilitador().estadoSala(activo, Sala);
        }

        public bool estadoTipoSala(int activo, int TipoSala)
        {
            return new CapaDatos.ClsInhabilitador().estadoTipoSala(activo, TipoSala);
        }

        public bool estadoTipoPago(int activo, int pago)
        {
            return new CapaDatos.ClsInhabilitador().estadoTipoPago(activo, pago);
        }

        public bool estadoUsuario(int activo, String usuario)
        {
            return new CapaDatos.ClsInhabilitador().estadoUsuario(activo, usuario);
        }
    }
}
