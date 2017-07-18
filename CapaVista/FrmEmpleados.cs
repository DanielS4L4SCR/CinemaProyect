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
    public partial class FrmEmpleados : Form
    {
       
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            DataTable oDT = new DataTable();
            CapaNegocios.clsEmpleado telefono = new CapaNegocios.clsEmpleado();
            oDT = telefono.LlenarCamposTel();
            cboTel.DataSource = oDT;
            cboTel.DisplayMember = "Descripcion";
            cboTel.ValueMember = "idTipoTelefonio";

            DataTable oDT2 = new DataTable();
            CapaNegocios.clsEmpleado mail = new CapaNegocios.clsEmpleado();
            oDT2 = mail.LlenarCamposMail();
            cboMail.DataSource = oDT2;
            cboMail.DisplayMember = "Descripcion";
            cboMail.ValueMember = "idTipoCorreo";

            DataTable oDT3 = new DataTable();
            CapaNegocios.clsEmpleado provincia = new CapaNegocios.clsEmpleado();
            oDT3 = provincia.LlenarCamposProv();
            cboProv.DataSource = oDT3;
            cboProv.DisplayMember = "Nombre_Provincia";
            cboProv.ValueMember = "ID_Provincia";

            DataTable oDT4 = new DataTable();
            CapaNegocios.clsEmpleado canton = new CapaNegocios.clsEmpleado();
            oDT4 = canton.LlenarCamposCan(int.Parse(cboProv.SelectedValue.ToString()));
            cboCanton.DataSource = oDT4;
            cboCanton.DisplayMember = "Nombre_Canton";
            cboCanton.ValueMember = "ID_Canton";

            DataTable oDT5 = new DataTable();
            CapaNegocios.clsEmpleado distrito = new CapaNegocios.clsEmpleado();
            oDT5 = distrito.LlenarCamposDis(int.Parse(cboCanton.SelectedValue.ToString()), int.Parse(cboProv.SelectedValue.ToString()));
            cboDistri.DataSource = oDT5;
            cboDistri.DisplayMember = "Nombre_Distrito";
            cboDistri.ValueMember = "ID_Distrito";


        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
        }
         
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CboxAddUser.Checked)
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
                rbLimpiador.Enabled = false;
                rbAdmin.Enabled = true;
                rbCajero.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                rbLimpiador.Enabled = true;
                rbAdmin.Enabled = false;
                rbCajero.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsEmpleado empleado = new CapaNegocios.clsEmpleado();
           /* if (txtID.Text == "" || txtNom.Text == "" || txtApe1.Text == "" || txtUser.Text == "" || txtPassword.Text == "" || cboProv.Text == "" || cboCanton.Text == "" || cboDistri.Text == "" || txtDireccion.Text == "" || txtTel.Text == "" || cboTel.Text == "" || txtMail.Text == "" || cboMail.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("Faltan campos por completar", "Error#001", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(result == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                }
            }*/
            if (rbNacional.Checked == true)
            {
               if (empleado.insertarNacional(txtID.Text, txtNom.Text, txtApe1.Text, txtApe2.Text, Genero(), txtUser.Text, txtPassword.Text, TipoEmpleado(), Convert.ToInt32(cboProv.SelectedValue), Convert.ToInt32(cboCanton.SelectedValue), Convert.ToInt32(cboDistri.SelectedValue),txtDireccion.Text,activo(),int.Parse(txtTel.Text),Convert.ToInt32(cboTel.SelectedValue),txtMail.Text, Convert.ToInt32(cboMail.SelectedValue)))
                {
                    MessageBox.Show("Empleado Insertado");
                }
            }
            if(rbExtranjero.Checked==true)
            {
                if (empleado.insertarExtranjero(txtID.Text, txtNom.Text, txtApe1.Text, txtApe2.Text, Genero(), txtUser.Text, txtPassword.Text, TipoEmpleado(), Convert.ToInt32(cboProv.SelectedValue), Convert.ToInt32(cboCanton.SelectedValue), Convert.ToInt32(cboDistri.SelectedValue), txtDireccion.Text, activo(), int.Parse(txtTel.Text), Convert.ToInt32(cboTel.SelectedValue), txtMail.Text, Convert.ToInt32(cboMail.SelectedValue)))
                {
                    MessageBox.Show("Empleado Insertado");
                }
            }
        }
        public int Genero()
        {
            int result = 0;
            if (rbMale.Checked==true)
            {
                return result = 1;
            }
            else if (rbFemale.Checked == true)
            {
                return result = 2;
            }
            return result;
        }
        public int TipoEmpleado()
        {
            int result = 0;
            if(rbAdmin.Checked==true)
            {
                return result = 1;

            }else if (rbCajero.Checked==true)
            {
                return result = 2;
            }else if(rbLimpiador.Checked==true)
            {
                return result = 3;
            }
            return result;
        }
        public int activo()
        {
            int result = 0;
            if(CboxAddUser.Checked==true)
            {
                result = 1;
            }else if(CboxAddUser.Checked==false)
            {
                result = 0;
            }
            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable oDT4 = new DataTable();
            CapaNegocios.clsEmpleado canton = new CapaNegocios.clsEmpleado();
            oDT4 = canton.LlenarCamposCan(int.Parse(cboProv.SelectedValue.ToString()));
            cboCanton.DataSource = oDT4;
            cboCanton.DisplayMember = "Nombre_Canton";
            cboCanton.ValueMember = "ID_Canton";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable oDT5 = new DataTable();
            CapaNegocios.clsEmpleado distrito = new CapaNegocios.clsEmpleado();
            oDT5 = distrito.LlenarCamposDis(int.Parse(cboCanton.SelectedValue.ToString()), int.Parse(cboProv.SelectedValue.ToString()));
            cboDistri.DataSource = oDT5;
            cboDistri.DisplayMember = "Nombre_Distrito";
            cboDistri.ValueMember = "ID_Distrito";
        }
    }
}
