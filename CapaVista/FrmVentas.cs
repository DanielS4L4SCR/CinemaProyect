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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CapaNegocios.clsVenta proyeccion = new CapaNegocios.clsVenta();
            DataTable dtProyeccion;
            dtProyeccion = proyeccion.llenarProyec();
            cboProyeccion.DataSource = dtProyeccion;
            //cboProyeccion.DisplayMember = "id_Proyeccion";
            cboProyeccion.ValueMember = "id_Proyeccion";
            CapaNegocios.clsVenta cliente = new CapaNegocios.clsVenta();
            DataTable dtCliente;

            dtCliente = cliente.llenarCliente();
            cboCliente.DataSource = dtCliente;
            cboCliente.DisplayMember = "Persona_idPersona";
            cboCliente.ValueMember = "idCliente";
            lbTipoCliente.Text = "";

            CapaNegocios.clsVenta empleado = new CapaNegocios.clsVenta();
            DataTable dtEmpleado;

            dtEmpleado = empleado.llenarEmpleado();
            cboEmpleado.DataSource = dtEmpleado;
            cboEmpleado.DisplayMember = "Usuario_Persona_idPersona";
            cboEmpleado.ValueMember = "id_Empleado";
            lbTipoCliente.Text = "Tipo cliente: ";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsVenta venta = new CapaNegocios.clsVenta();

            if (cboProyeccion.SelectedValue!=null)
            {
                foreach (DataGridViewRow prod in dgvVentas.Rows)
                {
                    if (prod.Cells["IDProyeccion"].Value.ToString().Equals(cboProyeccion.SelectedValue.ToString()))
                    {
                        prod.Cells["Cantidad"].Value = (int)prod.Cells["Cantidad"].Value+(int)nudCantidad.Value;

                        lbValor.Text = "" + total();
                        return;
                    }
                }
                DataTable oDT = venta.llenarProducto(Convert.ToInt32(cboProyeccion.SelectedValue));
                dgvVentas.Rows.Add(oDT.Rows[0]["id_Proyeccion"], oDT.Rows[0]["Peliculas_idPelicula"], oDT.Rows[0]["idSala"], oDT.Rows[0]["HoraInicio"], oDT.Rows[0]["HoraFinalizacion"], oDT.Rows[0]["FechaEstreno"], oDT.Rows[0]["Precio"], (int)nudCantidad.Value);

            }
            lbValor.Text = "" + total();
        }

        public int total()
        {
            int acumTotal = 0;
            foreach (DataGridViewRow total in dgvVentas.Rows)
            {
                acumTotal += Convert.ToInt32(total.Cells["Cantidad"].Value) * Convert.ToInt32(total.Cells["Precio"].Value);
            }
            return acumTotal;
        }

        private void cboProyeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
