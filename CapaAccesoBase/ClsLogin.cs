using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaDatos
{
    public class ClsLogin
    {
        public DataTable CargarDatos(String user, String password)
        {
            CapaDatos.ClsConexion conexion = new ClsConexion();
            DataTable dtUsarios;

            dtUsarios = conexion.ejecutar("Select NombreUsuario from Usuario where NombreUsuario='" + user + "' and Contraseña='" + password + "' and Activo=1");
            return dtUsarios;
        }
        public DataTable CargarTipoUsuario(String user)
        {
            CapaDatos.ClsConexion conexion = new ClsConexion();
            DataTable dtUsarios;

            dtUsarios = conexion.ejecutar("Select NombreUsuario,TipoUsuario_idTipoUsuario from Usuario where NombreUsuario='" + user + "'");
            return dtUsarios;
        }
    }
}
