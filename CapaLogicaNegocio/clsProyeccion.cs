using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocios
{
    public class clsProyeccion
    {
        public bool insertarProyeccion(String Sala, int Pelicula, String horaIni, String horaFin, String Fecha, Double precio)
        {
            return new CapaDatos.ClsProyeccion().insertarProyeccion(Sala, Pelicula, horaIni, horaFin, Fecha, precio);
        }

        public DataTable LlenarSalas()
        {
            CapaDatos.ClsProyeccion Salas = new CapaDatos.ClsProyeccion();
            return Salas.cargarSala();
        }

        public DataTable LlenarPeliculas()
        {
            CapaDatos.ClsProyeccion Peliculas = new CapaDatos.ClsProyeccion();
            return Peliculas.cargarPeli();
        }
    }
}
