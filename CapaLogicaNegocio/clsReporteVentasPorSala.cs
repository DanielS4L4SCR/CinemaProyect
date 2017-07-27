using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocios
{
    public class clsReporteVentasPorSala
    {
        CapaDatos.ClsReporteVentasPorSala Reportes = new CapaDatos.ClsReporteVentasPorSala();
        public DataTable consultaSalas()
        {
            return Reportes.consultaSalas();
        }

        public DataTable consultaProyecciones()
        {
            return Reportes.consultaProyecciones();
        }
        public DataTable ReportePorSala(String sala)
        {
            return Reportes.ReportePorSala(sala);
        }
        public DataTable ReportePorProyeccion(int proyeccion)
        {
            return Reportes.ReportePorProyeccion(proyeccion);
        }
     }
}
