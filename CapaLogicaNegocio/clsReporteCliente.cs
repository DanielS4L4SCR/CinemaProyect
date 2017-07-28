using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocios
{
    public class clsReporteCliente
    {
        CapaDatos.ClsReporteCliente Reportes = new CapaDatos.ClsReporteCliente();
        public DataTable consultaTipoCliente()
        {
            return Reportes.consultaTipoCliente();
        }
        public DataTable CantidadPorTipo(int tipo)
        {
            return Reportes.CantidadPorTipo(tipo);
        }
        public DataTable consultaClientes()
        {
            return Reportes.cargarClientes();
        }
    }
}
