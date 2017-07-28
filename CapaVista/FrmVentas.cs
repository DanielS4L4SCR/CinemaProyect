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
        public FrmVentas(String text)
        {
            InitializeComponent();
            lbAsiento.Text = text;
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
            cargaPrecio();
            cargaSalas();
            if (cboPromo.Items.Count > 0)
            {
                MessageBox.Show("Existe una promoción: " + cboPromo.Text + " se aplicará descuento de: " + cboDescuento.Text + "%", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           if (cboProyeccion.SelectedValue != null)
            {
                DataTable oDT = venta.llenarProducto(Convert.ToInt32(cboProyeccion.SelectedValue));
                dgvVentas.Rows.Add(oDT.Rows[0]["id_Proyeccion"], oDT.Rows[0]["Peliculas_idPelicula"], oDT.Rows[0]["idSala"], oDT.Rows[0]["HoraInicio"], oDT.Rows[0]["HoraFinalizacion"], oDT.Rows[0]["FechaEstreno"], oDT.Rows[0]["Precio"],precioDescuento(),cboAsiento.Text, descuento());
                
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
        public Double precioDescuento()
        {
            Double Precio = 0;
            Double Cantidad = 0;
            Cantidad = Double.Parse(cboPrecios.Text) * descuento();
            Precio = Double.Parse(cboPrecios.Text) - Cantidad;
            if(cboDescuento.Text=="")
            {
                return Cantidad;
            }
            else
            {
                return Precio;
            }
            
        }
       
        public Double total()
        {
            Double acumTotal = 0;
            foreach (DataGridViewRow total in dgvVentas.Rows)
            {
                acumTotal += 1 * Convert.ToInt32(total.Cells["PrecioDesc"].Value);            
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
            cboLastFac.DisplayMember = "MAX(idFactura)";
            cboLastFac.ValueMember = "MAX(idFactura)";
        }
        public void cargaPrecio()
        {
            CapaNegocios.clsVenta precios = new CapaNegocios.clsVenta();
            DataTable dtPrecios;
            dtPrecios = precios.cargaPrecios(Convert.ToInt32(cboProyeccion.SelectedValue));
            cboPrecios.DataSource = dtPrecios;
            cboPrecios.DisplayMember = "Precio";
            cboPrecios.ValueMember = "Precio";
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
        public void cargaSalas()
        {
            CapaNegocios.clsVenta Salas = new CapaNegocios.clsVenta();
            DataTable dtSalas;
            dtSalas = Salas.consultaSalas(Convert.ToInt32(cboProyeccion.SelectedValue));
            cboSala.DataSource = dtSalas;
            cboSala.DisplayMember = "idSala";
            cboSala.ValueMember = "idSala"; 
        }
        public void CargaAsiento()
        {
            CapaNegocios.clsVenta Asientos = new CapaNegocios.clsVenta();
            DataTable dtAsientos;
            dtAsientos = Asientos.consultaAsientos(cboSala.Text);
            cboAsiento.DataSource = dtAsientos;
            cboAsiento.DisplayMember = "idAsiento";
            cboAsiento.ValueMember = "idAsiento";
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargaTipoCliente();
            cargaUltimaFactura();
            CapaNegocios.clsVenta factura = new CapaNegocios.clsVenta();

            var result = MessageBox.Show("¿Seguro que deseea realizar la factura?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (cboAsiento.Text=="")
                {
                    MessageBox.Show("Debe seleccionar los asientos, puede visualizarlos en el botón: ''ver asientos''", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (factura.insertarFactura(Convert.ToInt32(cboCliente.SelectedValue), cboCliente.Text, DtFecha.Text, total(), Convert.ToInt32(cboEmpleado.SelectedValue), Convert.ToInt32(cboTipoCliente.SelectedValue)))
                {
                    for (int i = 0; i < dgvVentas.Rows.Count; i++)
                    {  
                        int proyeccion = Convert.ToInt16(dgvVentas["IDProyeccion", i].Value);
                        Double precio = Convert.ToDouble(dgvVentas["Precio", i].Value);
                        String asiento = Convert.ToString(dgvVentas["Asiento", i].Value);
                        cargaUltimaFactura();
                        if (!factura.insertarDetalle(Convert.ToInt32(cboLastFac.SelectedValue), proyeccion, precio, asiento))
                        {
                            MessageBox.Show("Error al crear la factura","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                            return;
                        }
                        
                    }
                    MessageBox.Show("Factura realizada correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.None);
                    DialogResult result1;
                    result1 = MessageBox.Show("Debe insertar el tipo de pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        FrmPago pago = new FrmPago();
                        pago.Show();
                    }
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvVentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            CapaVista.FrmCliente ACliente = new FrmCliente();
            ACliente.Show();
            CapaNegocios.clsVenta cliente = new CapaNegocios.clsVenta();
            DataTable dtCliente;
            dtCliente = cliente.llenarCliente();
            cboCliente.DataSource = dtCliente;
            cboCliente.DisplayMember = "Persona_idPersona";
            cboCliente.ValueMember = "idCliente";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            cargaTipoCliente();
            cargaUltimaFactura();
            cargaPromo();
            cargaPrecio();
            cargaSalas();
            CargaAsiento();  
            String text = cboSala.Text;
            FrmAsientos A = new FrmAsientos(text); 
            A.Show();
            //this.Close();
            
        }
    }

}
    

