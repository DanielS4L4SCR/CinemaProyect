namespace CapaVista
{
    partial class FrmReporteCliente
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
            this.cboClientes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cboResultado = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lbNuevoEmp
            // 
            this.lbNuevoEmp.AutoSize = true;
            this.lbNuevoEmp.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoEmp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoEmp.Location = new System.Drawing.Point(57, 9);
            this.lbNuevoEmp.Name = "lbNuevoEmp";
            this.lbNuevoEmp.Size = new System.Drawing.Size(279, 25);
            this.lbNuevoEmp.TabIndex = 102;
            this.lbNuevoEmp.Text = "CANTIDAD DE CLIENTES POR TIPO";
            this.lbNuevoEmp.UseCustomBackColor = true;
            this.lbNuevoEmp.UseCustomForeColor = true;
            this.lbNuevoEmp.UseStyleColors = true;
            this.lbNuevoEmp.WrapToLine = true;
            // 
            // cboClientes
            // 
            this.cboClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.ItemHeight = 23;
            this.cboClientes.Location = new System.Drawing.Point(151, 108);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(111, 29);
            this.cboClientes.TabIndex = 103;
            this.cboClientes.UseCustomBackColor = true;
            this.cboClientes.UseCustomForeColor = true;
            this.cboClientes.UseSelectable = true;
            this.cboClientes.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel5.Location = new System.Drawing.Point(53, 122);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 15);
            this.metroLabel5.TabIndex = 109;
            this.metroLabel5.Text = "Tipos de clientes:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.WrapToLine = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(268, 108);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(62, 29);
            this.metroButton1.TabIndex = 110;
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
            this.cboResultado.Location = new System.Drawing.Point(151, 63);
            this.cboResultado.Name = "cboResultado";
            this.cboResultado.Size = new System.Drawing.Size(111, 29);
            this.cboResultado.TabIndex = 111;
            this.cboResultado.UseCustomBackColor = true;
            this.cboResultado.UseCustomForeColor = true;
            this.cboResultado.UseSelectable = true;
            this.cboResultado.UseStyleColors = true;
            this.cboResultado.Visible = false;
            // 
            // FrmReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(342, 145);
            this.Controls.Add(this.cboResultado);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.lbNuevoEmp);
            this.Name = "FrmReporteCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteCliente";
            this.Load += new System.EventHandler(this.FrmReporteCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbNuevoEmp;
        private MetroFramework.Controls.MetroComboBox cboClientes;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cboResultado;
    }
}