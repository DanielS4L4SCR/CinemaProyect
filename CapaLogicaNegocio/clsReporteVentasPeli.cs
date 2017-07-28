using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class clsReporteVentasPeli
    {
        CapaDatos.ClsReporteVentasPeli peliculas = new CapaDatos.ClsReporteVentasPeli();
        public DataTable consultaPeliculas()
        {
            return peliculas.consultaPeliculas();
        }
        public DataTable consultaTotalPeliculas(int pelicula)
        {
            return peliculas.consultaTotalPeliculas(pelicula);
        }
    }
}
