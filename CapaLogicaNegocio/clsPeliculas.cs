using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocios
{
  
    public class clsPeliculas
    {
        public bool insertarPelicula(int idpelicula, String nombre, String duracion, int tipoPeli, int genPeli)
        {
            return new CapaDatos.ClsPeliculas().insertarPelicula(idpelicula, nombre, duracion, tipoPeli, genPeli);
        }
        public DataTable LlenarTipoPeli()
        {
            CapaDatos.ClsPeliculas tipoPeli = new CapaDatos.ClsPeliculas();
            return tipoPeli.cargarTipoPelicula();
        }
        public DataTable LlenarGenPeli()
        {
            CapaDatos.ClsPeliculas GenPeli = new CapaDatos.ClsPeliculas();
            return GenPeli.cargarGenPelicula();
        }

    }
}
