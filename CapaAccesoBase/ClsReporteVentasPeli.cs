using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class ClsReporteVentasPeli
    {
        ClsConexion conecta = new ClsConexion();
        public DataTable consultaPeliculas()
        {
            DataTable dtPeliculas;
            dtPeliculas = conecta.ejecutar("Select idPelicula, Nombre from peliculas");
            return dtPeliculas;
        }
        public DataTable consultaTotalPeliculas(int pelicula)
        {
            DataTable dtPeliculas;
            dtPeliculas = conecta.ejecutar("select count(*) From proyecciones P inner Join detalle D  on P.id_Proyeccion = D.Proyecciones_id_Proyeccion where Peliculas_idPelicula="+pelicula+"");
            return dtPeliculas;
        }
    }
}
