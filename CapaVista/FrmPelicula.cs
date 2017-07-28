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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsPeliculas peli = new CapaNegocios.clsPeliculas();
            if(String.IsNullOrEmpty(txtidPelicula.Text)|| String.IsNullOrEmpty(txtDuracion.Text)|| String.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Debe completar toda la información", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (peli.insertarPelicula(int.Parse(txtidPelicula.Text), txtNom.Text, txtDuracion.Text, Convert.ToInt32(cboTipoPel.SelectedValue), Convert.ToInt32(cboGenPeli.SelectedValue)))
            {
                MessageBox.Show("Pelicula Agregada al sistema");
                DialogResult result;
                result = MessageBox.Show("¿Deseea agregar esta pelicula a una proyección?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    FrmProyeccion proyecciones = new FrmProyeccion();
                    proyecciones.Show();
                }
            }
            
        }
        private void FrmPelicula_Load(object sender, EventArgs e)
        {
            DataTable oDT = new DataTable();
            CapaNegocios.clsPeliculas Tipopelicula = new CapaNegocios.clsPeliculas();
            oDT = Tipopelicula.LlenarTipoPeli();
            cboTipoPel.DataSource = oDT;
            cboTipoPel.DisplayMember = "Descripcion";
            cboTipoPel.ValueMember = "idTipoPelicula";

            DataTable oDT2 = new DataTable();
            CapaNegocios.clsPeliculas pelicula = new CapaNegocios.clsPeliculas();
            oDT2 = pelicula.LlenarGenPeli();
            cboGenPeli.DataSource = oDT2;
            cboGenPeli.DisplayMember = "Descripcion";
            cboGenPeli.ValueMember = "idGenero";
        }
    }
}
