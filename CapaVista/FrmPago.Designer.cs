namespace CapaVista
{
    partial class FrmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTarjeta = new MetroFramework.Controls.MetroRadioButton();
            this.rbEfectivo = new MetroFramework.Controls.MetroRadioButton();
            this.lbNuevoCliente = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFactura = new MetroFramework.Controls.MetroComboBox();
            this.cboMonto = new MetroFramework.Controls.MetroComboBox();
            this.lbFactura = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.txtFactura = new MetroFramework.Controls.MetroTextBox();
            this.txtMonto = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTarjeta);
            this.groupBox1.Controls.Add(this.rbEfectivo);
            this.groupBox1.Location = new System.Drawing.Point(71, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbTarjeta.Location = new System.Drawing.Point(138, 15);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(58, 15);
            this.rbTarjeta.TabIndex = 2;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseCustomBackColor = true;
            this.rbTarjeta.UseCustomForeColor = true;
            this.rbTarjeta.UseSelectable = true;
            this.rbTarjeta.UseStyleColors = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbEfectivo.Location = new System.Drawing.Point(30, 15);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(65, 15);
            this.rbEfectivo.TabIndex = 1;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseCustomBackColor = true;
            this.rbEfectivo.UseCustomForeColor = true;
            this.rbEfectivo.UseSelectable = true;
            this.rbEfectivo.UseStyleColors = true;
            // 
            // lbNuevoCliente
            // 
            this.lbNuevoCliente.AutoSize = true;
            this.lbNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoCliente.Location = new System.Drawing.Point(168, 9);
            this.lbNuevoCliente.Name = "lbNuevoCliente";
            this.lbNuevoCliente.Size = new System.Drawing.Size(57, 25);
            this.lbNuevoCliente.TabIndex = 5;
            this.lbNuevoCliente.Text = "PAGO";
            this.lbNuevoCliente.UseCustomBackColor = true;
            this.lbNuevoCliente.UseCustomForeColor = true;
            this.lbNuevoCliente.UseStyleColors = true;
            this.lbNuevoCliente.WrapToLine = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.icons8_Caja_registradora_501;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(150, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 82);
            this.panel1.TabIndex = 4;
            // 
            // cboFactura
            // 
            this.cboFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboFactura.FormattingEnabled = true;
            this.cboFactura.ItemHeight = 23;
            this.cboFactura.Location = new System.Drawing.Point(303, 196);
            this.cboFactura.Name = "cboFactura";
            this.cboFactura.Size = new System.Drawing.Size(47, 29);
            this.cboFactura.TabIndex = 60;
            this.cboFactura.UseCustomBackColor = true;
            this.cboFactura.UseCustomForeColor = true;
            this.cboFactura.UseSelectable = true;
            this.cboFactura.UseStyleColors = true;
            this.cboFactura.Visible = false;
            // 
            // cboMonto
            // 
            this.cboMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboMonto.FormattingEnabled = true;
            this.cboMonto.ItemHeight = 23;
            this.cboMonto.Location = new System.Drawing.Point(303, 244);
            this.cboMonto.Name = "cboMonto";
            this.cboMonto.Size = new System.Drawing.Size(47, 29);
            this.cboMonto.TabIndex = 61;
            this.cboMonto.UseCustomBackColor = true;
            this.cboMonto.UseCustomForeColor = true;
            this.cboMonto.UseSelectable = true;
            this.cboMonto.UseStyleColors = true;
            this.cboMonto.Visible = false;
            // 
            // lbFactura
            // 
            this.lbFactura.AutoSize = true;
            this.lbFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbFactura.Location = new System.Drawing.Point(91, 202);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(54, 19);
            this.lbFactura.TabIndex = 62;
            this.lbFactura.Text = "Factura:";
            this.lbFactura.UseCustomBackColor = true;
            this.lbFactura.UseCustomForeColor = true;
            this.lbFactura.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel1.Location = new System.Drawing.Point(94, 250);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 63;
            this.metroLabel1.Text = "Monto:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(219, 333);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 33);
            this.btnAceptar.TabIndex = 66;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseCustomBackColor = true;
            this.btnAceptar.UseCustomForeColor = true;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtFactura
            // 
            // 
            // 
            // 
            this.txtFactura.CustomButton.Image = null;
            this.txtFactura.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtFactura.CustomButton.Name = "";
            this.txtFactura.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFactura.CustomButton.TabIndex = 1;
            this.txtFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFactura.CustomButton.UseSelectable = true;
            this.txtFactura.CustomButton.Visible = false;
            this.txtFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtFactura.Lines = new string[0];
            this.txtFactura.Location = new System.Drawing.Point(148, 202);
            this.txtFactura.MaxLength = 32767;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.PasswordChar = '\0';
            this.txtFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFactura.SelectedText = "";
            this.txtFactura.SelectionLength = 0;
            this.txtFactura.SelectionStart = 0;
            this.txtFactura.ShortcutsEnabled = true;
            this.txtFactura.Size = new System.Drawing.Size(149, 23);
            this.txtFactura.TabIndex = 67;
            this.txtFactura.UseCustomBackColor = true;
            this.txtFactura.UseCustomForeColor = true;
            this.txtFactura.UseSelectable = true;
            this.txtFactura.UseStyleColors = true;
            this.txtFactura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFactura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMonto
            // 
            // 
            // 
            // 
            this.txtMonto.CustomButton.Image = null;
            this.txtMonto.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtMonto.CustomButton.Name = "";
            this.txtMonto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMonto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMonto.CustomButton.TabIndex = 1;
            this.txtMonto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMonto.CustomButton.UseSelectable = true;
            this.txtMonto.CustomButton.Visible = false;
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtMonto.Lines = new string[0];
            this.txtMonto.Location = new System.Drawing.Point(148, 250);
            this.txtMonto.MaxLength = 32767;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMonto.SelectedText = "";
            this.txtMonto.SelectionLength = 0;
            this.txtMonto.SelectionStart = 0;
            this.txtMonto.ShortcutsEnabled = true;
            this.txtMonto.Size = new System.Drawing.Size(149, 23);
            this.txtMonto.TabIndex = 68;
            this.txtMonto.UseCustomBackColor = true;
            this.txtMonto.UseCustomForeColor = true;
            this.txtMonto.UseSelectable = true;
            this.txtMonto.UseStyleColors = true;
            this.txtMonto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMonto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(362, 378);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbFactura);
            this.Controls.Add(this.cboMonto);
            this.Controls.Add(this.cboFactura);
            this.Controls.Add(this.lbNuevoCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rbTarjeta;
        private MetroFramework.Controls.MetroRadioButton rbEfectivo;
        private MetroFramework.Controls.MetroLabel lbNuevoCliente;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox cboFactura;
        private MetroFramework.Controls.MetroComboBox cboMonto;
        private MetroFramework.Controls.MetroLabel lbFactura;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroTextBox txtFactura;
        private MetroFramework.Controls.MetroTextBox txtMonto;
    }
}