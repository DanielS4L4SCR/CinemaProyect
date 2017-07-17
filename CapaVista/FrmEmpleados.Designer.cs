namespace CapaVista
{
    partial class FrmEmpleados
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
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.txtApe2 = new MetroFramework.Controls.MetroTextBox();
            this.txtApe1 = new MetroFramework.Controls.MetroTextBox();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.lbOpcional = new MetroFramework.Controls.MetroLabel();
            this.lbApellido2 = new MetroFramework.Controls.MetroLabel();
            this.lbApellido = new MetroFramework.Controls.MetroLabel();
            this.lnNombre = new MetroFramework.Controls.MetroLabel();
            this.lbIdentificacion = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbExtranjero = new MetroFramework.Controls.MetroRadioButton();
            this.rbNacional = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLimpiador = new MetroFramework.Controls.MetroRadioButton();
            this.rbCajero = new MetroFramework.Controls.MetroRadioButton();
            this.rbAdmin = new MetroFramework.Controls.MetroRadioButton();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.lbUser = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CboxAddUser = new MetroFramework.Controls.MetroCheckBox();
            this.txtTel = new MetroFramework.Controls.MetroTextBox();
            this.lbTel = new MetroFramework.Controls.MetroLabel();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.lbMain = new MetroFramework.Controls.MetroLabel();
            this.cboMail = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboProv = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.cboCanton = new MetroFramework.Controls.MetroComboBox();
            this.cboDistri = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTel = new MetroFramework.Controls.MetroComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new MetroFramework.Controls.MetroRadioButton();
            this.rbMale = new MetroFramework.Controls.MetroRadioButton();
            this.txtGenero = new MetroFramework.Controls.MetroLabel();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNuevoEmp
            // 
            this.lbNuevoEmp.AutoSize = true;
            this.lbNuevoEmp.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoEmp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoEmp.Location = new System.Drawing.Point(152, 9);
            this.lbNuevoEmp.Name = "lbNuevoEmp";
            this.lbNuevoEmp.Size = new System.Drawing.Size(164, 25);
            this.lbNuevoEmp.TabIndex = 2;
            this.lbNuevoEmp.Text = "NUEVO EMPLEADO";
            this.lbNuevoEmp.UseCustomBackColor = true;
            this.lbNuevoEmp.UseCustomForeColor = true;
            this.lbNuevoEmp.UseStyleColors = true;
            this.lbNuevoEmp.WrapToLine = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(149, 894);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(196, 33);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseCustomBackColor = true;
            this.btnAceptar.UseCustomForeColor = true;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtApe2
            // 
            // 
            // 
            // 
            this.txtApe2.CustomButton.Image = null;
            this.txtApe2.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtApe2.CustomButton.Name = "";
            this.txtApe2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApe2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApe2.CustomButton.TabIndex = 1;
            this.txtApe2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApe2.CustomButton.UseSelectable = true;
            this.txtApe2.CustomButton.Visible = false;
            this.txtApe2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtApe2.Lines = new string[0];
            this.txtApe2.Location = new System.Drawing.Point(181, 420);
            this.txtApe2.MaxLength = 32767;
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.PasswordChar = '\0';
            this.txtApe2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApe2.SelectedText = "";
            this.txtApe2.SelectionLength = 0;
            this.txtApe2.SelectionStart = 0;
            this.txtApe2.ShortcutsEnabled = true;
            this.txtApe2.Size = new System.Drawing.Size(149, 23);
            this.txtApe2.TabIndex = 32;
            this.txtApe2.UseCustomBackColor = true;
            this.txtApe2.UseCustomForeColor = true;
            this.txtApe2.UseSelectable = true;
            this.txtApe2.UseStyleColors = true;
            this.txtApe2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApe2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApe1
            // 
            // 
            // 
            // 
            this.txtApe1.CustomButton.Image = null;
            this.txtApe1.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtApe1.CustomButton.Name = "";
            this.txtApe1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApe1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApe1.CustomButton.TabIndex = 1;
            this.txtApe1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApe1.CustomButton.UseSelectable = true;
            this.txtApe1.CustomButton.Visible = false;
            this.txtApe1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtApe1.Lines = new string[0];
            this.txtApe1.Location = new System.Drawing.Point(181, 382);
            this.txtApe1.MaxLength = 32767;
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.PasswordChar = '\0';
            this.txtApe1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApe1.SelectedText = "";
            this.txtApe1.SelectionLength = 0;
            this.txtApe1.SelectionStart = 0;
            this.txtApe1.ShortcutsEnabled = true;
            this.txtApe1.Size = new System.Drawing.Size(149, 23);
            this.txtApe1.TabIndex = 31;
            this.txtApe1.UseCustomBackColor = true;
            this.txtApe1.UseCustomForeColor = true;
            this.txtApe1.UseSelectable = true;
            this.txtApe1.UseStyleColors = true;
            this.txtApe1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApe1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNom.Location = new System.Drawing.Point(181, 341);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(149, 23);
            this.txtNom.TabIndex = 30;
            this.txtNom.UseCustomBackColor = true;
            this.txtNom.UseCustomForeColor = true;
            this.txtNom.UseSelectable = true;
            this.txtNom.UseStyleColors = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(181, 299);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(149, 23);
            this.txtID.TabIndex = 29;
            this.txtID.UseCustomBackColor = true;
            this.txtID.UseCustomForeColor = true;
            this.txtID.UseSelectable = true;
            this.txtID.UseStyleColors = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbOpcional
            // 
            this.lbOpcional.AutoSize = true;
            this.lbOpcional.ForeColor = System.Drawing.Color.Brown;
            this.lbOpcional.Location = new System.Drawing.Point(328, 424);
            this.lbOpcional.Name = "lbOpcional";
            this.lbOpcional.Size = new System.Drawing.Size(86, 19);
            this.lbOpcional.TabIndex = 28;
            this.lbOpcional.Text = "*OPCIONAL*";
            this.lbOpcional.UseCustomBackColor = true;
            this.lbOpcional.UseCustomForeColor = true;
            this.lbOpcional.UseStyleColors = true;
            this.lbOpcional.Visible = false;
            // 
            // lbApellido2
            // 
            this.lbApellido2.AutoSize = true;
            this.lbApellido2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbApellido2.Location = new System.Drawing.Point(100, 424);
            this.lbApellido2.Name = "lbApellido2";
            this.lbApellido2.Size = new System.Drawing.Size(68, 19);
            this.lbApellido2.TabIndex = 27;
            this.lbApellido2.Text = "Apellido2:";
            this.lbApellido2.UseCustomBackColor = true;
            this.lbApellido2.UseCustomForeColor = true;
            this.lbApellido2.UseStyleColors = true;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbApellido.Location = new System.Drawing.Point(101, 382);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(66, 19);
            this.lbApellido.TabIndex = 26;
            this.lbApellido.Text = "Apellido1:";
            this.lbApellido.UseCustomBackColor = true;
            this.lbApellido.UseCustomForeColor = true;
            this.lbApellido.UseStyleColors = true;
            // 
            // lnNombre
            // 
            this.lnNombre.AutoSize = true;
            this.lnNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lnNombre.Location = new System.Drawing.Point(105, 341);
            this.lnNombre.Name = "lnNombre";
            this.lnNombre.Size = new System.Drawing.Size(62, 19);
            this.lnNombre.TabIndex = 25;
            this.lnNombre.Text = "Nombre:";
            this.lnNombre.UseCustomBackColor = true;
            this.lnNombre.UseCustomForeColor = true;
            this.lnNombre.UseStyleColors = true;
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbIdentificacion.Location = new System.Drawing.Point(83, 299);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(88, 19);
            this.lbIdentificacion.TabIndex = 24;
            this.lbIdentificacion.Text = "Identificación:";
            this.lbIdentificacion.UseCustomBackColor = true;
            this.lbIdentificacion.UseCustomForeColor = true;
            this.lbIdentificacion.UseStyleColors = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbExtranjero);
            this.groupBox4.Controls.Add(this.rbNacional);
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(90, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 52);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // rbExtranjero
            // 
            this.rbExtranjero.AutoSize = true;
            this.rbExtranjero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbExtranjero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbExtranjero.Location = new System.Drawing.Point(168, 20);
            this.rbExtranjero.Name = "rbExtranjero";
            this.rbExtranjero.Size = new System.Drawing.Size(75, 15);
            this.rbExtranjero.TabIndex = 3;
            this.rbExtranjero.Text = "Extranjero";
            this.rbExtranjero.UseCustomBackColor = true;
            this.rbExtranjero.UseCustomForeColor = true;
            this.rbExtranjero.UseSelectable = true;
            this.rbExtranjero.UseStyleColors = true;
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbNacional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbNacional.Location = new System.Drawing.Point(51, 20);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(70, 15);
            this.rbNacional.TabIndex = 0;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseCustomBackColor = true;
            this.rbNacional.UseCustomForeColor = true;
            this.rbNacional.UseSelectable = true;
            this.rbNacional.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel1.Location = new System.Drawing.Point(46, 810);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Tipo Empleado:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLimpiador);
            this.groupBox1.Controls.Add(this.rbCajero);
            this.groupBox1.Controls.Add(this.rbAdmin);
            this.groupBox1.Location = new System.Drawing.Point(149, 795);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 83);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            // 
            // rbLimpiador
            // 
            this.rbLimpiador.AutoSize = true;
            this.rbLimpiador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbLimpiador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbLimpiador.Location = new System.Drawing.Point(56, 61);
            this.rbLimpiador.Name = "rbLimpiador";
            this.rbLimpiador.Size = new System.Drawing.Size(77, 15);
            this.rbLimpiador.TabIndex = 17;
            this.rbLimpiador.Text = "Limpiador";
            this.rbLimpiador.UseCustomBackColor = true;
            this.rbLimpiador.UseCustomForeColor = true;
            this.rbLimpiador.UseSelectable = true;
            this.rbLimpiador.UseStyleColors = true;
            this.rbLimpiador.CheckedChanged += new System.EventHandler(this.rbLimpiador_CheckedChanged);
            this.rbLimpiador.Click += new System.EventHandler(this.rbLimpiador_CheckedChanged);
            // 
            // rbCajero
            // 
            this.rbCajero.AutoSize = true;
            this.rbCajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbCajero.Location = new System.Drawing.Point(56, 40);
            this.rbCajero.Name = "rbCajero";
            this.rbCajero.Size = new System.Drawing.Size(57, 15);
            this.rbCajero.TabIndex = 16;
            this.rbCajero.Text = "Cajero";
            this.rbCajero.UseCustomBackColor = true;
            this.rbCajero.UseCustomForeColor = true;
            this.rbCajero.UseSelectable = true;
            this.rbCajero.UseStyleColors = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbAdmin.Location = new System.Drawing.Point(56, 19);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(99, 15);
            this.rbAdmin.TabIndex = 15;
            this.rbAdmin.Text = "Administrador";
            this.rbAdmin.UseCustomBackColor = true;
            this.rbAdmin.UseCustomForeColor = true;
            this.rbAdmin.UseSelectable = true;
            this.rbAdmin.UseStyleColors = true;
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Enabled = false;
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(148, 716);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(197, 23);
            this.txtUser.TabIndex = 41;
            this.txtUser.UseCustomBackColor = true;
            this.txtUser.UseCustomForeColor = true;
            this.txtUser.UseSelectable = true;
            this.txtUser.UseStyleColors = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbUser.Location = new System.Drawing.Point(39, 716);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(110, 19);
            this.lbUser.TabIndex = 40;
            this.lbUser.Text = "Nombre Usuario:";
            this.lbUser.UseCustomBackColor = true;
            this.lbUser.UseCustomForeColor = true;
            this.lbUser.UseStyleColors = true;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Enabled = false;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(150, 764);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(195, 23);
            this.txtPassword.TabIndex = 47;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseCustomForeColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel2.Location = new System.Drawing.Point(60, 764);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Contraseña:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // CboxAddUser
            // 
            this.CboxAddUser.AutoSize = true;
            this.CboxAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.CboxAddUser.Location = new System.Drawing.Point(249, 695);
            this.CboxAddUser.Name = "CboxAddUser";
            this.CboxAddUser.Size = new System.Drawing.Size(111, 15);
            this.CboxAddUser.TabIndex = 48;
            this.CboxAddUser.Text = "Agregar Usuario ";
            this.CboxAddUser.UseCustomBackColor = true;
            this.CboxAddUser.UseCustomForeColor = true;
            this.CboxAddUser.UseSelectable = true;
            this.CboxAddUser.UseStyleColors = true;
            this.CboxAddUser.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // txtTel
            // 
            // 
            // 
            // 
            this.txtTel.CustomButton.Image = null;
            this.txtTel.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtTel.CustomButton.Name = "";
            this.txtTel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTel.CustomButton.TabIndex = 1;
            this.txtTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTel.CustomButton.UseSelectable = true;
            this.txtTel.CustomButton.Visible = false;
            this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtTel.Lines = new string[0];
            this.txtTel.Location = new System.Drawing.Point(181, 463);
            this.txtTel.MaxLength = 32767;
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel.SelectedText = "";
            this.txtTel.SelectionLength = 0;
            this.txtTel.SelectionStart = 0;
            this.txtTel.ShortcutsEnabled = true;
            this.txtTel.Size = new System.Drawing.Size(149, 23);
            this.txtTel.TabIndex = 50;
            this.txtTel.UseCustomBackColor = true;
            this.txtTel.UseCustomForeColor = true;
            this.txtTel.UseSelectable = true;
            this.txtTel.UseStyleColors = true;
            this.txtTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbTel.Location = new System.Drawing.Point(100, 463);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(61, 19);
            this.lbTel.TabIndex = 49;
            this.lbTel.Text = "Teléfono:";
            this.lbTel.UseCustomBackColor = true;
            this.lbTel.UseCustomForeColor = true;
            this.lbTel.UseStyleColors = true;
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(181, 498);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(149, 23);
            this.txtMail.TabIndex = 52;
            this.txtMail.UseCustomBackColor = true;
            this.txtMail.UseCustomForeColor = true;
            this.txtMail.UseSelectable = true;
            this.txtMail.UseStyleColors = true;
            this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbMain.Location = new System.Drawing.Point(105, 498);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(54, 19);
            this.lbMain.TabIndex = 51;
            this.lbMain.Text = "Correo:";
            this.lbMain.UseCustomBackColor = true;
            this.lbMain.UseCustomForeColor = true;
            this.lbMain.UseStyleColors = true;
            // 
            // cboMail
            // 
            this.cboMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboMail.FormattingEnabled = true;
            this.cboMail.ItemHeight = 23;
            this.cboMail.Location = new System.Drawing.Point(336, 498);
            this.cboMail.Name = "cboMail";
            this.cboMail.Size = new System.Drawing.Size(121, 29);
            this.cboMail.TabIndex = 54;
            this.cboMail.UseCustomBackColor = true;
            this.cboMail.UseCustomForeColor = true;
            this.cboMail.UseSelectable = true;
            this.cboMail.UseStyleColors = true;
            this.cboMail.SelectedIndexChanged += new System.EventHandler(this.cboMail_SelectedIndexChanged);
            this.cboMail.Click += new System.EventHandler(this.cboMail_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cboProv);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.txtDireccion);
            this.groupBox3.Controls.Add(this.cboCanton);
            this.groupBox3.Controls.Add(this.cboDistri);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.groupBox3.Location = new System.Drawing.Point(25, 543);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 141);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dirección";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.Brown;
            this.metroLabel6.Location = new System.Drawing.Point(224, 68);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(181, 19);
            this.metroLabel6.TabIndex = 64;
            this.metroLabel6.Text = "*Debe actualizar los campos*";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CapaVista.Properties.Resources.repeat;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(195, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 23);
            this.button2.TabIndex = 63;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CapaVista.Properties.Resources.repeat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(195, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 62;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboProv
            // 
            this.cboProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboProv.FormattingEnabled = true;
            this.cboProv.ItemHeight = 23;
            this.cboProv.Location = new System.Drawing.Point(68, 16);
            this.cboProv.Name = "cboProv";
            this.cboProv.Size = new System.Drawing.Size(121, 29);
            this.cboProv.TabIndex = 59;
            this.cboProv.UseCustomBackColor = true;
            this.cboProv.UseCustomForeColor = true;
            this.cboProv.UseSelectable = true;
            this.cboProv.UseStyleColors = true;
            this.cboProv.SelectedIndexChanged += new System.EventHandler(this.cboProv_SelectedIndexChanged);
            this.cboProv.Click += new System.EventHandler(this.cboProv_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel5.Location = new System.Drawing.Point(4, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 58;
            this.metroLabel5.Text = "Provincia:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.CustomButton.Image = null;
            this.txtDireccion.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtDireccion.CustomButton.Name = "";
            this.txtDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion.CustomButton.TabIndex = 1;
            this.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.CustomButton.UseSelectable = true;
            this.txtDireccion.CustomButton.Visible = false;
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtDireccion.Lines = new string[] {
        "Ingrese Dirección Exacta"};
            this.txtDireccion.Location = new System.Drawing.Point(224, 112);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(194, 23);
            this.txtDireccion.TabIndex = 57;
            this.txtDireccion.Text = "Ingrese Dirección Exacta";
            this.txtDireccion.UseCustomBackColor = true;
            this.txtDireccion.UseCustomForeColor = true;
            this.txtDireccion.UseSelectable = true;
            this.txtDireccion.UseStyleColors = true;
            this.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.Click += new System.EventHandler(this.txtDireccion_Click);
            // 
            // cboCanton
            // 
            this.cboCanton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboCanton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboCanton.FormattingEnabled = true;
            this.cboCanton.ItemHeight = 23;
            this.cboCanton.Location = new System.Drawing.Point(68, 58);
            this.cboCanton.Name = "cboCanton";
            this.cboCanton.Size = new System.Drawing.Size(121, 29);
            this.cboCanton.TabIndex = 56;
            this.cboCanton.UseCustomBackColor = true;
            this.cboCanton.UseCustomForeColor = true;
            this.cboCanton.UseSelectable = true;
            this.cboCanton.UseStyleColors = true;
            this.cboCanton.SelectedIndexChanged += new System.EventHandler(this.cboCanton_SelectedIndexChanged);
            this.cboCanton.Click += new System.EventHandler(this.cboCanton_SelectedIndexChanged);
            // 
            // cboDistri
            // 
            this.cboDistri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboDistri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboDistri.FormattingEnabled = true;
            this.cboDistri.ItemHeight = 23;
            this.cboDistri.Location = new System.Drawing.Point(68, 98);
            this.cboDistri.Name = "cboDistri";
            this.cboDistri.Size = new System.Drawing.Size(121, 29);
            this.cboDistri.TabIndex = 55;
            this.cboDistri.UseCustomBackColor = true;
            this.cboDistri.UseCustomForeColor = true;
            this.cboDistri.UseSelectable = true;
            this.cboDistri.UseStyleColors = true;
            this.cboDistri.SelectedIndexChanged += new System.EventHandler(this.cboDistri_SelectedIndexChanged);
            this.cboDistri.Click += new System.EventHandler(this.cboDistri_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel4.Location = new System.Drawing.Point(6, 58);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 53;
            this.metroLabel4.Text = "Cantón:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel3.Location = new System.Drawing.Point(6, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 52;
            this.metroLabel3.Text = "Distrito:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.id_card_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(171, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 103);
            this.panel1.TabIndex = 0;
            // 
            // cboTel
            // 
            this.cboTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboTel.FormattingEnabled = true;
            this.cboTel.ItemHeight = 23;
            this.cboTel.Location = new System.Drawing.Point(336, 457);
            this.cboTel.Name = "cboTel";
            this.cboTel.Size = new System.Drawing.Size(121, 29);
            this.cboTel.TabIndex = 53;
            this.cboTel.UseCustomBackColor = true;
            this.cboTel.UseCustomForeColor = true;
            this.cboTel.UseSelectable = true;
            this.cboTel.UseStyleColors = true;
            this.cboTel.SelectedIndexChanged += new System.EventHandler(this.cboTel_SelectedIndexChanged);
            this.cboTel.TextUpdate += new System.EventHandler(this.cboTel_SelectedIndexChanged);
            this.cboTel.Click += new System.EventHandler(this.cboTel_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.rbFemale);
            this.groupBox5.Controls.Add(this.rbMale);
            this.groupBox5.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox5.Location = new System.Drawing.Point(181, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(149, 54);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbFemale.Location = new System.Drawing.Point(4, 33);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(76, 15);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.Text = "Femenino";
            this.rbFemale.UseCustomBackColor = true;
            this.rbFemale.UseCustomForeColor = true;
            this.rbFemale.UseSelectable = true;
            this.rbFemale.UseStyleColors = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbMale.Location = new System.Drawing.Point(4, 9);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(78, 15);
            this.rbMale.TabIndex = 0;
            this.rbMale.Text = "Masculino";
            this.rbMale.UseCustomBackColor = true;
            this.rbMale.UseCustomForeColor = true;
            this.rbMale.UseSelectable = true;
            this.rbMale.UseStyleColors = true;
            // 
            // txtGenero
            // 
            this.txtGenero.AutoSize = true;
            this.txtGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.txtGenero.Location = new System.Drawing.Point(113, 242);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(55, 19);
            this.txtGenero.TabIndex = 56;
            this.txtGenero.Text = "Género:";
            this.txtGenero.UseCustomBackColor = true;
            this.txtGenero.UseCustomForeColor = true;
            this.txtGenero.UseStyleColors = true;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(468, 938);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cboMail);
            this.Controls.Add(this.cboTel);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.CboxAddUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbOpcional);
            this.Controls.Add(this.lbApellido2);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lnNombre);
            this.Controls.Add(this.lbIdentificacion);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbNuevoEmp);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbNuevoEmp;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroTextBox txtApe2;
        private MetroFramework.Controls.MetroTextBox txtApe1;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel lbOpcional;
        private MetroFramework.Controls.MetroLabel lbApellido2;
        private MetroFramework.Controls.MetroLabel lbApellido;
        private MetroFramework.Controls.MetroLabel lnNombre;
        private MetroFramework.Controls.MetroLabel lbIdentificacion;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroRadioButton rbExtranjero;
        private MetroFramework.Controls.MetroRadioButton rbNacional;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rbCajero;
        private MetroFramework.Controls.MetroRadioButton rbAdmin;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel lbUser;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox CboxAddUser;
        private MetroFramework.Controls.MetroTextBox txtTel;
        private MetroFramework.Controls.MetroLabel lbTel;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroLabel lbMain;
        private MetroFramework.Controls.MetroComboBox cboMail;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroComboBox cboCanton;
        private MetroFramework.Controls.MetroComboBox cboDistri;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cboProv;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroComboBox cboTel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroRadioButton rbFemale;
        private MetroFramework.Controls.MetroRadioButton rbMale;
        private MetroFramework.Controls.MetroLabel txtGenero;
        private MetroFramework.Controls.MetroRadioButton rbLimpiador;
    }
}