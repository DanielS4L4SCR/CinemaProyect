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
    public partial class FrmPelicula : Form
    {
        public FrmPelicula()
        {
            InitializeComponent();
        }

        private void cboTipoPel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable oDT = new DataTable();
            CapaNegocios.clsPeliculas pelicula = new CapaNegocios.clsPeliculas();
            oDT = pelicula.LlenarTipoPeli();
            cboTipoPel.DataSource = oDT;
            cboTipoPel.DisplayMember = "Descripcion";
            cboTipoPel.ValueMember = "idTipoPelicula";
        }

        private void cboGenPeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable oDT = new DataTable();
            CapaNegocios.clsPeliculas pelicula = new CapaNegocios.clsPeliculas();
            oDT = pelicula.LlenarGenPeli();
            cboGenPeli.DataSource = oDT;
            cboGenPeli.DisplayMember = "Descripcion";
            cboGenPeli.ValueMember = "idGenero";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsPeliculas peli = new CapaNegocios.clsPeliculas();
            if (peli.insertarPelicula(int.Parse(txtidPelicula.Text), txtNom.Text, txtDuracion.Text, Convert.ToInt32(cboTipoPel.SelectedValue), Convert.ToInt32(cboGenPeli.SelectedValue)))
            {
                MessageBox.Show("Pelicula Agregada al sistema");
            }
            DialogResult result;
            result=MessageBox.Show("¿Deseea agregar esta pelicula a una proyección?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
		{
                FrmProyeccion proyecciones = new FrmProyeccion();
                proyecciones.Show();
            }
        }

        private void txtDuracion_Click(object sender, EventArgs e)
        {
            txtDuracion.Text = "";
        }

        private void FrmPelicula_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
