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
   
    public partial class FrmLogin : Form
        
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsLogin login = new CapaNegocios.clsLogin();
            String text = txtUsuario.Text;
            FrmPrincipall Principal = new FrmPrincipall(text);

            if(login.login(txtUsuario.Text,txtContraseña.Text).Rows.Count>0 &&txtUsuario.Text!=""&&txtContraseña.Text!="")
            {
                Principal.Show();    
                limpiar();
                new FrmLogin().Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalidos, intente de nuevo", "Error", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }
        public void limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            cboxMostrar.Checked = false;
        }

        private void cboMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxMostrar.Checked == true) 
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtContraseña.PasswordChar = '\0';

            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void cboLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
    }
}
