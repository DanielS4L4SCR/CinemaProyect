using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocios
{
    public class clsReporteFondos
    {
        CapaDatos.ClsReporteFondos Reportes = new CapaDatos.ClsReporteFondos();
        public DataTable ReporteFondos()
        {
            return Reportes.ReporteFondos();
        }
    }
}
