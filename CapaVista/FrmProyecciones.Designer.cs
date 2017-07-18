namespace CapaVista
{
    partial class FrmProyecciones
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
            this.SuspendLayout();
            // 
            // lbNuevoEmp
            // 
            this.lbNuevoEmp.AutoSize = true;
            this.lbNuevoEmp.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoEmp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoEmp.Location = new System.Drawing.Point(159, 9);
            this.lbNuevoEmp.Name = "lbNuevoEmp";
            this.lbNuevoEmp.Size = new System.Drawing.Size(176, 25);
            this.lbNuevoEmp.TabIndex = 6;
            this.lbNuevoEmp.Text = "NUEVA PROYECCIÓN";
            this.lbNuevoEmp.UseCustomBackColor = true;
            this.lbNuevoEmp.UseCustomForeColor = true;
            this.lbNuevoEmp.UseStyleColors = true;
            this.lbNuevoEmp.WrapToLine = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.video_player;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(186, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 103);
            this.panel1.TabIndex = 5;
            // 
            // FrmProyecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(481, 502);
            this.Controls.Add(this.lbNuevoEmp);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.Name = "FrmProyecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbNuevoEmp;
        private System.Windows.Forms.Panel panel1;
    }
}