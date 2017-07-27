using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class ClsReporteCliente
    {
        CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
        public DataTable consultaTipoCliente()
        {
            DataTable dtTipoCliente;
            dtTipoCliente = conecta.ejecutar("Select idTipoCliente, Descripcion from tipocliente");
            return dtTipoCliente;
        }
        public DataTable CantidadPorTipo(int tipo)
        {
            DataTable dtCliente;
            dtCliente = conecta.ejecutar("Select count(*) from Cliente where TipoCliente_idTipoCliente = "+tipo+"");
            return dtCliente;
        }
    }
}
