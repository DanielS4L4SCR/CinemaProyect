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
    public partial class FrmReporteFondos : Form
    {
        public FrmReporteFondos()
        {
            InitializeComponent();
        }

        private void cboResultadoMoney_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmReporteFondos_Load(object sender, EventArgs e)
        {
            CapaNegocios.clsReporteFondos Reportes = new CapaNegocios.clsReporteFondos();
            DataTable dtReportes;
            dtReportes = Reportes.ReporteFondos();
            cboResultadoMoney.DataSource = dtReportes;
            cboResultadoMoney.DisplayMember = "SUM(Monto)";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El total de dinero recaudado es de:  ₡" + cboResultadoMoney.Text, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
