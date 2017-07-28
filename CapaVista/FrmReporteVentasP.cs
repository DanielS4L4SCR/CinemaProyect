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
    public partial class FrmReporteVentasP : Form
    {
        public FrmReporteVentasP()
        {
            InitializeComponent();
        }

        private void FrmReporteVentasP_Load(object sender, EventArgs e)
        {
            CapaNegocios.clsReporteVentasPeli peliculas = new CapaNegocios.clsReporteVentasPeli();
            DataTable dtPeliculas;
            dtPeliculas = peliculas.consultaPeliculas();
            cboPelicula.DataSource = dtPeliculas;
            cboPelicula.DisplayMember = "Nombre";
            cboPelicula.ValueMember = "idPelicula";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsReporteVentasPeli peliculas = new CapaNegocios.clsReporteVentasPeli();
            DataTable dtPeliculas;
            dtPeliculas = peliculas.consultaTotalPeliculas(Convert.ToInt32(cboPelicula.SelectedValue));
            cboResultado.DataSource = dtPeliculas;
            cboResultado.DisplayMember = "count(*)";
            cboResultado.ValueMember = "count(*)";

            MessageBox.Show("La cantidad de ventas para la pelicula: " + cboPelicula.Text + " es de " + cboResultado.Text, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
