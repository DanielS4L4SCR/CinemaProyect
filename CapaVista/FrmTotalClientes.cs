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
    public partial class FrmTotalClientes : Form
    {
        public FrmTotalClientes()
        {
            InitializeComponent();
        }

        private void FrmTotalClientes_Load(object sender, EventArgs e)
        {
            CapaNegocios.clsReporteCliente cliente = new CapaNegocios.clsReporteCliente();
            DataTable dtrepCliente = new DataTable();

            dtrepCliente = cliente.consultaClientes();
            dgvClientes.DataSource = dtrepCliente;
        }
    }
}
