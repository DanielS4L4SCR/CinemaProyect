﻿namespace WindowsFormsApp1
{
    partial class FrmPrincipall
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipall));
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.lbRegresar = new System.Windows.Forms.Label();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.btnVentas2 = new System.Windows.Forms.Button();
            this.btnReportes3 = new System.Windows.Forms.Button();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panelMenú = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.panelAgregar1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.btnPromo = new System.Windows.Forms.Button();
            this.btnNewMovie = new System.Windows.Forms.Button();
            this.btnAddEmpleado = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panelVentas2 = new System.Windows.Forms.Panel();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.panelReportes3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCinemaPro = new System.Windows.Forms.Label();
            this.btnFondos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelSubMenu.SuspendLayout();
            this.panelMenú.SuspendLayout();
            this.panelAgregar1.SuspendLayout();
            this.panelVentas2.SuspendLayout();
            this.panelReportes3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.panelSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSubMenu.Controls.Add(this.lbRegresar);
            this.panelSubMenu.Controls.Add(this.btnPeliculas);
            this.panelSubMenu.Controls.Add(this.btnVentas2);
            this.panelSubMenu.Controls.Add(this.btnReportes3);
            this.panelSubMenu.Controls.Add(this.btnAgregar1);
            this.panelSubMenu.Controls.Add(this.btnRegresar);
            this.panelSubMenu.Location = new System.Drawing.Point(0, -2);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(222, 1000);
            this.panelSubMenu.TabIndex = 6;
            this.panelSubMenu.Visible = false;
            this.panelSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbRegresar
            // 
            this.lbRegresar.AutoSize = true;
            this.lbRegresar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegresar.Location = new System.Drawing.Point(72, 0);
            this.lbRegresar.Name = "lbRegresar";
            this.lbRegresar.Size = new System.Drawing.Size(115, 32);
            this.lbRegresar.TabIndex = 6;
            this.lbRegresar.Text = "Regresar";
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.BackColor = System.Drawing.Color.Transparent;
            this.btnPeliculas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculas.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.btnPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeliculas.ImageIndex = 8;
            this.btnPeliculas.ImageList = this.IconsList;
            this.btnPeliculas.Location = new System.Drawing.Point(8, 310);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(211, 76);
            this.btnPeliculas.TabIndex = 5;
            this.btnPeliculas.Text = "Cartelera";
            this.btnPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeliculas.UseVisualStyleBackColor = false;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "051-add.png");
            this.IconsList.Images.SetKeyName(1, "add-1.png");
            this.IconsList.Images.SetKeyName(2, "add-2.png");
            this.IconsList.Images.SetKeyName(3, "archive-1.png");
            this.IconsList.Images.SetKeyName(4, "icons8-Badge-50.png");
            this.IconsList.Images.SetKeyName(5, "icons8-Blog-50.png");
            this.IconsList.Images.SetKeyName(6, "icons8-Decrease-50.png");
            this.IconsList.Images.SetKeyName(7, "icons8-Money-50.png");
            this.IconsList.Images.SetKeyName(8, "icons8-Movie Projector-50.png");
            this.IconsList.Images.SetKeyName(9, "icons8-Movie-64.png");
            this.IconsList.Images.SetKeyName(10, "icons8-Shopping Cart-50.png");
            this.IconsList.Images.SetKeyName(11, "multiply-1.png");
            this.IconsList.Images.SetKeyName(12, "icons8-Guest Male Filled-50.png");
            this.IconsList.Images.SetKeyName(13, "icons8-Voucher-50.png");
            this.IconsList.Images.SetKeyName(14, "icons8-School Director Male Skin Type 4-40.png");
            this.IconsList.Images.SetKeyName(15, "icons8-Coins-50.png");
            this.IconsList.Images.SetKeyName(16, "icons8-Movies Folder-50.png");
            this.IconsList.Images.SetKeyName(17, "icons8-Aircraft Seat Aisle-50.png");
            // 
            // btnVentas2
            // 
            this.btnVentas2.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas2.FlatAppearance.BorderSize = 0;
            this.btnVentas2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnVentas2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnVentas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas2.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.btnVentas2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas2.ImageIndex = 10;
            this.btnVentas2.ImageList = this.IconsList;
            this.btnVentas2.Location = new System.Drawing.Point(1, 146);
            this.btnVentas2.Name = "btnVentas2";
            this.btnVentas2.Size = new System.Drawing.Size(211, 76);
            this.btnVentas2.TabIndex = 3;
            this.btnVentas2.Text = "Ventas";
            this.btnVentas2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas2.UseVisualStyleBackColor = false;
            this.btnVentas2.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnReportes3
            // 
            this.btnReportes3.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes3.FlatAppearance.BorderSize = 0;
            this.btnReportes3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnReportes3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnReportes3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes3.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.btnReportes3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes3.ImageIndex = 6;
            this.btnReportes3.ImageList = this.IconsList;
            this.btnReportes3.Location = new System.Drawing.Point(8, 228);
            this.btnReportes3.Name = "btnReportes3";
            this.btnReportes3.Size = new System.Drawing.Size(211, 76);
            this.btnReportes3.TabIndex = 2;
            this.btnReportes3.Text = "Reportes";
            this.btnReportes3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportes3.UseVisualStyleBackColor = false;
            this.btnReportes3.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar1.FlatAppearance.BorderSize = 0;
            this.btnAgregar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnAgregar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
            this.btnAgregar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar1.ImageIndex = 0;
            this.btnAgregar1.ImageList = this.IconsList;
            this.btnAgregar1.Location = new System.Drawing.Point(4, 64);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(211, 76);
            this.btnAgregar1.TabIndex = 1;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar1.UseVisualStyleBackColor = false;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.restart;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(227)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(9, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(57, 54);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panelMenú
            // 
            this.panelMenú.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.panelMenú.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenú.Controls.Add(this.BtnMenu);
            this.panelMenú.Location = new System.Drawing.Point(0, -2);
            this.panelMenú.Name = "panelMenú";
            this.panelMenú.Size = new System.Drawing.Size(222, 1000);
            this.panelMenú.TabIndex = 4;
            this.panelMenú.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenú_Paint);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.menu_1;
            this.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Location = new System.Drawing.Point(8, 4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(57, 54);
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panelAgregar1
            // 
            this.panelAgregar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(162)))), ((int)(((byte)(187)))));
            this.panelAgregar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAgregar1.Controls.Add(this.btnCancelar);
            this.panelAgregar1.Controls.Add(this.lbCancelar);
            this.panelAgregar1.Controls.Add(this.btnPromo);
            this.panelAgregar1.Controls.Add(this.btnNewMovie);
            this.panelAgregar1.Controls.Add(this.btnAddEmpleado);
            this.panelAgregar1.Controls.Add(this.btnCliente);
            this.panelAgregar1.Location = new System.Drawing.Point(222, -2);
            this.panelAgregar1.Name = "panelAgregar1";
            this.panelAgregar1.Size = new System.Drawing.Size(222, 1000);
            this.panelAgregar1.TabIndex = 7;
            this.panelAgregar1.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_Delete_50;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(162)))), ((int)(((byte)(187)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(162)))), ((int)(((byte)(187)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(4, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 54);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // lbCancelar
            // 
            this.lbCancelar.AutoSize = true;
            this.lbCancelar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancelar.Location = new System.Drawing.Point(67, 28);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(113, 32);
            this.lbCancelar.TabIndex = 6;
            this.lbCancelar.Text = "Cancelar";
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            // 
            // btnPromo
            // 
            this.btnPromo.BackColor = System.Drawing.Color.Transparent;
            this.btnPromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPromo.FlatAppearance.BorderSize = 0;
            this.btnPromo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(195)))), ((int)(((byte)(224)))));
            this.btnPromo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(195)))), ((int)(((byte)(224)))));
            this.btnPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromo.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.btnPromo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromo.ImageIndex = 13;
            this.btnPromo.ImageList = this.IconsList;
            this.btnPromo.Location = new System.Drawing.Point(5, 273);
            this.btnPromo.Name = "btnPromo";
            this.btnPromo.Size = new System.Drawing.Size(211, 76);
            this.btnPromo.TabIndex = 5;
            this.btnPromo.Text = "Promoción";
            this.btnPromo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPromo.UseVisualStyleBackColor = false;
            // 
            // btnNewMovie
            // 
            this.btnNewMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnNewMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewMovie.FlatAppearance.BorderSize = 0;
            this.btnNewMovie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(195)))), ((int)(((byte)(224)))));
            this.btnNewMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(195)))), ((int)(((byte)(224)))));
            this.btnNewMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMovie.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.btnNewMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMovie.ImageIndex = 9;
            this.btnNewMovie.ImageList = this.IconsList;
            this.btnNewMovie.Location = new System.Drawing.Point(3, 205);
            this.btnNewMovie.Name = "btnNewMovie";
            this.btnNewMovie.Size = new System.Drawing.Size(211, 76);
            this.btnNewMovie.TabIndex = 3;
            this.btnNewMovie.Text = "Película";
            this.btnNewMovie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewMovie.UseVisualStyleBackColor = false;
            // 
            // btnAddEmpleado
            // 
            this.btnAddEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAddEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(195)))), ((int)(((byte)(224)))));
            this.btnAddEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(195)))), ((int)(((byte)(224)))));
            this.btnAddEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmpleado.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.btnAddEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmpleado.ImageIndex = 14;
            this.btnAddEmpleado.ImageList = this.IconsList;
            this.btnAddEmpleado.Location = new System.Drawing.Point(2, 137);
            this.btnAddEmpleado.Name = "btnAddEmpleado";
            this.btnAddEmpleado.Size = new System.Drawing.Size(211, 76);
            this.btnAddEmpleado.TabIndex = 2;
            this.btnAddEmpleado.Text = "Empleado";
            this.btnAddEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(195)))), ((int)(((byte)(224)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(195)))), ((int)(((byte)(224)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.ImageIndex = 12;
            this.btnCliente.ImageList = this.IconsList;
            this.btnCliente.Location = new System.Drawing.Point(3, 64);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(211, 76);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = false;
            // 
            // panelVentas2
            // 
            this.panelVentas2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panelVentas2.Controls.Add(this.btnCancelar2);
            this.panelVentas2.Controls.Add(this.label1);
            this.panelVentas2.Controls.Add(this.btnFacturacion);
            this.panelVentas2.Location = new System.Drawing.Point(223, -2);
            this.panelVentas2.Name = "panelVentas2";
            this.panelVentas2.Size = new System.Drawing.Size(222, 1000);
            this.panelVentas2.TabIndex = 8;
            this.panelVentas2.Visible = false;
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_Delete_50;
            this.btnCancelar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar2.FlatAppearance.BorderSize = 0;
            this.btnCancelar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.btnCancelar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.btnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar2.Location = new System.Drawing.Point(4, 6);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(57, 54);
            this.btnCancelar2.TabIndex = 7;
            this.btnCancelar2.UseVisualStyleBackColor = false;
            this.btnCancelar2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cancelar";
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.ImageIndex = 15;
            this.btnFacturacion.ImageList = this.IconsList;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 64);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(211, 76);
            this.btnFacturacion.TabIndex = 1;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            // 
            // panelReportes3
            // 
            this.panelReportes3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.panelReportes3.Controls.Add(this.button3);
            this.panelReportes3.Controls.Add(this.btnFondos);
            this.panelReportes3.Controls.Add(this.button1);
            this.panelReportes3.Controls.Add(this.btnCancelar3);
            this.panelReportes3.Controls.Add(this.label2);
            this.panelReportes3.Controls.Add(this.button2);
            this.panelReportes3.Location = new System.Drawing.Point(222, -2);
            this.panelReportes3.Name = "panelReportes3";
            this.panelReportes3.Size = new System.Drawing.Size(222, 1000);
            this.panelReportes3.TabIndex = 9;
            this.panelReportes3.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 16;
            this.button1.ImageList = this.IconsList;
            this.button1.Location = new System.Drawing.Point(-1, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reporte Peliculas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCancelar3
            // 
            this.btnCancelar3.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_Delete_50;
            this.btnCancelar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar3.FlatAppearance.BorderSize = 0;
            this.btnCancelar3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.btnCancelar3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(140)))), ((int)(((byte)(161)))));
            this.btnCancelar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar3.Location = new System.Drawing.Point(4, 6);
            this.btnCancelar3.Name = "btnCancelar3";
            this.btnCancelar3.Size = new System.Drawing.Size(57, 54);
            this.btnCancelar3.TabIndex = 7;
            this.btnCancelar3.UseVisualStyleBackColor = false;
            this.btnCancelar3.Click += new System.EventHandler(this.btnCancelar3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cancelar";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 5;
            this.button2.ImageList = this.IconsList;
            this.button2.Location = new System.Drawing.Point(-1, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reporte Ventas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.click_click1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbCinemaPro);
            this.panel1.Location = new System.Drawing.Point(451, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2000, 1000);
            this.panel1.TabIndex = 10;
            // 
            // lbCinemaPro
            // 
            this.lbCinemaPro.AutoSize = true;
            this.lbCinemaPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.lbCinemaPro.Font = new System.Drawing.Font("Tekton Pro Ext", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinemaPro.Location = new System.Drawing.Point(155, 348);
            this.lbCinemaPro.Name = "lbCinemaPro";
            this.lbCinemaPro.Size = new System.Drawing.Size(588, 118);
            this.lbCinemaPro.TabIndex = 0;
            this.lbCinemaPro.Text = "CinemaPro";
            // 
            // btnFondos
            // 
            this.btnFondos.BackColor = System.Drawing.Color.Transparent;
            this.btnFondos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFondos.FlatAppearance.BorderSize = 0;
            this.btnFondos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
            this.btnFondos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
            this.btnFondos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFondos.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.btnFondos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFondos.ImageIndex = 7;
            this.btnFondos.ImageList = this.IconsList;
            this.btnFondos.Location = new System.Drawing.Point(1, 207);
            this.btnFondos.Name = "btnFondos";
            this.btnFondos.Size = new System.Drawing.Size(227, 76);
            this.btnFondos.TabIndex = 9;
            this.btnFondos.Text = "Reporte Fondos";
            this.btnFondos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFondos.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 17;
            this.button3.ImageList = this.IconsList;
            this.button3.Location = new System.Drawing.Point(0, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 76);
            this.button3.TabIndex = 10;
            this.button3.Text = "Reservaciones";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSubMenu);
            this.Controls.Add(this.panelMenú);
            this.Controls.Add(this.panelAgregar1);
            this.Controls.Add(this.panelVentas2);
            this.Controls.Add(this.panelReportes3);
            this.Name = "FrmPrincipall";
            this.Text = "Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSubMenu.ResumeLayout(false);
            this.panelSubMenu.PerformLayout();
            this.panelMenú.ResumeLayout(false);
            this.panelAgregar1.ResumeLayout(false);
            this.panelAgregar1.PerformLayout();
            this.panelVentas2.ResumeLayout(false);
            this.panelVentas2.PerformLayout();
            this.panelReportes3.ResumeLayout(false);
            this.panelReportes3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Button btnVentas2;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.Button btnReportes3;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Panel panelMenú;
        private System.Windows.Forms.Label lbRegresar;
        private System.Windows.Forms.Panel panelAgregar1;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Button btnPromo;
        private System.Windows.Forms.Button btnNewMovie;
        private System.Windows.Forms.Button btnAddEmpleado;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelVentas2;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Panel panelReportes3;
        private System.Windows.Forms.Button btnCancelar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCinemaPro;
        private System.Windows.Forms.Button btnFondos;
        private System.Windows.Forms.Button button3;
    }
}

