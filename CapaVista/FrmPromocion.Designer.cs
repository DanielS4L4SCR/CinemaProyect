namespace CapaVista
{
    partial class FrmPromocion
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
            this.cboProyecciones = new MetroFramework.Controls.MetroComboBox();
            this.lblProyecciones = new MetroFramework.Controls.MetroLabel();
            this.lbNuevoEmp = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescuento = new MetroFramework.Controls.MetroLabel();
            this.cboTipoCliente = new MetroFramework.Controls.MetroComboBox();
            this.lblTipoCliente = new MetroFramework.Controls.MetroLabel();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.txtDescuento = new MetroFramework.Controls.MetroTextBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cboProyecciones
            // 
            this.cboProyecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboProyecciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboProyecciones.FormattingEnabled = true;
            this.cboProyecciones.ItemHeight = 23;
            this.cboProyecciones.Location = new System.Drawing.Point(150, 126);
            this.cboProyecciones.Name = "cboProyecciones";
            this.cboProyecciones.Size = new System.Drawing.Size(155, 29);
            this.cboProyecciones.TabIndex = 55;
            this.cboProyecciones.UseCustomBackColor = true;
            this.cboProyecciones.UseCustomForeColor = true;
            this.cboProyecciones.UseSelectable = true;
            this.cboProyecciones.UseStyleColors = true;
            this.cboProyecciones.SelectedIndexChanged += new System.EventHandler(this.cboProyecciones_SelectedIndexChanged);
            this.cboProyecciones.Click += new System.EventHandler(this.cboProyecciones_SelectedIndexChanged);
            // 
            // lblProyecciones
            // 
            this.lblProyecciones.AutoSize = true;
            this.lblProyecciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lblProyecciones.Location = new System.Drawing.Point(56, 136);
            this.lblProyecciones.Name = "lblProyecciones";
            this.lblProyecciones.Size = new System.Drawing.Size(88, 19);
            this.lblProyecciones.TabIndex = 54;
            this.lblProyecciones.Text = "Proyecciones:";
            this.lblProyecciones.UseCustomBackColor = true;
            this.lblProyecciones.UseCustomForeColor = true;
            this.lblProyecciones.UseStyleColors = true;
            // 
            // lbNuevoEmp
            // 
            this.lbNuevoEmp.AutoSize = true;
            this.lbNuevoEmp.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoEmp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoEmp.Location = new System.Drawing.Point(108, 9);
            this.lbNuevoEmp.Name = "lbNuevoEmp";
            this.lbNuevoEmp.Size = new System.Drawing.Size(176, 25);
            this.lbNuevoEmp.TabIndex = 57;
            this.lbNuevoEmp.Text = "NUEVA PROMOCIÓN";
            this.lbNuevoEmp.UseCustomBackColor = true;
            this.lbNuevoEmp.UseCustomForeColor = true;
            this.lbNuevoEmp.UseStyleColors = true;
            this.lbNuevoEmp.WrapToLine = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.icons8_Discount_50;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(148, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 66);
            this.panel1.TabIndex = 56;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lblDescuento.Location = new System.Drawing.Point(-6, 176);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(155, 19);
            this.lblDescuento.TabIndex = 58;
            this.lblDescuento.Text = "Porcentaje de descuento:";
            this.lblDescuento.UseCustomBackColor = true;
            this.lblDescuento.UseCustomForeColor = true;
            this.lblDescuento.UseStyleColors = true;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboTipoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.ItemHeight = 23;
            this.cboTipoCliente.Location = new System.Drawing.Point(150, 262);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(155, 29);
            this.cboTipoCliente.TabIndex = 61;
            this.cboTipoCliente.UseCustomBackColor = true;
            this.cboTipoCliente.UseCustomForeColor = true;
            this.cboTipoCliente.UseSelectable = true;
            this.cboTipoCliente.UseStyleColors = true;
            this.cboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cboTipoCliente_SelectedIndexChanged);
            this.cboTipoCliente.Click += new System.EventHandler(this.cboTipoCliente_SelectedIndexChanged);
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lblTipoCliente.Location = new System.Drawing.Point(62, 272);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(82, 19);
            this.lblTipoCliente.TabIndex = 60;
            this.lblTipoCliente.Text = "Tipo Cliente:";
            this.lblTipoCliente.UseCustomBackColor = true;
            this.lblTipoCliente.UseCustomForeColor = true;
            this.lblTipoCliente.UseStyleColors = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lblDescripcion.Location = new System.Drawing.Point(56, 227);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcion.TabIndex = 62;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.UseCustomBackColor = true;
            this.lblDescripcion.UseCustomForeColor = true;
            this.lblDescripcion.UseStyleColors = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(163, 345);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(196, 33);
            this.btnAceptar.TabIndex = 64;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseCustomBackColor = true;
            this.btnAceptar.UseCustomForeColor = true;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescuento
            // 
            // 
            // 
            // 
            this.txtDescuento.CustomButton.Image = null;
            this.txtDescuento.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtDescuento.CustomButton.Name = "";
            this.txtDescuento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescuento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescuento.CustomButton.TabIndex = 1;
            this.txtDescuento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescuento.CustomButton.UseSelectable = true;
            this.txtDescuento.CustomButton.Visible = false;
            this.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtDescuento.Lines = new string[0];
            this.txtDescuento.Location = new System.Drawing.Point(150, 172);
            this.txtDescuento.MaxLength = 32767;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.ShortcutsEnabled = true;
            this.txtDescuento.Size = new System.Drawing.Size(155, 23);
            this.txtDescuento.TabIndex = 65;
            this.txtDescuento.UseCustomBackColor = true;
            this.txtDescuento.UseCustomForeColor = true;
            this.txtDescuento.UseSelectable = true;
            this.txtDescuento.UseStyleColors = true;
            this.txtDescuento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescuento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(150, 223);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(155, 23);
            this.txtDescripcion.TabIndex = 66;
            this.txtDescripcion.UseCustomBackColor = true;
            this.txtDescripcion.UseCustomForeColor = true;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.UseStyleColors = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(371, 393);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lbNuevoEmp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboProyecciones);
            this.Controls.Add(this.lblProyecciones);
            this.Name = "FrmPromocion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPromocion";
            this.Load += new System.EventHandler(this.FrmPromocion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboProyecciones;
        private MetroFramework.Controls.MetroLabel lblProyecciones;
        private MetroFramework.Controls.MetroLabel lbNuevoEmp;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lblDescuento;
        private MetroFramework.Controls.MetroComboBox cboTipoCliente;
        private MetroFramework.Controls.MetroLabel lblTipoCliente;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroTextBox txtDescuento;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
    }
}