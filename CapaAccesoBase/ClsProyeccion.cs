using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class ClsProyeccion
    {
        public bool insertarProyeccion(String Sala, int Pelicula, String horaIni, String horaFin, String Fecha, Double precio)
        {
            ClsConexion conectar = new ClsConexion();
            return conectar.ejecutarInsert("insert into proyecciones (Peliculas_idPelicula, idSala, HoraInicio, HoraFinalizacion, FechaProyeccion, Precio) values (" + Pelicula + ",'" + Sala + "','" + horaIni + "','" + horaFin + "','" + Fecha + "'," + precio + ")");
        }
        public DataTable cargarSala()
        {
            ClsConexion conect = new ClsConexion();
            DataTable dtSalas;
            dtSalas = conect.ejecutar("Select idSala from sala");
            return dtSalas;
        }
        public DataTable cargarDuracion(int pelicula)
        {
            ClsConexion conect = new ClsConexion();
            DataTable dtPeli;
            dtPeli = conect.ejecutar("Select Duracion from peliculas where idPelicula="+pelicula+"");
            return dtPeli;
        }
        public DataTable cargarPeli()
        {
            ClsConexion conect = new ClsConexion();
            DataTable dtPeli;
            dtPeli = conect.ejecutar("Select idPelicula,Nombre from peliculas");
            return dtPeli;
        }
    }
}
