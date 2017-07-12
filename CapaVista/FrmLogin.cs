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
            
            if(login.login(txtUsuario.Text,txtContraseña.Text).Rows.Count>0)
            {
                new FrmPrincipall().Show();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalidos, intente de nuevo.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
