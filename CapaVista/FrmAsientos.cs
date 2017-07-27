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
    public partial class FrmAsientos : Form
    {
        public FrmAsientos()
        {
            InitializeComponent();
        }
        public FrmAsientos(String text)
        {
            InitializeComponent();
            lbSala.Text = text;
        }

        private void FrmAsientos_Load(object sender, EventArgs e)
        {
            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
          
            
        }
    }
}
