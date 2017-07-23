using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class ClsPromocion
    {
        public bool insertarPromocion(int id_Proyeccion, Double porcentajeDesc, string descripcion, int id_cliente)
        {
            ClsConexion conect = new ClsConexion();
            return conect.ejecutarInsert("insert into promocion (Proyecciones_id_Proyeccion, PorcentajeDescuento, Descripcion, TipoCliente_idTipoCliente) values ("+id_Proyeccion+", "+porcentajeDesc+", '"+descripcion+"', "+id_cliente+")");
        }

        public DataTable cargarProyeccion()
        {
            ClsConexion conect = new ClsConexion();
            DataTable dtPromocion;
            dtPromocion = conect.ejecutar("Select id_Proyeccion,Precio from proyecciones");
            return dtPromocion;
        }

        public DataTable cargarTipoCliente()
        {
            ClsConexion conect = new ClsConexion();
            DataTable dtTipoCliente;
            dtTipoCliente = conect.ejecutar("Select idTipoCliente,Descripcion from tipocliente");
            return dtTipoCliente;
        }
    }
}
