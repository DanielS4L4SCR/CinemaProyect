namespace CapaVista
{
    partial class FrmReporteVentasP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNuevoCliente = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPelicula = new MetroFramework.Controls.MetroComboBox();
            this.lbPelicula = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cboResultado = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lbNuevoCliente
            // 
            this.lbNuevoCliente.AutoSize = true;
            this.lbNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoCliente.Location = new System.Drawing.Point(123, 9);
            this.lbNuevoCliente.Name = "lbNuevoCliente";
            this.lbNuevoCliente.Size = new System.Drawing.Size(186, 25);
            this.lbNuevoCliente.TabIndex = 5;
            this.lbNuevoCliente.Text = "CANTIDAD DE VENTAS";
            this.lbNuevoCliente.UseCustomBackColor = true;
            this.lbNuevoCliente.UseCustomForeColor = true;
            this.lbNuevoCliente.UseStyleColors = true;
            this.lbNuevoCliente.WrapToLine = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel1.Location = new System.Drawing.Point(150, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "POR PELICULA";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.WrapToLine = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.icons8_Monedas_501;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(174, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 68);
            this.panel1.TabIndex = 4;
            // 
            // cboPelicula
            // 
            this.cboPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboPelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.ItemHeight = 23;
            this.cboPelicula.Location = new System.Drawing.Point(123, 177);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(200, 29);
            this.cboPelicula.TabIndex = 60;
            this.cboPelicula.UseCustomBackColor = true;
            this.cboPelicula.UseCustomForeColor = true;
            this.cboPelicula.UseSelectable = true;
            this.cboPelicula.UseStyleColors = true;
            // 
            // lbPelicula
            // 
            this.lbPelicula.AutoSize = true;
            this.lbPelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbPelicula.Location = new System.Drawing.Point(60, 187);
            this.lbPelicula.Name = "lbPelicula";
            this.lbPelicula.Size = new System.Drawing.Size(55, 19);
            this.lbPelicula.TabIndex = 61;
            this.lbPelicula.Text = "Pelicula:";
            this.lbPelicula.UseCustomBackColor = true;
            this.lbPelicula.UseCustomForeColor = true;
            this.lbPelicula.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(329, 177);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(62, 29);
            this.metroButton1.TabIndex = 100;
            this.metroButton1.Text = "Consultar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cboResultado
            // 
            this.cboResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboResultado.FormattingEnabled = true;
            this.cboResultado.ItemHeight = 23;
            this.cboResultado.Location = new System.Drawing.Point(350, 212);
            this.cboResultado.Name = "cboResultado";
            this.cboResultado.Size = new System.Drawing.Size(41, 29);
            this.cboResultado.TabIndex = 101;
            this.cboResultado.UseCustomBackColor = true;
            this.cboResultado.UseCustomForeColor = true;
            this.cboResultado.UseSelectable = true;
            this.cboResultado.UseStyleColors = true;
            this.cboResultado.Visible = false;
            // 
            // FrmReporteVentasP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.cboResultado);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lbPelicula);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbNuevoCliente);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReporteVentasP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePeliculas";
            this.Load += new System.EventHandler(this.FrmReporteVentasP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbNuevoCliente;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboPelicula;
        private MetroFramework.Controls.MetroLabel lbPelicula;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cboResultado;
    }
}