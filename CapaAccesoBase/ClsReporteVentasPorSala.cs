using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaDatos
{
    public class ClsReporteVentasPorSala
    {
        CapaDatos.ClsConexion conecta = new CapaDatos.ClsConexion();
        public DataTable consultaSalas()
        {
            DataTable dtSala;
            dtSala = conecta.ejecutar("Select idSala from sala");
            return dtSala;
        }
        public DataTable consultaProyecciones()
        {
            DataTable dtProyeccion;
            dtProyeccion = conecta.ejecutar("Select id_Proyeccion from proyecciones");
            return dtProyeccion;
        }

        public DataTable ReportePorSala(String sala)
        {
            DataTable dtProyeccion;
            dtProyeccion = conecta.ejecutar("Select count(*) From proyecciones P inner Join detalle D  on P.id_Proyeccion = D.Proyecciones_id_Proyeccion where idSala='"+sala+"'");
            return dtProyeccion;
        }

        public DataTable ReportePorProyeccion(int proyeccion)
        {
            DataTable dtProyeccion;
            dtProyeccion = conecta.ejecutar("Select count(*) From proyecciones P inner Join detalle D  on P.id_Proyeccion = D.Proyecciones_id_Proyeccion where id_Proyeccion="+proyeccion+"");
            return dtProyeccion;
        }

    }
}
