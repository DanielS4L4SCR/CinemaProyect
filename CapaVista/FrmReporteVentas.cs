using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class FrmReporteVentas : Form
    {
        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        private void FrmReporteVentas_Load(object sender, EventArgs e)
        {
            CapaNegocios.clsReporteVentasPorSala Salas = new CapaNegocios.clsReporteVentasPorSala();
            DataTable dtSalas;
            dtSalas = Salas.consultaSalas();
            cboSala.DataSource = dtSalas;
            cboSala.DisplayMember = "idSala";
            cboSala.ValueMember = "idSala";

            CapaNegocios.clsReporteVentasPorSala Reportes = new CapaNegocios.clsReporteVentasPorSala();
            DataTable dtReportes;
            dtReportes = Reportes.consultaProyecciones();
            cboProyeccion.DataSource = dtReportes;
            cboProyeccion.DisplayMember = "id_Proyeccion";
            cboProyeccion.ValueMember = "id_Proyeccion";

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsReporteVentasPorSala Reportes = new CapaNegocios.clsReporteVentasPorSala();
            DataTable dtReportes;
            dtReportes = Reportes.ReportePorSala(cboSala.Text);
            cboResultado1.DataSource = dtReportes;
            cboResultado1.DisplayMember = "count(*)";

            MessageBox.Show("La Cantidad de ventas para la: " + cboSala.Text + " es de " + cboResultado1.Text, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsReporteVentasPorSala Reportes = new CapaNegocios.clsReporteVentasPorSala();
            DataTable dtReportes;
            dtReportes = Reportes.ReportePorProyeccion(Convert.ToInt32(cboProyeccion.SelectedValue));
            cboResultado2.DataSource = dtReportes;
            cboResultado2.DisplayMember = "count(*)";

            MessageBox.Show("La Cantidad de ventas para la proyección: " + cboProyeccion.Text + " es de " + cboResultado2.Text, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
