﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace CapaVista
{
    public partial class FrmPrincipall : Form
    {
        public FrmPrincipall()
        {
            InitializeComponent();
            
        }
        public FrmPrincipall(String texto)
        {
            InitializeComponent();
            lbUsuario.Text = texto;
        }
        public static class Util {
            public enum Effect { Roll,Slide,Center, Blend }

            public static void Animate(Control ctl, Effect effect, int msec, int angle)
            {
                int flags = effmap[(int)effect];
                if (ctl.Visible)
                {
                    flags |= 0x10000; angle += 180;
                }
                else
                {
                    if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                    else if (effect == Effect.Blend) throw new ArgumentException();
                }
                flags |= dirmap[(angle % 360) / 45];
                bool ok = AnimateWindow(ctl.Handle, msec, flags);
                if (!ok) throw new Exception("Animation failed");
                ctl.Visible = !ctl.Visible;
            }

            private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
            private static int[] effmap = {0,0x40000,0x10,0x80000};

            [DllImport("user32.dll")]

            private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (panelAgregar1.Visible == true)
            {
                Util.Animate(panelAgregar1, Util.Effect.Roll, 150, 360);
                Util.Animate(panelVentas2, Util.Effect.Roll, 150, 360);     
            }else if (panelReportes3.Visible==true)
            {
                Util.Animate(panelReportes3, Util.Effect.Roll, 150, 360);
                Util.Animate(panelVentas2, Util.Effect.Roll, 150, 360);
            }
            else
            {
                Util.Animate(panelVentas2, Util.Effect.Roll, 150, 360);
            }
        }

        private void btnMenú_Click(object sender, EventArgs e)
        {
            panelSubMenu.BringToFront();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Util.Animate(panelMenú, Util.Effect.Roll, 150, 360);
            Util.Animate(panelSubMenu, Util.Effect.Roll, 150, 360);

            if (panelAgregar1.Visible == true)
            {
                Util.Animate(panelAgregar1, Util.Effect.Roll, 150, 360);
            }
            else if (panelVentas2.Visible==true)
            {
                Util.Animate(panelVentas2, Util.Effect.Roll, 150, 360);
            }else if (panelReportes3.Visible == true)
            {
                Util.Animate(panelReportes3, Util.Effect.Roll, 150, 360);
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Util.Animate(panelSubMenu, Util.Effect.Roll, 150, 360);
            Util.Animate(panelMenú, Util.Effect.Roll, 150, 360);
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (panelAgregar1.Visible == true)
            {
                Util.Animate(panelAgregar1, Util.Effect.Roll, 150, 360);
                Util.Animate(panelReportes3, Util.Effect.Roll, 150, 360);
            }
            else if (panelVentas2.Visible==true)
            {
                Util.Animate(panelVentas2, Util.Effect.Roll, 150, 360);
                Util.Animate(panelReportes3, Util.Effect.Roll, 150, 360);
            }
            else
            {
                Util.Animate(panelReportes3, Util.Effect.Roll, 150, 360);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (panelVentas2.Visible == true)
            {
                Util.Animate(panelVentas2, Util.Effect.Roll, 150, 360);
                Util.Animate(panelAgregar1, Util.Effect.Roll, 150, 360);
                
            }else if (panelReportes3.Visible==true)
            {
                Util.Animate(panelReportes3, Util.Effect.Roll, 150, 360);
                Util.Animate(panelAgregar1, Util.Effect.Roll, 150, 360);
            }
            else
            {
                Util.Animate(panelAgregar1, Util.Effect.Roll, 150, 360);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)//sale del panel de agregar
        {
            Util.Animate(panelAgregar1, Util.Effect.Roll, 150, 360);
        }

        private void button1_Click(object sender, EventArgs e)// sale del panel de ventas
        {
            Util.Animate(panelVentas2, Util.Effect.Roll, 150, 360);
        }

        private void btnCancelar3_Click(object sender, EventArgs e)
        {
            Util.Animate(panelReportes3, Util.Effect.Roll, 150, 360);//sale del panel reportes
        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {

        }

        private void panelMenú_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void btnNewMovie_Click(object sender, EventArgs e)
        {
            FrmPelicula pelicula = new FrmPelicula();
            pelicula.Show();
        }

        private void btnAddEmpleado_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleado = new FrmEmpleados();
            empleado.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmProyeccion proyeccion = new FrmProyeccion();
            proyeccion.Show();
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            FrmPromocion promocion = new FrmPromocion();
            promocion.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FrmVentas ventas = new FrmVentas();
            ventas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReporteVentas reportes = new FrmReporteVentas();
            reportes.Show();
        }

        private void btnFondos_Click(object sender, EventArgs e)
        {
            FrmReporteFondos reportes = new FrmReporteFondos();
            reportes.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmReporteCliente reportes = new FrmReporteCliente();
            reportes.Show();
        }
    }
}
