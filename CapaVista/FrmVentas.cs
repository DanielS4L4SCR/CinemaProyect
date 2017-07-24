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
            cboProyeccion.DisplayMember = "id_Proyeccion";
            cboProyeccion.ValueMember = "id_Proyeccion";
            CapaNegocios.clsVenta cliente = new CapaNegocios.clsVenta();
            DataTable dtCliente;

            dtCliente = cliente.llenarCliente();
            cboCliente.DataSource = dtCliente;
            cboCliente.DisplayMember = "Persona_idPersona";
            cboCliente.ValueMember = "idCliente";
            CapaNegocios.clsVenta empleado = new CapaNegocios.clsVenta();
            DataTable dtEmpleado;

            dtEmpleado = empleado.llenarEmpleado();
            cboEmpleado.DataSource = dtEmpleado;
            cboEmpleado.DisplayMember = "Usuario_Persona_idPersona";
            cboEmpleado.ValueMember = "id_Empleado";


        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsVenta venta = new CapaNegocios.clsVenta();

            cargaTipoCliente();
            cargaUltimaFactura();
            cargaPromo();
            if (cboPromo.Items.Count > 0)
            {
                MessageBox.Show("Existe una promoción: " + cboPromo.Text + " se aplicará descuento de: " + cboDescuento.Text + "%", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (cboProyeccion.SelectedValue != null)
            {
                foreach (DataGridViewRow prod in dgvVentas.Rows)
                {
                    if (prod.Cells["IDProyeccion"].Value.ToString().Equals(cboProyeccion.SelectedValue.ToString()))
                    {
                        prod.Cells["Cantidad"].Value = (int)prod.Cells["Cantidad"].Value + (int)nudCantidad.Value;
                        lbValor.Text = "" + total();
                        return;
                    }
                }
                DataTable oDT = venta.llenarProducto(Convert.ToInt32(cboProyeccion.SelectedValue));


                dgvVentas.Rows.Add(oDT.Rows[0]["id_Proyeccion"], oDT.Rows[0]["Peliculas_idPelicula"], oDT.Rows[0]["idSala"], oDT.Rows[0]["HoraInicio"], oDT.Rows[0]["HoraFinalizacion"], oDT.Rows[0]["FechaEstreno"], oDT.Rows[0]["Precio"], (int)nudCantidad.Value, descuento());

            }
            lbValor.Text = "" + total();
        }

        public Double descuento()
        {
            if (cboDescuento.Text == "")
            {
                return 1;
            }
            else
            {
                Double descuento;
                descuento = Double.Parse(cboDescuento.Text) / 100;
                return descuento;
            }
        }

        public Double total()
        {
            Double acumTotal = 0;
            foreach (DataGridViewRow total in dgvVentas.Rows)
            {
                acumTotal += Convert.ToInt32(total.Cells["Cantidad"].Value) * Convert.ToInt32(total.Cells["Precio"].Value) * Convert.ToDouble(total.Cells["Descuent"].Value);
            }
            return acumTotal;
        }

        private void cboProyeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void cargaTipoCliente()
        {
            CapaNegocios.clsVenta tipoCliente = new CapaNegocios.clsVenta();
            DataTable dtTipoCliente;
            dtTipoCliente = tipoCliente.consultaTipoCliente(Convert.ToInt32(cboCliente.SelectedValue));
            cboTipoCliente.DataSource = dtTipoCliente;
            cboTipoCliente.DisplayMember = "TipoCliente_idTipoCliente";
            cboTipoCliente.ValueMember = "TipoCliente_idTipoCliente";
        }
        public void cargaUltimaFactura()
        {
            CapaNegocios.clsVenta ultimaFactura = new CapaNegocios.clsVenta();
            DataTable dtUltimaFactura;
            dtUltimaFactura = ultimaFactura.consultaUltimaFactura();
            cboLastFac.DataSource = dtUltimaFactura;
            cboLastFac.DisplayMember = "MAX(idCliente)";
            cboLastFac.ValueMember = "MAX(idCliente)";
        }

        public void cargaPromo()
        {
            CapaNegocios.clsVenta promo = new CapaNegocios.clsVenta();
            DataTable dtPromo;
            dtPromo = promo.consultaPromo(Convert.ToInt32(cboTipoCliente.SelectedValue), Convert.ToInt32(cboProyeccion.SelectedValue));
            cboPromo.DataSource = dtPromo;
            cboPromo.DisplayMember = "Descripcion";
            cboPromo.ValueMember = "idPromocion";

            cboDescuento.DataSource = dtPromo;
            cboDescuento.DisplayMember = "PorcentajeDescuento";
            cboDescuento.DisplayMember = "PorcentajeDescuento";

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargaTipoCliente();
            cargaUltimaFactura();
            CapaNegocios.clsVenta factura = new CapaNegocios.clsVenta();

            var result = MessageBox.Show("¿Seguro que deseea realizar la factura?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (factura.insertarFactura(Convert.ToInt32(cboCliente.SelectedValue), cboCliente.Text, DtFecha.Text, total(), Convert.ToInt32(cboEmpleado.SelectedValue), Convert.ToInt32(cboTipoCliente.SelectedValue)))
                {
                    for (int i = 0; i < dgvVentas.Rows.Count; i++)
                    {  
                        int proyeccion = Convert.ToInt16(dgvVentas["IDProyeccion", i].Value);
                        Double precio = Convert.ToDouble((dgvVentas["Precio", i].Value));
                        int cantidad = (int)dgvVentas["Cantidad", i].Value;
                        cargaUltimaFactura();
                        if (!factura.insertarDetalle(i, Convert.ToInt32(cboLastFac.SelectedValue), proyeccion, precio, cantidad))
                        {
                            MessageBox.Show("Error al crear la factura","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                            return;
                        }
                        
                    }
                    MessageBox.Show("Factura realizada correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.None);
                }
            }
        }
    }

}
    

