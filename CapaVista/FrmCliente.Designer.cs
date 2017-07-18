namespace CapaVista
{
    partial class FrmCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNuevoCliente = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbExtranjero = new MetroFramework.Controls.MetroRadioButton();
            this.rbNacional = new MetroFramework.Controls.MetroRadioButton();
            this.lbIdentificacion = new MetroFramework.Controls.MetroLabel();
            this.lnNombre = new MetroFramework.Controls.MetroLabel();
            this.lbApellido = new MetroFramework.Controls.MetroLabel();
            this.lbApellido2 = new MetroFramework.Controls.MetroLabel();
            this.lbOpcional = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtNom = new MetroFramework.Controls.MetroTextBox();
            this.txtApe1 = new MetroFramework.Controls.MetroTextBox();
            this.txtApe2 = new MetroFramework.Controls.MetroTextBox();
            this.lbGenero = new MetroFramework.Controls.MetroLabel();
            this.rbMale = new MetroFramework.Controls.MetroRadioButton();
            this.rbFemale = new MetroFramework.Controls.MetroRadioButton();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rbChildren = new MetroFramework.Controls.MetroRadioButton();
            this.rbAdultM = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbAdolescente = new MetroFramework.Controls.MetroRadioButton();
            this.rbAdult = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.id_card_4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(121, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 105);
            this.panel1.TabIndex = 0;
            // 
            // lbNuevoCliente
            // 
            this.lbNuevoCliente.AutoSize = true;
            this.lbNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoCliente.Location = new System.Drawing.Point(110, 9);
            this.lbNuevoCliente.Name = "lbNuevoCliente";
            this.lbNuevoCliente.Size = new System.Drawing.Size(139, 25);
            this.lbNuevoCliente.TabIndex = 1;
            this.lbNuevoCliente.Text = "NUEVO CLIENTE";
            this.lbNuevoCliente.UseCustomBackColor = true;
            this.lbNuevoCliente.UseCustomForeColor = true;
            this.lbNuevoCliente.UseStyleColors = true;
            this.lbNuevoCliente.WrapToLine = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbExtranjero);
            this.groupBox1.Controls.Add(this.rbNacional);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(32, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
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
            this.rbExtranjero.CheckedChanged += new System.EventHandler(this.rbExtrangero_CheckedChanged);
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
            this.rbNacional.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbIdentificacion.Location = new System.Drawing.Point(11, 229);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(88, 19);
            this.lbIdentificacion.TabIndex = 3;
            this.lbIdentificacion.Text = "Identificación:";
            this.lbIdentificacion.UseCustomBackColor = true;
            this.lbIdentificacion.UseCustomForeColor = true;
            this.lbIdentificacion.UseStyleColors = true;
            // 
            // lnNombre
            // 
            this.lnNombre.AutoSize = true;
            this.lnNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lnNombre.Location = new System.Drawing.Point(37, 271);
            this.lnNombre.Name = "lnNombre";
            this.lnNombre.Size = new System.Drawing.Size(62, 19);
            this.lnNombre.TabIndex = 5;
            this.lnNombre.Text = "Nombre:";
            this.lnNombre.UseCustomBackColor = true;
            this.lnNombre.UseCustomForeColor = true;
            this.lnNombre.UseStyleColors = true;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbApellido.Location = new System.Drawing.Point(33, 312);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(66, 19);
            this.lbApellido.TabIndex = 6;
            this.lbApellido.Text = "Apellido1:";
            this.lbApellido.UseCustomBackColor = true;
            this.lbApellido.UseCustomForeColor = true;
            this.lbApellido.UseStyleColors = true;
            // 
            // lbApellido2
            // 
            this.lbApellido2.AutoSize = true;
            this.lbApellido2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbApellido2.Location = new System.Drawing.Point(31, 354);
            this.lbApellido2.Name = "lbApellido2";
            this.lbApellido2.Size = new System.Drawing.Size(68, 19);
            this.lbApellido2.TabIndex = 7;
            this.lbApellido2.Text = "Apellido2:";
            this.lbApellido2.UseCustomBackColor = true;
            this.lbApellido2.UseCustomForeColor = true;
            this.lbApellido2.UseStyleColors = true;
            // 
            // lbOpcional
            // 
            this.lbOpcional.AutoSize = true;
            this.lbOpcional.ForeColor = System.Drawing.Color.Brown;
            this.lbOpcional.Location = new System.Drawing.Point(260, 354);
            this.lbOpcional.Name = "lbOpcional";
            this.lbOpcional.Size = new System.Drawing.Size(86, 19);
            this.lbOpcional.TabIndex = 8;
            this.lbOpcional.Text = "*OPCIONAL*";
            this.lbOpcional.UseCustomBackColor = true;
            this.lbOpcional.UseCustomForeColor = true;
            this.lbOpcional.UseStyleColors = true;
            this.lbOpcional.Visible = false;
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
            this.txtID.Location = new System.Drawing.Point(105, 229);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(149, 23);
            this.txtID.TabIndex = 9;
            this.txtID.UseCustomBackColor = true;
            this.txtID.UseCustomForeColor = true;
            this.txtID.UseSelectable = true;
            this.txtID.UseStyleColors = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtNom.Location = new System.Drawing.Point(105, 271);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(149, 23);
            this.txtNom.TabIndex = 10;
            this.txtNom.UseCustomBackColor = true;
            this.txtNom.UseCustomForeColor = true;
            this.txtNom.UseSelectable = true;
            this.txtNom.UseStyleColors = true;
            this.txtNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtApe1.Location = new System.Drawing.Point(105, 312);
            this.txtApe1.MaxLength = 32767;
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.PasswordChar = '\0';
            this.txtApe1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApe1.SelectedText = "";
            this.txtApe1.SelectionLength = 0;
            this.txtApe1.SelectionStart = 0;
            this.txtApe1.ShortcutsEnabled = true;
            this.txtApe1.Size = new System.Drawing.Size(149, 23);
            this.txtApe1.TabIndex = 11;
            this.txtApe1.UseCustomBackColor = true;
            this.txtApe1.UseCustomForeColor = true;
            this.txtApe1.UseSelectable = true;
            this.txtApe1.UseStyleColors = true;
            this.txtApe1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApe1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtApe2.Location = new System.Drawing.Point(105, 350);
            this.txtApe2.MaxLength = 32767;
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.PasswordChar = '\0';
            this.txtApe2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApe2.SelectedText = "";
            this.txtApe2.SelectionLength = 0;
            this.txtApe2.SelectionStart = 0;
            this.txtApe2.ShortcutsEnabled = true;
            this.txtApe2.Size = new System.Drawing.Size(149, 23);
            this.txtApe2.TabIndex = 12;
            this.txtApe2.UseCustomBackColor = true;
            this.txtApe2.UseCustomForeColor = true;
            this.txtApe2.UseSelectable = true;
            this.txtApe2.UseStyleColors = true;
            this.txtApe2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApe2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbGenero.Location = new System.Drawing.Point(37, 401);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(55, 19);
            this.lbGenero.TabIndex = 13;
            this.lbGenero.Text = "Género:";
            this.lbGenero.UseCustomBackColor = true;
            this.lbGenero.UseCustomForeColor = true;
            this.lbGenero.UseStyleColors = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbMale.Location = new System.Drawing.Point(11, 20);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(78, 15);
            this.rbMale.TabIndex = 14;
            this.rbMale.Text = "Masculino";
            this.rbMale.UseCustomBackColor = true;
            this.rbMale.UseCustomForeColor = true;
            this.rbMale.UseSelectable = true;
            this.rbMale.UseStyleColors = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbFemale.Location = new System.Drawing.Point(101, 20);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(76, 15);
            this.rbFemale.TabIndex = 15;
            this.rbFemale.Text = "Femenino";
            this.rbFemale.UseCustomBackColor = true;
            this.rbFemale.UseCustomForeColor = true;
            this.rbFemale.UseSelectable = true;
            this.rbFemale.UseStyleColors = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(93, 566);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(167, 33);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseCustomBackColor = true;
            this.btnAceptar.UseCustomForeColor = true;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel1.Location = new System.Drawing.Point(4, 467);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Tipo de cliente:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // rbChildren
            // 
            this.rbChildren.AutoSize = true;
            this.rbChildren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbChildren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbChildren.Location = new System.Drawing.Point(11, 19);
            this.rbChildren.Name = "rbChildren";
            this.rbChildren.Size = new System.Drawing.Size(49, 15);
            this.rbChildren.TabIndex = 19;
            this.rbChildren.Text = "Niño";
            this.rbChildren.UseCustomBackColor = true;
            this.rbChildren.UseCustomForeColor = true;
            this.rbChildren.UseSelectable = true;
            this.rbChildren.UseStyleColors = true;
            // 
            // rbAdultM
            // 
            this.rbAdultM.AutoSize = true;
            this.rbAdultM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbAdultM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbAdultM.Location = new System.Drawing.Point(99, 19);
            this.rbAdultM.Name = "rbAdultM";
            this.rbAdultM.Size = new System.Drawing.Size(96, 15);
            this.rbAdultM.TabIndex = 20;
            this.rbAdultM.Text = "Adulto Mayor";
            this.rbAdultM.UseCustomBackColor = true;
            this.rbAdultM.UseCustomForeColor = true;
            this.rbAdultM.UseSelectable = true;
            this.rbAdultM.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Location = new System.Drawing.Point(105, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 52);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbAdult);
            this.groupBox3.Controls.Add(this.rbAdolescente);
            this.groupBox3.Controls.Add(this.rbChildren);
            this.groupBox3.Controls.Add(this.rbAdultM);
            this.groupBox3.Location = new System.Drawing.Point(105, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 71);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // rbAdolescente
            // 
            this.rbAdolescente.AutoSize = true;
            this.rbAdolescente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbAdolescente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbAdolescente.Location = new System.Drawing.Point(11, 47);
            this.rbAdolescente.Name = "rbAdolescente";
            this.rbAdolescente.Size = new System.Drawing.Size(83, 15);
            this.rbAdolescente.TabIndex = 21;
            this.rbAdolescente.Text = "Adolecente";
            this.rbAdolescente.UseCustomBackColor = true;
            this.rbAdolescente.UseCustomForeColor = true;
            this.rbAdolescente.UseSelectable = true;
            this.rbAdolescente.UseStyleColors = true;
            // 
            // rbAdult
            // 
            this.rbAdult.AutoSize = true;
            this.rbAdult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.rbAdult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.rbAdult.Location = new System.Drawing.Point(99, 50);
            this.rbAdult.Name = "rbAdult";
            this.rbAdult.Size = new System.Drawing.Size(59, 15);
            this.rbAdult.TabIndex = 22;
            this.rbAdult.Text = "Adulto";
            this.rbAdult.UseCustomBackColor = true;
            this.rbAdult.UseCustomForeColor = true;
            this.rbAdult.UseSelectable = true;
            this.rbAdult.UseStyleColors = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(349, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbOpcional);
            this.Controls.Add(this.lbApellido2);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lnNombre);
            this.Controls.Add(this.lbIdentificacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNuevoCliente);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbNuevoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton rbExtranjero;
        private MetroFramework.Controls.MetroRadioButton rbNacional;
        private MetroFramework.Controls.MetroLabel lbIdentificacion;
        private MetroFramework.Controls.MetroLabel lnNombre;
        private MetroFramework.Controls.MetroLabel lbApellido;
        private MetroFramework.Controls.MetroLabel lbApellido2;
        private MetroFramework.Controls.MetroLabel lbOpcional;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtNom;
        private MetroFramework.Controls.MetroTextBox txtApe1;
        private MetroFramework.Controls.MetroTextBox txtApe2;
        private MetroFramework.Controls.MetroLabel lbGenero;
        private MetroFramework.Controls.MetroRadioButton rbMale;
        private MetroFramework.Controls.MetroRadioButton rbFemale;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rbChildren;
        private MetroFramework.Controls.MetroRadioButton rbAdultM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroRadioButton rbAdolescente;
        private MetroFramework.Controls.MetroRadioButton rbAdult;
    }
}