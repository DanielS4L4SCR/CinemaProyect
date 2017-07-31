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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbOpcional.Visible = false;
        }

        private void rbExtrangero_CheckedChanged(object sender, EventArgs e)
        {
            lbOpcional.Visible = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsCliente cliente = new CapaNegocios.clsCliente();
            if (String.IsNullOrEmpty(txtID.Text)|| String.IsNullOrEmpty(txtNom.Text)||String.IsNullOrEmpty(txtApe1.Text)||String.IsNullOrEmpty(txtApe2.Text))
            {
                MessageBox.Show("Debe completar toda la información", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (rbNacional.Checked)
            {
                if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtNom.Text) || String.IsNullOrEmpty(txtApe1.Text) || String.IsNullOrEmpty(txtApe2.Text))
                {
                    //MessageBox.Show("Debe completar toda la información", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (cliente.insertarNacional(txtID.Text,txtNom.Text,txtApe1.Text,txtApe2.Text,Genero(),TipoCliente()))
                {
                    MessageBox.Show("Cliente nacional agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.None);
                    limpiar();

                }
            }

            if (rbExtranjero.Checked)
            {
                if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtNom.Text) || String.IsNullOrEmpty(txtApe1.Text) || String.IsNullOrEmpty(txtApe2.Text))
                {
                    //MessageBox.Show("Debe completar toda la información", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (cliente.insertarExtranjero(txtID.Text, txtNom.Text, txtApe1.Text, txtApe2.Text, Genero(), TipoCliente()))
                {
                    MessageBox.Show("Cliente extrangero agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.None);
                    limpiar();
                }
            }

        }

        public int Genero()
        {
            int result=0;
            if (rbMale.Checked == true)
            {
                return result=1;
            }
            else if (rbFemale.Checked == true)
            {
                return result=2;
            }
            return result;
        }

        public int TipoCliente()
        {
            int result = 0;
            if (rbChildren.Checked == true)
            {
                return result = 1;
            }
            else if(rbAdultM.Checked==true)
            {
                return result = 4;
            }
            else if (rbAdolescente.Checked == true)
            {
                return result = 3;
            }
            else if (rbAdult.Checked == true)
            {
                return result = 2;
            }
            return result;
        }

        public void limpiar()
        {
            txtApe1.Text = "";
            txtApe2.Text = "";
            txtID.Text = "";
            txtNom.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbAdultM.Checked = false;
            rbChildren.Checked = false;
            rbAdult.Checked = false;
        }

        
    }
    }

