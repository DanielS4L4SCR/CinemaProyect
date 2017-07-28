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
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            CapaNegocios.clsPago ultimaFactura = new CapaNegocios.clsPago();
            DataTable dtUltimaFactura;
            dtUltimaFactura = ultimaFactura.consultaUltimaFactura();
            cboFactura.DataSource = dtUltimaFactura;
            cboFactura.DisplayMember = "MAX(idFactura)";
            cboFactura.ValueMember = "MAX(idFactura)";

            CapaNegocios.clsPago montoFactura = new CapaNegocios.clsPago();
            DataTable dtMontoFactura;
            dtMontoFactura = montoFactura.consultaMontoFactura(Convert.ToInt32(cboFactura.SelectedValue));
            cboMonto.DataSource = dtMontoFactura;
            cboMonto.DisplayMember = "Monto";
            cboMonto.ValueMember = "Monto";

            txtFactura.Text = cboFactura.Text;
            txtMonto.Text = "₡" + cboMonto.Text;
        }
        public int TipoPago()
        {
            
            if(rbEfectivo.Checked==true)
            {
                return 1;
            }else if(rbTarjeta.Checked==true)
            {
                return 2;
            }
            return 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(rbEfectivo.Checked==false && rbTarjeta.Checked==false)
            {
                MessageBox.Show("Debe seleccionar un tipo de pago", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }else
            {
                CapaNegocios.clsPago insertaPago = new CapaNegocios.clsPago();
                if(insertaPago.insertarPago(Convert.ToInt32(cboFactura.SelectedValue), TipoPago()))
                {
                    MessageBox.Show("Pago insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
    }
}
