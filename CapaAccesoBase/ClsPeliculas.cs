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
        
        public bool insertarPelicula(int idpelicula, String nombre, String duracion, int tipoPeli, int genPeli)
        {
            ClsConexion conectar = new ClsConexion();
            return conectar.ejecutarInsert("insert into peliculas (idPelicula,Nombre,Duracion,TipoPelicula_idTipoPelicula,Género_idGenero) values (" + idpelicula + ",'" + nombre + "','" + duracion + "'," + tipoPeli + "," + genPeli + ")"); 

        }    
        public DataTable cargarTipoPelicula()
        {
            ClsConexion conect = new ClsConexion();
            DataTable dtTipoPeli;
            dtTipoPeli = conect.ejecutar("Select idTipoPelicula,Descripcion from tipopelicula");
            return dtTipoPeli;
        }
        public DataTable cargarGenPelicula()
        {
            ClsConexion conect = new ClsConexion();
            DataTable dtGenPeli;
            dtGenPeli = conect.ejecutar("Select idGenero,Descripcion from generopelicula");
            return dtGenPeli;
        }

    }
}
