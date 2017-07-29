namespace CapaVista
{
    partial class FrmReporteFondos
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cboResultadoMoney = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lbNuevoEmp
            // 
            this.lbNuevoEmp.AutoSize = true;
            this.lbNuevoEmp.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoEmp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoEmp.Location = new System.Drawing.Point(32, 9);
            this.lbNuevoEmp.Name = "lbNuevoEmp";
            this.lbNuevoEmp.Size = new System.Drawing.Size(259, 25);
            this.lbNuevoEmp.TabIndex = 102;
            this.lbNuevoEmp.Text = "TOTAL DE DINERO RECAUDADO";
            this.lbNuevoEmp.UseCustomBackColor = true;
            this.lbNuevoEmp.UseCustomForeColor = true;
            this.lbNuevoEmp.UseStyleColors = true;
            this.lbNuevoEmp.WrapToLine = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.icons8_Monedas_50;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(119, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 58);
            this.panel1.TabIndex = 103;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(88, 212);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(135, 29);
            this.metroButton1.TabIndex = 104;
            this.metroButton1.Text = "Consultar";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cboResultadoMoney
            // 
            this.cboResultadoMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboResultadoMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboResultadoMoney.FormattingEnabled = true;
            this.cboResultadoMoney.ItemHeight = 23;
            this.cboResultadoMoney.Location = new System.Drawing.Point(280, 169);
            this.cboResultadoMoney.Name = "cboResultadoMoney";
            this.cboResultadoMoney.Size = new System.Drawing.Size(100, 29);
            this.cboResultadoMoney.TabIndex = 111;
            this.cboResultadoMoney.UseCustomBackColor = true;
            this.cboResultadoMoney.UseCustomForeColor = true;
            this.cboResultadoMoney.UseSelectable = true;
            this.cboResultadoMoney.UseStyleColors = true;
            this.cboResultadoMoney.Visible = false;
            this.cboResultadoMoney.SelectedIndexChanged += new System.EventHandler(this.cboResultadoMoney_SelectedIndexChanged);
            // 
            // FrmReporteFondos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(303, 253);
            this.Controls.Add(this.cboResultadoMoney);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNuevoEmp);
            this.Name = "FrmReporteFondos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteFondos";
            this.Load += new System.EventHandler(this.FrmReporteFondos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbNuevoEmp;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cboResultadoMoney;
    }
}