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
        private void cboTel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
        }
         
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.Checked)
            {
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
        }

        private void cboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboProv_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
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

        private void cboDistri_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboMail_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

       
    }
}
