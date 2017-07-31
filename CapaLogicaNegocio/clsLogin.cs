using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsLogin
    {
        public DataTable login(String user, String password)
        {
            return new CapaDatos.ClsLogin().CargarDatos(user, password);
        }
        public DataTable TipoUsuario(String user)
        {
            return new CapaDatos.ClsLogin().CargarTipoUsuario(user);
        }
    }
}
