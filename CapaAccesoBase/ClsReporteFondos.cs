using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class ClsReporteFondos
    {
        CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
        public DataTable ReporteFondos()
        {
            DataTable dtProyeccion;
            dtProyeccion = conecta.ejecutar("Select SUM(Monto) from factura");
            return dtProyeccion;
        }
    }
}
