namespace CapaVista
{
    partial class FrmPelicula
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
            this.lbIdentificacion = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDuracion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtidPelicula = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cboTipoPel = new MetroFramework.Controls.MetroComboBox();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.cboGenPeli = new MetroFramework.Controls.MetroComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbNuevoEmp
            // 
            this.lbNuevoEmp.AutoSize = true;
            this.lbNuevoEmp.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoEmp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoEmp.Location = new System.Drawing.Point(100, 15);
            this.lbNuevoEmp.Name = "lbNuevoEmp";
            this.lbNuevoEmp.Size = new System.Drawing.Size(145, 25);
            this.lbNuevoEmp.TabIndex = 4;
            this.lbNuevoEmp.Text = "NUEVA PELÍCULA";
            this.lbNuevoEmp.UseCustomBackColor = true;
            this.lbNuevoEmp.UseCustomForeColor = true;
            this.lbNuevoEmp.UseStyleColors = true;
            this.lbNuevoEmp.WrapToLine = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.film;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(114, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 103);
            this.panel1.TabIndex = 3;
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbIdentificacion.Location = new System.Drawing.Point(12, 394);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(122, 19);
            this.lbIdentificacion.TabIndex = 30;
            this.lbIdentificacion.Text = "Género de pelicula:";
            this.lbIdentificacion.UseCustomBackColor = true;
            this.lbIdentificacion.UseCustomForeColor = true;
            this.lbIdentificacion.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel2.Location = new System.Drawing.Point(44, 329);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Tipo Película:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // txtDuracion
            // 
            // 
            // 
            // 
            this.txtDuracion.CustomButton.Image = null;
            this.txtDuracion.CustomButton.Location = new System.Drawing.Point(127, 1);
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
            this.txtDuracion.Location = new System.Drawing.Point(140, 274);
            this.txtDuracion.MaxLength = 8;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.PasswordChar = '\0';
            this.txtDuracion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDuracion.SelectedText = "";
            this.txtDuracion.SelectionLength = 0;
            this.txtDuracion.SelectionStart = 0;
            this.txtDuracion.ShortcutsEnabled = true;
            this.txtDuracion.Size = new System.Drawing.Size(149, 23);
            this.txtDuracion.TabIndex = 37;
            this.txtDuracion.Text = "HH:MM:SS";
            this.txtDuracion.UseCustomBackColor = true;
            this.txtDuracion.UseCustomForeColor = true;
            this.txtDuracion.UseSelectable = true;
            this.txtDuracion.UseStyleColors = true;
            this.txtDuracion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDuracion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel3.Location = new System.Drawing.Point(61, 274);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "Duración:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // txtNom
            // 
            // 
            // 
            // 
            this.txtNom.CustomButton.Image = null;
            this.txtNom.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtNom.CustomButton.Name = "";
            this.txtNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNom.CustomButton.TabIndex = 1;
            this.txtNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNom.CustomButton.UseSelectable = true;
            this.txtNom.CustomButton.Visible = false;
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtNom.Lines = new string[0];
            this.txtNom.Location = new System.Drawing.Point(140, 229);
            this.txtNom.MaxLength = 45;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(149, 23);
            this.txtNom.TabIndex = 39;
            this.txtNom.UseCustomBackColor = true;
            this.txtNom.UseCustomForeColor = true;
            this.txtNom.UseSelectable = true;
            this.txtNom.UseStyleColors = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel4.Location = new System.Drawing.Point(61, 229);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Nombre:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtidPelicula
            // 
            // 
            // 
            // 
            this.txtidPelicula.CustomButton.Image = null;
            this.txtidPelicula.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtidPelicula.CustomButton.Name = "";
            this.txtidPelicula.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtidPelicula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtidPelicula.CustomButton.TabIndex = 1;
            this.txtidPelicula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtidPelicula.CustomButton.UseSelectable = true;
            this.txtidPelicula.CustomButton.Visible = false;
            this.txtidPelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtidPelicula.Lines = new string[0];
            this.txtidPelicula.Location = new System.Drawing.Point(140, 172);
            this.txtidPelicula.MaxLength = 11;
            this.txtidPelicula.Name = "txtidPelicula";
            this.txtidPelicula.PasswordChar = '\0';
            this.txtidPelicula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtidPelicula.SelectedText = "";
            this.txtidPelicula.SelectionLength = 0;
            this.txtidPelicula.SelectionStart = 0;
            this.txtidPelicula.ShortcutsEnabled = true;
            this.txtidPelicula.Size = new System.Drawing.Size(149, 23);
            this.txtidPelicula.TabIndex = 41;
            this.txtidPelicula.UseCustomBackColor = true;
            this.txtidPelicula.UseCustomForeColor = true;
            this.txtidPelicula.UseSelectable = true;
            this.txtidPelicula.UseStyleColors = true;
            this.txtidPelicula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtidPelicula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel5.Location = new System.Drawing.Point(12, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 19);
            this.metroLabel5.TabIndex = 40;
            this.metroLabel5.Text = "Código de Película:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // cboTipoPel
            // 
            this.cboTipoPel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboTipoPel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboTipoPel.FormattingEnabled = true;
            this.cboTipoPel.ItemHeight = 23;
            this.cboTipoPel.Location = new System.Drawing.Point(140, 326);
            this.cboTipoPel.Name = "cboTipoPel";
            this.cboTipoPel.Size = new System.Drawing.Size(149, 29);
            this.cboTipoPel.TabIndex = 54;
            this.cboTipoPel.UseCustomBackColor = true;
            this.cboTipoPel.UseCustomForeColor = true;
            this.cboTipoPel.UseSelectable = true;
            this.cboTipoPel.UseStyleColors = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(138, 468);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 33);
            this.btnAceptar.TabIndex = 55;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseCustomBackColor = true;
            this.btnAceptar.UseCustomForeColor = true;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboGenPeli
            // 
            this.cboGenPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboGenPeli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboGenPeli.FormattingEnabled = true;
            this.cboGenPeli.ItemHeight = 23;
            this.cboGenPeli.Location = new System.Drawing.Point(140, 391);
            this.cboGenPeli.Name = "cboGenPeli";
            this.cboGenPeli.Size = new System.Drawing.Size(149, 29);
            this.cboGenPeli.TabIndex = 56;
            this.cboGenPeli.UseCustomBackColor = true;
            this.cboGenPeli.UseCustomForeColor = true;
            this.cboGenPeli.UseSelectable = true;
            this.cboGenPeli.UseStyleColors = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(314, 513);
            this.Controls.Add(this.cboGenPeli);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboTipoPel);
            this.Controls.Add(this.txtidPelicula);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbIdentificacion);
            this.Controls.Add(this.lbNuevoEmp);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Name = "FrmPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Peliculas";
            this.Load += new System.EventHandler(this.FrmPelicula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbNuevoEmp;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbIdentificacion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDuracion;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtidPelicula;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cboTipoPel;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroComboBox cboGenPeli;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}