using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class ClsPeliculas
    {
        ClsConexion conect = new ClsConexion();
        public DataTable cargarTipoPelicula()
        {
            DataTable dtTipoPeli;
            dtTipoPeli = conect.ejecutar("Select idTipoPelicula,Descripcion from tipopelicula");
            return dtTipoPeli;
        }
        public DataTable cargarGenPelicula()
        {
            DataTable dtGenPeli;
            dtGenPeli = conect.ejecutar("Select idGenero,Descripcion from generopelicula");
            return dtGenPeli;
        }

    }
}
