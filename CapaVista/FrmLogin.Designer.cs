namespace CapaVista
{
    partial class FrmLogin
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
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtContraseña = new MetroFramework.Controls.MetroTextBox();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(179, 82);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(114, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContraseña
            // 
            // 
            // 
            // 
            this.txtContraseña.CustomButton.Image = null;
            this.txtContraseña.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtContraseña.CustomButton.Name = "";
            this.txtContraseña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContraseña.CustomButton.TabIndex = 1;
            this.txtContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContraseña.CustomButton.UseSelectable = true;
            this.txtContraseña.CustomButton.Visible = false;
            this.txtContraseña.Lines = new string[0];
            this.txtContraseña.Location = new System.Drawing.Point(179, 141);
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.ShortcutsEnabled = true;
            this.txtContraseña.Size = new System.Drawing.Size(114, 23);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.UseSelectable = true;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(205, 190);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(88, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbUsuario.Location = new System.Drawing.Point(112, 88);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(61, 17);
            this.lbUsuario.TabIndex = 5;
            this.lbUsuario.Text = "Usuario:";
            this.lbUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPassword.Location = new System.Drawing.Point(88, 141);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(85, 17);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Contraseña:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 230);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FrmLogin";
            this.Text = "CinemaPRO Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtContraseña;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPassword;
    }
}