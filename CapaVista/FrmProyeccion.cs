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
    public partial class FrmProyeccion : Form
    {
        public FrmProyeccion()
        {
            InitializeComponent();
        }

        private void FrmProyeccion_Load(object sender, EventArgs e)
        {
            DataTable oDT = new DataTable();
            CapaNegocios.clsProyeccion proyeccion = new CapaNegocios.clsProyeccion();
            oDT = proyeccion.LlenarSalas();
            cboSala.DataSource = oDT;
            cboSala.DisplayMember = "idSala";
            cboSala.ValueMember = "idSala";

            DataTable oDT2 = new DataTable();
            CapaNegocios.clsProyeccion proyeccion1 = new CapaNegocios.clsProyeccion();
            oDT2 = proyeccion1.LlenarPeliculas();
            cboPelicula.DataSource = oDT2;
            cboPelicula.DisplayMember = "Nombre";
            cboPelicula.ValueMember = "idPelicula";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CapaNegocios.clsProyeccion proyeccion = new CapaNegocios.clsProyeccion();
            if(proyeccion.insertarProyeccion(cboSala.Text, Convert.ToInt32(cboPelicula.SelectedValue),txtHoraIni.Text,txtHoraFin.Text,DtFecha.Text,int.Parse(txtPrecio.Text)))
            {
                MessageBox.Show("Proyección agregada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

       
    }
}
