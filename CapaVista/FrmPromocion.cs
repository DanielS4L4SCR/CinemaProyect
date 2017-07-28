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
    public partial class FrmPromocion : Form
    {
        public FrmPromocion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CapaNegocios.ClsPromocion promocion = new CapaNegocios.ClsPromocion();
            if (String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrEmpty(txtDescuento.Text))
            {
                MessageBox.Show("Debe completar toda la información", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (promocion.insertarPromocion(Convert.ToInt32(cboProyecciones.SelectedValue), double.Parse(txtDescuento.Text), txtDescripcion.Text, Convert.ToInt32(cboTipoCliente.SelectedValue)))
            {
                MessageBox.Show("Promocion agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void FrmPromocion_Load(object sender, EventArgs e)
        {
            DataTable oDT = new DataTable();
            CapaNegocios.ClsPromocion tipoCliente = new CapaNegocios.ClsPromocion();
            oDT = tipoCliente.LlenarTipoCliente();
            cboTipoCliente.DataSource = oDT;
            cboTipoCliente.DisplayMember = "descripcion";
            cboTipoCliente.ValueMember = "idTipoCliente";

            DataTable oDT2 = new DataTable();
            CapaNegocios.ClsPromocion proyeccion = new CapaNegocios.ClsPromocion();
            oDT2 = proyeccion.LlenarProyeccion();
            cboProyecciones.DataSource = oDT2;
            cboProyecciones.DisplayMember = "id_Proyeccion";
            cboProyecciones.ValueMember = "id_Proyeccion";
        }

    }
}
