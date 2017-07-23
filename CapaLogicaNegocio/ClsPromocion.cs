using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocios
{
    public class ClsPromocion
    {
        public DataTable LlenarProyeccion()
        {
            CapaDatos.ClsPromocion Proyeccion = new CapaDatos.ClsPromocion();
            return Proyeccion.cargarProyeccion();
        }
        public DataTable LlenarTipoCliente()
        {
            CapaDatos.ClsPromocion tipoCliente = new CapaDatos.ClsPromocion();
            return tipoCliente.cargarTipoCliente();
        }

        public bool insertarPromocion( int idProyeccion, Double descuento, String descripcion, int tipoCliente)
        {
            return new CapaDatos.ClsPromocion().insertarPromocion(idProyeccion, descuento, descripcion, tipoCliente);
        }
    }
}
 