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
    public partial class FrmReporteCliente : Form
    {
        public FrmReporteCliente()
        {
            InitializeComponent();
        }

        private void FrmReporteCliente_Load(object sender, EventArgs e)
        {
            CapaNegocios.clsReporteCliente Reportes = new CapaNegocios.clsReporteCliente();
            DataTable dtReportes;
            dtReportes = Reportes.consultaTipoCliente();
            cboClientes.DataSource = dtReportes;
            cboClientes.DisplayMember = "Descripcion";
            cboClientes.ValueMember = "idTipoCliente";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsReporteCliente Reportes = new CapaNegocios.clsReporteCliente();
            DataTable dtReportes;
            dtReportes = Reportes.CantidadPorTipo(Convert.ToInt32(cboClientes.SelectedValue));
            cboResultado.DataSource = dtReportes;
            cboResultado.DisplayMember = "count(*)";

            DialogResult result;
            result =MessageBox.Show("La cantidad de clientes de tipo: " +cboClientes.Text+" es de "+cboResultado.Text+ "¿Desea mostrar todos los clientes?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                //acá se va a mostrar un form con un dgv que muestre todos los clientes.
                FrmTotalClientes clientes = new FrmTotalClientes();
                clientes.Show();

            }
        }
    }
}
