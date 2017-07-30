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
    public partial class FrmInabilitador : Form
    {
        public FrmInabilitador()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEBE INSERTAR EL NÚMERO DE CÉDULA DE LA PERSONA A LA QUE LE DESEA DESHABILIDAR O HABILITAR EL CORREO", "Ayuda",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }
        public void cargarPersona()
        {
            CapaNegocios.clsInhabilitador persona = new CapaNegocios.clsInhabilitador();
            DataTable dtPersona;
            dtPersona = persona.CargarPersona();
            cboPersona.DataSource = dtPersona;
            cboPersona.DisplayMember = "idPersona";
            cboPersona.ValueMember = "idPersona";
        }
        public void cargarClientes()
        {
            CapaNegocios.clsInhabilitador persona = new CapaNegocios.clsInhabilitador();
            DataTable dtPersona;
            dtPersona = persona.CargarCliente();
            cboCliente.DataSource = dtPersona;
            cboCliente.DisplayMember = "Persona_idPersona";
            cboCliente.ValueMember = "Persona_idPersona";
        }
        public void cargarEmpleado()
        {
            CapaNegocios.clsInhabilitador persona = new CapaNegocios.clsInhabilitador();
            DataTable dtPersona;
            dtPersona = persona.CargarEmpleado();
            cboEmpleado.DataSource = dtPersona;
            cboEmpleado.DisplayMember = "Usuario_Persona_idPersona";
            cboEmpleado.ValueMember = "Usuario_Persona_idPersona";
        }
        public void cargarPelicula()
        {
            CapaNegocios.clsInhabilitador pelicula = new CapaNegocios.clsInhabilitador();
            DataTable dtpelicula;
            dtpelicula = pelicula.cargarPelicula();
            cboPelicula.DataSource = dtpelicula;
            cboPelicula.DisplayMember = "Nombre";
            cboPelicula.ValueMember = "Nombre";
        }
        public void cargarTipoPelicula()
        {
            CapaNegocios.clsInhabilitador pelicula = new CapaNegocios.clsInhabilitador();
            DataTable dtpelicula;
            dtpelicula = pelicula.cargarTipoPelicula();
            cboTipoPelicula.DataSource = dtpelicula;
            cboTipoPelicula.DisplayMember = "Descripcion";
            cboTipoPelicula.ValueMember = "idTipoPelicula";
        }
        public void cargarGenerosPeli()
        {
            CapaNegocios.clsInhabilitador pelicula = new CapaNegocios.clsInhabilitador();
            DataTable dtpelicula;
            dtpelicula = pelicula.cargarGeneroPeli();
            cboGeneroPelicula.DataSource = dtpelicula;
            cboGeneroPelicula.DisplayMember = "Descripcion";
            cboGeneroPelicula.ValueMember = "idGenero";
        }
        public void cargarProyecciones()
        {
            CapaNegocios.clsInhabilitador proyeccion = new CapaNegocios.clsInhabilitador();
            DataTable dtproyeccion;
            dtproyeccion = proyeccion.CargarProyec();
            cboProyeccion.DataSource = dtproyeccion;
            cboProyeccion.DisplayMember = "id_Proyeccion";
            cboProyeccion.ValueMember = "id_Proyeccion";
        }
        public void cargarSala()
        {
            CapaNegocios.clsInhabilitador sala = new CapaNegocios.clsInhabilitador();
            DataTable dtsala;
            dtsala = sala.cargarSala();
            cboSala.DataSource = dtsala;
            cboSala.DisplayMember = "idSala";
            cboSala.ValueMember = "idSala";
        }
        public void cargarTipoSala()
        {
            CapaNegocios.clsInhabilitador sala = new CapaNegocios.clsInhabilitador();
            DataTable dtsala;
            dtsala = sala.cargarTipoSala();
            cboTipoSala.DataSource = dtsala;
            cboTipoSala.DisplayMember = "Descripcion";
            cboTipoSala.ValueMember = "idTipoSala";
        }
        public void cargarTipoPago()
        {
            CapaNegocios.clsInhabilitador pago = new CapaNegocios.clsInhabilitador();
            DataTable dtPago;
            dtPago = pago.cargarTipoPago();
            cboTipoPago.DataSource = dtPago;
            cboTipoPago.DisplayMember = "Descripcion";
            cboTipoPago.ValueMember = "idTipoPago";
        }
        public void cargarUsuario()
        {
            CapaNegocios.clsInhabilitador usuario = new CapaNegocios.clsInhabilitador();
            DataTable dtusuario;
            dtusuario = usuario.cargarUsuario();
            cboUsuario.DataSource = dtusuario;
            cboUsuario.DisplayMember = "NombreUsuario";
            cboUsuario.ValueMember = "NombreUsuario";        
        }
        private void FrmInabilitador_Load(object sender, EventArgs e)
        {
            cargarPersona();
            cargarClientes();
            cargarEmpleado();
            cargarPelicula();
            cargarTipoPelicula();
            cargarGenerosPeli();
            cargarProyecciones();
            cargarSala();
            cargarTipoSala();
            cargarTipoPago();
            cargarUsuario();
        }

        private void BtnAyudaDirec_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEBE INSERTAR EL NÚMERO DE CÉDULA DE LA PERSONA A LA QUE LE DESEA DESHABILIDAR O HABILITAR SU DIRECCIÓN", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void rbEnable1_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable1.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar a la persona cédula: " + cboPersona.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoPersona(activoPersona(), cboPersona.Text))
                    {

                    }
                }
            }
        }

        private void rbDisable1_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if(rbDisable1.Checked == true)
            {
                DialogResult result;
                result = MessageBox.Show("¿Seguro que desea deshabilitar a la persona cédula: " + cboPersona.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    if(disable.estadoPersona(activoPersona(),cboPersona.Text))
                    {

                    }
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DEBE INSERTAR EL NÚMERO DE TELÉFONO DE LA PERSONA A LA QUE LE DESEA DESHABILIDAR O HABILITAR SU DIRECCIÓN", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void rbEnable2_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable2.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar al cliente cédula: " + cboCliente.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                   if(enable.estadoCliente(activoCliente(),cboCliente.Text))
                   {

                   }
                }
            }
        }

        private void rbDisable2_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDisable2.Checked == true)
            {
                CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar al cliente cédula: " + cboCliente.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoCliente(activoCliente(), cboCliente.Text))
                    {

                    }
                }
            }
        }

        private void rbEnable3_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable3.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar al empleado cédula: " + cboEmpleado.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoEmpleado(activoEmpleado(), cboEmpleado.Text))
                    {

                    }
                }
            }
        }

        private void rbDisable3_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable3.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar al empleado cédula: " + cboEmpleado.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoEmpleado(activoEmpleado(), cboEmpleado.Text))
                    {

                    }
                }
            }
        }

        private void rbEnable4_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable4.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar el correo de la persona cédula: " + txtCorreo.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoCorreo(activoCorreo(), txtCorreo.Text))
                    {

                    }
                }
            }
        }

        private void rbDisable4_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable4.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar el correo de la persona cédula: " + txtCorreo.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoCorreo(activoCorreo(), txtCorreo.Text))
                    {

                    }
                }
            }
        }

        private void rbEnable5_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable5.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar la dirección de la persona cédula: " + txtDireccion.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoDireccion(activoDireccion(), txtDireccion.Text))
                    {

                    }
                }
            }
        }

        private void rbDisable5_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable5.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar la dirección de la persona cédula: " + txtDireccion.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoDireccion(activoDireccion(), txtDireccion.Text))
                    {

                    }
                }
            }
        }

        private void rbEnable6_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable6.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar el teléfono de la persona cédula: " + txtDireccion.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoTelefono(activoTelefono(), txtTelefono.Text))
                    {

                    }
                }
            }
        }

        private void rbDisable6_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable6.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar el teléfono de la persona cédula: " + txtDireccion.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoTelefono(activoTelefono(), txtTelefono.Text))
                    {

                    }
                }
            }
        }

        private void rbEnable7_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable7.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar la película: " +cboPelicula.Text+ "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoPelicula(activoPelicula(), cboPelicula.Text))
                    {

                    }
                }
            }
        }

        private void lbDisable7_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable7.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar la película: " + cboPelicula.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoPelicula(activoPelicula(), cboPelicula.Text))
                    {

                    }
                }
            }
        }

        private void rbEnable8_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable8.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar el tipo de película: " + cboTipoPelicula.Text+ "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoTipoPelicula(activoTipoPelicula(), Convert.ToInt32(cboTipoPelicula.SelectedValue)))
                    {

                    }
                }
            }
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = "";
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtTelefono.Text = "";
        }

        private void lbDisable8_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable8.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar el tipo de película: " + cboTipoPelicula.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoTipoPelicula(activoTipoPelicula(), Convert.ToInt32(cboTipoPelicula.SelectedValue)))
                    {

                    }
                }
            }
        }

        private void rbEnable9_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable9.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar el género de película: " + cboGeneroPelicula.Text+ "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.GeneroPelicula(activoGeneroPelicula(), Convert.ToInt32(cboGeneroPelicula.SelectedValue)))
                    {

                    }
                }
            }
        }

        private void rbDisable9_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable9.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar el género de película: " + cboGeneroPelicula.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.GeneroPelicula(activoGeneroPelicula(), Convert.ToInt32(cboGeneroPelicula.SelectedValue)))
                    {

                    }
                }
            }
        }

        private void rbEnable10_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable10.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar la proyección: " + cboProyeccion.Text+ "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoProyeccion(activoProyeccion(), Convert.ToInt32(cboProyeccion.SelectedValue)))
                    {

                    }
                }
            }
        }

        private void rbDisable10_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable10.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar la proyección: " + cboProyeccion.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (result1 == System.Windows.Forms.DialogResult.OK)
                    {
                        if (disable.estadoProyeccion(activoProyeccion(), Convert.ToInt32(cboProyeccion.SelectedValue)))
                        {

                        }
                    }
                }
            }
        }

        private void rbEnable11_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable11.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar la sala: " + cboSala.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoSala(activoSala(), cboSala.Text))
                    {

                    }
                }
            }
        }

        private void rbDisable11_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable11.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar la sala: " + cboSala.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoSala(activoSala(), cboSala.Text))
                    {

                    }
                }
            }
        }

        private void rbEnable12_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable12.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar el tipo de sala: " + cboTipoSala.Text+ "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoTipoSala(activoTipoSala(), Convert.ToInt32(cboTipoSala.SelectedValue)))
                    {

                    }
                }
            }
        }

        private void rbDisable12_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable12.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar el tipo de sala: " + cboTipoSala.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoTipoSala(activoTipoSala(), Convert.ToInt32(cboTipoSala.SelectedValue)))
                    {

                    }
                }
            }
        }

        private void rbEnable13_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable13.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar el tipo de pago: " + cboTipoPago.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoTipoPago(activoTipoPago(), Convert.ToInt32(cboTipoPago.SelectedValue)))
                    {

                    }
                }
            }
        }

        private void rbDisable13_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable13.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar el tipo de pago: " + cboTipoPago.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoTipoPago(activoTipoPago(), Convert.ToInt32(cboTipoPago.SelectedValue)))
                    {

                    }
                }
            }
        }

        private void rbEnable14_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador enable = new CapaNegocios.clsInhabilitador();
            if (rbEnable14.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea habilitar el usuario: " + cboUsuario.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (enable.estadoUsuario(activoUsuario(), cboUsuario.Text))
                    {

                    }
                }
            }
        }

        private void rbDisable14_CheckedChanged(object sender, EventArgs e)
        {
            CapaNegocios.clsInhabilitador disable = new CapaNegocios.clsInhabilitador();
            if (rbDisable14.Checked == true)
            {
                DialogResult result1;
                result1 = MessageBox.Show("¿Seguro que desea deshabilitar el usuario: " + cboUsuario.Text + "?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == System.Windows.Forms.DialogResult.OK)
                {
                    if (disable.estadoUsuario(activoUsuario(), cboUsuario.Text))
                    {

                    }
                }
            }
        }
        public int activoPersona()
        {
            if(rbEnable1.Checked)
            {
                return 1;
            }else if(rbDisable1.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoCliente()
        {
            if (rbEnable2.Checked)
            {
                return 1;
            }
            else if (rbDisable2.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoEmpleado()
        {
            if (rbEnable3.Checked)
            {
                return 1;
            }
            else if (rbDisable3.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoCorreo()
        {
            if (rbEnable4.Checked)
            {
                return 1;
            }
            else if (rbDisable4.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoDireccion()
        {
            if (rbEnable5.Checked)
            {
                return 1;
            }
            else if (rbDisable5.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoTelefono()
        {
            if (rbEnable6.Checked)
            {
                return 1;
            }
            else if (rbDisable6.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoPelicula()
        {
            if (rbEnable7.Checked)
            {
                return 1;
            }
            else if (rbDisable7.Checked)
            {
                return 0;
            }
            return 1;
        }
  
        public int activoTipoPelicula()
        {
            if (rbEnable8.Checked)
            {
                return 1;
            }
            else if (rbDisable8.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoGeneroPelicula()
        {
            if (rbEnable9.Checked)
            {
                return 1;
            }
            else if (rbDisable9.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoProyeccion()
        {
            if (rbEnable10.Checked)
            {
                return 1;
            }
            else if (rbDisable10.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoSala()
        {
            if (rbEnable11.Checked)
            {
                return 1;
            }
            else if (rbDisable11.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoTipoSala()
        {
            if (rbEnable12.Checked)
            {
                return 1;
            }
            else if (rbDisable12.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoTipoPago()
        {
            if (rbEnable13.Checked)
            {
                return 1;
            }
            else if (rbDisable13.Checked)
            {
                return 0;
            }
            return 1;
        }

        public int activoUsuario()
        {
            if (rbEnable14.Checked)
            {
                return 1;
            }
            else if (rbDisable14.Checked)
            {
                return 0;
            }
            return 1;
        }
    }
}
