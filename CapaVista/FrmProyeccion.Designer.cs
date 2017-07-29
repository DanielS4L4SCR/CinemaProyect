namespace CapaVista
{
    partial class FrmProyeccion
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
            this.lbNuevoEmp = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSalas = new MetroFramework.Controls.MetroLabel();
            this.cboSala = new MetroFramework.Controls.MetroComboBox();
            this.lbPelicula = new MetroFramework.Controls.MetroLabel();
            this.cboPelicula = new MetroFramework.Controls.MetroComboBox();
            this.LbHoraIni = new MetroFramework.Controls.MetroLabel();
            this.txtHoraIni = new MetroFramework.Controls.MetroTextBox();
            this.txtHoraFin = new MetroFramework.Controls.MetroTextBox();
            this.LbHoraFin = new MetroFramework.Controls.MetroLabel();
            this.LbFecha = new MetroFramework.Controls.MetroLabel();
            this.DtFecha = new MetroFramework.Controls.MetroDateTime();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.lbPrecio = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.cboDuracion = new MetroFramework.Controls.MetroComboBox();
            this.btnDuracion = new MetroFramework.Controls.MetroButton();
            this.txtDuracion = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lbNuevoEmp
            // 
            this.lbNuevoEmp.AutoSize = true;
            this.lbNuevoEmp.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoEmp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoEmp.Location = new System.Drawing.Point(113, 26);
            this.lbNuevoEmp.Name = "lbNuevoEmp";
            this.lbNuevoEmp.Size = new System.Drawing.Size(176, 25);
            this.lbNuevoEmp.TabIndex = 6;
            this.lbNuevoEmp.Text = "NUEVA PROYECCION";
            this.lbNuevoEmp.UseCustomBackColor = true;
            this.lbNuevoEmp.UseCustomForeColor = true;
            this.lbNuevoEmp.UseStyleColors = true;
            this.lbNuevoEmp.WrapToLine = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.spotlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(147, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 103);
            this.panel1.TabIndex = 5;
            // 
            // lbSalas
            // 
            this.lbSalas.AutoSize = true;
            this.lbSalas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbSalas.Location = new System.Drawing.Point(95, 213);
            this.lbSalas.Name = "lbSalas";
            this.lbSalas.Size = new System.Drawing.Size(36, 19);
            this.lbSalas.TabIndex = 42;
            this.lbSalas.Text = "Sala:";
            this.lbSalas.UseCustomBackColor = true;
            this.lbSalas.UseCustomForeColor = true;
            this.lbSalas.UseStyleColors = true;
            // 
            // cboSala
            // 
            this.cboSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboSala.FormattingEnabled = true;
            this.cboSala.ItemHeight = 23;
            this.cboSala.Location = new System.Drawing.Point(137, 203);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(152, 29);
            this.cboSala.TabIndex = 57;
            this.cboSala.UseCustomBackColor = true;
            this.cboSala.UseCustomForeColor = true;
            this.cboSala.UseSelectable = true;
            this.cboSala.UseStyleColors = true;
            // 
            // lbPelicula
            // 
            this.lbPelicula.AutoSize = true;
            this.lbPelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbPelicula.Location = new System.Drawing.Point(76, 266);
            this.lbPelicula.Name = "lbPelicula";
            this.lbPelicula.Size = new System.Drawing.Size(55, 19);
            this.lbPelicula.TabIndex = 58;
            this.lbPelicula.Text = "Pelicula:";
            this.lbPelicula.UseCustomBackColor = true;
            this.lbPelicula.UseCustomForeColor = true;
            this.lbPelicula.UseStyleColors = true;
            // 
            // cboPelicula
            // 
            this.cboPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboPelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.ItemHeight = 23;
            this.cboPelicula.Location = new System.Drawing.Point(137, 256);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(152, 29);
            this.cboPelicula.TabIndex = 59;
            this.cboPelicula.UseCustomBackColor = true;
            this.cboPelicula.UseCustomForeColor = true;
            this.cboPelicula.UseSelectable = true;
            this.cboPelicula.UseStyleColors = true;
            this.cboPelicula.Click += new System.EventHandler(this.FrmProyeccion_Load);
            // 
            // LbHoraIni
            // 
            this.LbHoraIni.AutoSize = true;
            this.LbHoraIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.LbHoraIni.Location = new System.Drawing.Point(56, 319);
            this.LbHoraIni.Name = "LbHoraIni";
            this.LbHoraIni.Size = new System.Drawing.Size(75, 19);
            this.LbHoraIni.TabIndex = 60;
            this.LbHoraIni.Text = "Hora Inicio:";
            this.LbHoraIni.UseCustomBackColor = true;
            this.LbHoraIni.UseCustomForeColor = true;
            this.LbHoraIni.UseStyleColors = true;
            // 
            // txtHoraIni
            // 
            // 
            // 
            // 
            this.txtHoraIni.CustomButton.Image = null;
            this.txtHoraIni.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtHoraIni.CustomButton.Name = "";
            this.txtHoraIni.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHoraIni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoraIni.CustomButton.TabIndex = 1;
            this.txtHoraIni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoraIni.CustomButton.UseSelectable = true;
            this.txtHoraIni.CustomButton.Visible = false;
            this.txtHoraIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtHoraIni.Lines = new string[] {
        "HH:MM:SS"};
            this.txtHoraIni.Location = new System.Drawing.Point(137, 315);
            this.txtHoraIni.MaxLength = 8;
            this.txtHoraIni.Name = "txtHoraIni";
            this.txtHoraIni.PasswordChar = '\0';
            this.txtHoraIni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoraIni.SelectedText = "";
            this.txtHoraIni.SelectionLength = 0;
            this.txtHoraIni.SelectionStart = 0;
            this.txtHoraIni.ShortcutsEnabled = true;
            this.txtHoraIni.Size = new System.Drawing.Size(152, 23);
            this.txtHoraIni.TabIndex = 61;
            this.txtHoraIni.Text = "HH:MM:SS";
            this.txtHoraIni.UseCustomBackColor = true;
            this.txtHoraIni.UseCustomForeColor = true;
            this.txtHoraIni.UseSelectable = true;
            this.txtHoraIni.UseStyleColors = true;
            this.txtHoraIni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoraIni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHoraFin
            // 
            // 
            // 
            // 
            this.txtHoraFin.CustomButton.Image = null;
            this.txtHoraFin.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtHoraFin.CustomButton.Name = "";
            this.txtHoraFin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHoraFin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoraFin.CustomButton.TabIndex = 1;
            this.txtHoraFin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoraFin.CustomButton.UseSelectable = true;
            this.txtHoraFin.CustomButton.Visible = false;
            this.txtHoraFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtHoraFin.Lines = new string[] {
        "HH:MM:SS"};
            this.txtHoraFin.Location = new System.Drawing.Point(137, 366);
            this.txtHoraFin.MaxLength = 8;
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.PasswordChar = '\0';
            this.txtHoraFin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoraFin.SelectedText = "";
            this.txtHoraFin.SelectionLength = 0;
            this.txtHoraFin.SelectionStart = 0;
            this.txtHoraFin.ShortcutsEnabled = true;
            this.txtHoraFin.Size = new System.Drawing.Size(152, 23);
            this.txtHoraFin.TabIndex = 63;
            this.txtHoraFin.Text = "HH:MM:SS";
            this.txtHoraFin.UseCustomBackColor = true;
            this.txtHoraFin.UseCustomForeColor = true;
            this.txtHoraFin.UseSelectable = true;
            this.txtHoraFin.UseStyleColors = true;
            this.txtHoraFin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoraFin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LbHoraFin
            // 
            this.LbHoraFin.AutoSize = true;
            this.LbHoraFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.LbHoraFin.Location = new System.Drawing.Point(19, 370);
            this.LbHoraFin.Name = "LbHoraFin";
            this.LbHoraFin.Size = new System.Drawing.Size(112, 19);
            this.LbHoraFin.TabIndex = 62;
            this.LbHoraFin.Text = "Hora Finalización:";
            this.LbHoraFin.UseCustomBackColor = true;
            this.LbHoraFin.UseCustomForeColor = true;
            this.LbHoraFin.UseStyleColors = true;
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.LbFecha.Location = new System.Drawing.Point(-2, 438);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(133, 19);
            this.LbFecha.TabIndex = 64;
            this.LbFecha.Text = "Fecha de proyección:";
            this.LbFecha.UseCustomBackColor = true;
            this.LbFecha.UseCustomForeColor = true;
            this.LbFecha.UseStyleColors = true;
            // 
            // DtFecha
            // 
            this.DtFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.DtFecha.CustomFormat = "yyyMMdd";
            this.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFecha.Location = new System.Drawing.Point(137, 428);
            this.DtFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(152, 29);
            this.DtFecha.TabIndex = 65;
            this.DtFecha.UseCustomBackColor = true;
            this.DtFecha.UseCustomForeColor = true;
            this.DtFecha.UseStyleColors = true;
            // 
            // txtPrecio
            // 
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(137, 479);
            this.txtPrecio.MaxLength = 5;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(152, 23);
            this.txtPrecio.TabIndex = 67;
            this.txtPrecio.UseCustomBackColor = true;
            this.txtPrecio.UseCustomForeColor = true;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.UseStyleColors = true;
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbPrecio.Location = new System.Drawing.Point(76, 483);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(49, 19);
            this.lbPrecio.TabIndex = 66;
            this.lbPrecio.Text = "Precio:";
            this.lbPrecio.UseCustomBackColor = true;
            this.lbPrecio.UseCustomForeColor = true;
            this.lbPrecio.UseStyleColors = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(216, 525);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 33);
            this.btnAceptar.TabIndex = 68;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseCustomBackColor = true;
            this.btnAceptar.UseCustomForeColor = true;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboDuracion
            // 
            this.cboDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboDuracion.FormattingEnabled = true;
            this.cboDuracion.ItemHeight = 23;
            this.cboDuracion.Location = new System.Drawing.Point(373, 203);
            this.cboDuracion.Name = "cboDuracion";
            this.cboDuracion.Size = new System.Drawing.Size(132, 29);
            this.cboDuracion.TabIndex = 69;
            this.cboDuracion.UseCustomBackColor = true;
            this.cboDuracion.UseCustomForeColor = true;
            this.cboDuracion.UseSelectable = true;
            this.cboDuracion.UseStyleColors = true;
            this.cboDuracion.Visible = false;
            // 
            // btnDuracion
            // 
            this.btnDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnDuracion.ForeColor = System.Drawing.Color.White;
            this.btnDuracion.Location = new System.Drawing.Point(295, 260);
            this.btnDuracion.Name = "btnDuracion";
            this.btnDuracion.Size = new System.Drawing.Size(96, 25);
            this.btnDuracion.TabIndex = 70;
            this.btnDuracion.Text = "ver duración";
            this.btnDuracion.UseCustomBackColor = true;
            this.btnDuracion.UseCustomForeColor = true;
            this.btnDuracion.UseSelectable = true;
            this.btnDuracion.UseStyleColors = true;
            this.btnDuracion.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtDuracion
            // 
            // 
            // 
            // 
            this.txtDuracion.CustomButton.Image = null;
            this.txtDuracion.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtDuracion.CustomButton.Name = "";
            this.txtDuracion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDuracion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDuracion.CustomButton.TabIndex = 1;
            this.txtDuracion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDuracion.CustomButton.UseSelectable = true;
            this.txtDuracion.CustomButton.Visible = false;
            this.txtDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtDuracion.Lines = new string[] {
        "HH:MM:SS"};
            this.txtDuracion.Location = new System.Drawing.Point(295, 291);
            this.txtDuracion.MaxLength = 8;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.PasswordChar = '\0';
            this.txtDuracion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDuracion.SelectedText = "";
            this.txtDuracion.SelectionLength = 0;
            this.txtDuracion.SelectionStart = 0;
            this.txtDuracion.ShortcutsEnabled = true;
            this.txtDuracion.Size = new System.Drawing.Size(152, 23);
            this.txtDuracion.TabIndex = 71;
            this.txtDuracion.Text = "HH:MM:SS";
            this.txtDuracion.UseCustomBackColor = true;
            this.txtDuracion.UseCustomForeColor = true;
            this.txtDuracion.UseSelectable = true;
            this.txtDuracion.UseStyleColors = true;
            this.txtDuracion.Visible = false;
            this.txtDuracion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDuracion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmProyeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(398, 570);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.btnDuracion);
            this.Controls.Add(this.cboDuracion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.LbHoraFin);
            this.Controls.Add(this.txtHoraIni);
            this.Controls.Add(this.LbHoraIni);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.lbPelicula);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.lbSalas);
            this.Controls.Add(this.lbNuevoEmp);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProyeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyeccion";
            this.Load += new System.EventHandler(this.FrmProyeccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbNuevoEmp;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbSalas;
        private MetroFramework.Controls.MetroComboBox cboSala;
        private MetroFramework.Controls.MetroLabel lbPelicula;
        private MetroFramework.Controls.MetroComboBox cboPelicula;
        private MetroFramework.Controls.MetroLabel LbHoraIni;
        private MetroFramework.Controls.MetroTextBox txtHoraIni;
        private MetroFramework.Controls.MetroTextBox txtHoraFin;
        private MetroFramework.Controls.MetroLabel LbHoraFin;
        private MetroFramework.Controls.MetroLabel LbFecha;
        private MetroFramework.Controls.MetroDateTime DtFecha;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroLabel lbPrecio;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroComboBox cboDuracion;
        private MetroFramework.Controls.MetroButton btnDuracion;
        private MetroFramework.Controls.MetroTextBox txtDuracion;
    }
}