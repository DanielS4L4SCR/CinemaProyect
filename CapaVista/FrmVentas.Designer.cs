namespace CapaVista
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.cboAsiento = new MetroFramework.Controls.MetroComboBox();
            this.cboProyeccion = new MetroFramework.Controls.MetroComboBox();
            this.lbProyeccion = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtFecha = new MetroFramework.Controls.MetroDateTime();
            this.cboEmpleado = new MetroFramework.Controls.MetroComboBox();
            this.LbFecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbNuevoCliente = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.lbValor = new MetroFramework.Controls.MetroLabel();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.IDProyeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinalización = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEstreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTipoCliente = new MetroFramework.Controls.MetroComboBox();
            this.cboLastFac = new MetroFramework.Controls.MetroComboBox();
            this.cboPromo = new MetroFramework.Controls.MetroComboBox();
            this.cboDescuento = new MetroFramework.Controls.MetroComboBox();
            this.cboPrecios = new MetroFramework.Controls.MetroComboBox();
            this.cboSala = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lbAsiento = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.cboAsiento);
            this.groupBox1.Controls.Add(this.cboProyeccion);
            this.groupBox1.Controls.Add(this.lbProyeccion);
            this.groupBox1.Location = new System.Drawing.Point(120, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(90, 103);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(76, 21);
            this.metroButton2.TabIndex = 67;
            this.metroButton2.Text = "Ver Asientos";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(172, 103);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 21);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseCustomBackColor = true;
            this.btnAgregar.UseCustomForeColor = true;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.UseStyleColors = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboAsiento
            // 
            this.cboAsiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboAsiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboAsiento.FormattingEnabled = true;
            this.cboAsiento.ItemHeight = 23;
            this.cboAsiento.Location = new System.Drawing.Point(100, 60);
            this.cboAsiento.Name = "cboAsiento";
            this.cboAsiento.Size = new System.Drawing.Size(149, 29);
            this.cboAsiento.TabIndex = 179;
            this.cboAsiento.UseCustomBackColor = true;
            this.cboAsiento.UseCustomForeColor = true;
            this.cboAsiento.UseSelectable = true;
            this.cboAsiento.UseStyleColors = true;
            // 
            // cboProyeccion
            // 
            this.cboProyeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboProyeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboProyeccion.FormattingEnabled = true;
            this.cboProyeccion.ItemHeight = 23;
            this.cboProyeccion.Location = new System.Drawing.Point(100, 20);
            this.cboProyeccion.Name = "cboProyeccion";
            this.cboProyeccion.Size = new System.Drawing.Size(149, 29);
            this.cboProyeccion.TabIndex = 57;
            this.cboProyeccion.UseCustomBackColor = true;
            this.cboProyeccion.UseCustomForeColor = true;
            this.cboProyeccion.UseSelectable = true;
            this.cboProyeccion.UseStyleColors = true;
            this.cboProyeccion.SelectedIndexChanged += new System.EventHandler(this.cboProyeccion_SelectedIndexChanged);
            // 
            // lbProyeccion
            // 
            this.lbProyeccion.AutoSize = true;
            this.lbProyeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbProyeccion.Location = new System.Drawing.Point(18, 30);
            this.lbProyeccion.Name = "lbProyeccion";
            this.lbProyeccion.Size = new System.Drawing.Size(76, 19);
            this.lbProyeccion.TabIndex = 10;
            this.lbProyeccion.Text = "Proyección:";
            this.lbProyeccion.UseCustomBackColor = true;
            this.lbProyeccion.UseCustomForeColor = true;
            this.lbProyeccion.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtFecha);
            this.groupBox2.Controls.Add(this.cboEmpleado);
            this.groupBox2.Controls.Add(this.LbFecha);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.cboCliente);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Location = new System.Drawing.Point(496, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // DtFecha
            // 
            this.DtFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.DtFecha.CustomFormat = "yyyMMdd";
            this.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFecha.Location = new System.Drawing.Point(138, 101);
            this.DtFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(152, 29);
            this.DtFecha.TabIndex = 67;
            this.DtFecha.UseCustomBackColor = true;
            this.DtFecha.UseCustomForeColor = true;
            this.DtFecha.UseStyleColors = true;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.ItemHeight = 23;
            this.cboEmpleado.Location = new System.Drawing.Point(138, 56);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(149, 29);
            this.cboEmpleado.TabIndex = 61;
            this.cboEmpleado.UseCustomBackColor = true;
            this.cboEmpleado.UseCustomForeColor = true;
            this.cboEmpleado.UseSelectable = true;
            this.cboEmpleado.UseStyleColors = true;
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.LbFecha.Location = new System.Drawing.Point(76, 111);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(46, 19);
            this.LbFecha.TabIndex = 66;
            this.LbFecha.Text = "Fecha:";
            this.LbFecha.UseCustomBackColor = true;
            this.LbFecha.UseCustomForeColor = true;
            this.LbFecha.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel2.Location = new System.Drawing.Point(50, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 60;
            this.metroLabel2.Text = "Empleado:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // cboCliente
            // 
            this.cboCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.ItemHeight = 23;
            this.cboCliente.Location = new System.Drawing.Point(138, 16);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(149, 29);
            this.cboCliente.TabIndex = 59;
            this.cboCliente.UseCustomBackColor = true;
            this.cboCliente.UseCustomForeColor = true;
            this.cboCliente.UseSelectable = true;
            this.cboCliente.UseStyleColors = true;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel1.Location = new System.Drawing.Point(70, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Cliente:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // lbNuevoCliente
            // 
            this.lbNuevoCliente.AutoSize = true;
            this.lbNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbNuevoCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbNuevoCliente.Location = new System.Drawing.Point(372, 9);
            this.lbNuevoCliente.Name = "lbNuevoCliente";
            this.lbNuevoCliente.Size = new System.Drawing.Size(122, 25);
            this.lbNuevoCliente.TabIndex = 3;
            this.lbNuevoCliente.Text = "NUEVA VENTA";
            this.lbNuevoCliente.UseCustomBackColor = true;
            this.lbNuevoCliente.UseCustomForeColor = true;
            this.lbNuevoCliente.UseStyleColors = true;
            this.lbNuevoCliente.WrapToLine = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.metroLabel3.Location = new System.Drawing.Point(29, 529);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 25);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "₡TOTAL:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(746, 529);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 33);
            this.btnAceptar.TabIndex = 65;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseCustomBackColor = true;
            this.btnAceptar.UseCustomForeColor = true;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbValor.Location = new System.Drawing.Point(105, 529);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(21, 25);
            this.lbValor.TabIndex = 68;
            this.lbValor.Text = "0";
            this.lbValor.UseCustomBackColor = true;
            this.lbValor.UseCustomForeColor = true;
            this.lbValor.UseStyleColors = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProyeccion,
            this.IDPelicula,
            this.idSala,
            this.HoraInicio,
            this.HoraFinalización,
            this.FechaEstreno,
            this.Precio,
            this.PrecioDesc,
            this.Asiento,
            this.Descuent});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.dgvVentas.Location = new System.Drawing.Point(12, 299);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.Size = new System.Drawing.Size(912, 224);
            this.dgvVentas.TabIndex = 88;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick_1);
            // 
            // IDProyeccion
            // 
            this.IDProyeccion.HeaderText = "Proyección";
            this.IDProyeccion.Name = "IDProyeccion";
            this.IDProyeccion.ReadOnly = true;
            // 
            // IDPelicula
            // 
            this.IDPelicula.HeaderText = "Pelicula";
            this.IDPelicula.Name = "IDPelicula";
            this.IDPelicula.ReadOnly = true;
            // 
            // idSala
            // 
            this.idSala.HeaderText = "Sala";
            this.idSala.Name = "idSala";
            this.idSala.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraFinalización
            // 
            this.HoraFinalización.HeaderText = "HoraFinalización";
            this.HoraFinalización.Name = "HoraFinalización";
            this.HoraFinalización.ReadOnly = true;
            // 
            // FechaEstreno
            // 
            this.FechaEstreno.HeaderText = "FechaEstreno";
            this.FechaEstreno.Name = "FechaEstreno";
            this.FechaEstreno.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // PrecioDesc
            // 
            this.PrecioDesc.HeaderText = "Precio Con Descuento";
            this.PrecioDesc.Name = "PrecioDesc";
            this.PrecioDesc.ReadOnly = true;
            // 
            // Asiento
            // 
            this.Asiento.HeaderText = "Asiento";
            this.Asiento.Name = "Asiento";
            this.Asiento.ReadOnly = true;
            // 
            // Descuent
            // 
            this.Descuent.HeaderText = "Descuento";
            this.Descuent.Name = "Descuent";
            this.Descuent.ReadOnly = true;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboTipoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.ItemHeight = 23;
            this.cboTipoCliente.Location = new System.Drawing.Point(871, 100);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(56, 29);
            this.cboTipoCliente.TabIndex = 89;
            this.cboTipoCliente.UseCustomBackColor = true;
            this.cboTipoCliente.UseCustomForeColor = true;
            this.cboTipoCliente.UseSelectable = true;
            this.cboTipoCliente.UseStyleColors = true;
            this.cboTipoCliente.Visible = false;
            // 
            // cboLastFac
            // 
            this.cboLastFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboLastFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboLastFac.FormattingEnabled = true;
            this.cboLastFac.ItemHeight = 23;
            this.cboLastFac.Location = new System.Drawing.Point(809, 100);
            this.cboLastFac.Name = "cboLastFac";
            this.cboLastFac.Size = new System.Drawing.Size(56, 29);
            this.cboLastFac.TabIndex = 90;
            this.cboLastFac.UseCustomBackColor = true;
            this.cboLastFac.UseCustomForeColor = true;
            this.cboLastFac.UseSelectable = true;
            this.cboLastFac.UseStyleColors = true;
            this.cboLastFac.Visible = false;
            // 
            // cboPromo
            // 
            this.cboPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboPromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboPromo.FormattingEnabled = true;
            this.cboPromo.ItemHeight = 23;
            this.cboPromo.Location = new System.Drawing.Point(809, 147);
            this.cboPromo.Name = "cboPromo";
            this.cboPromo.Size = new System.Drawing.Size(56, 29);
            this.cboPromo.TabIndex = 92;
            this.cboPromo.UseCustomBackColor = true;
            this.cboPromo.UseCustomForeColor = true;
            this.cboPromo.UseSelectable = true;
            this.cboPromo.UseStyleColors = true;
            this.cboPromo.Visible = false;
            // 
            // cboDescuento
            // 
            this.cboDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboDescuento.FormattingEnabled = true;
            this.cboDescuento.ItemHeight = 23;
            this.cboDescuento.Location = new System.Drawing.Point(871, 147);
            this.cboDescuento.Name = "cboDescuento";
            this.cboDescuento.Size = new System.Drawing.Size(56, 29);
            this.cboDescuento.TabIndex = 93;
            this.cboDescuento.UseCustomBackColor = true;
            this.cboDescuento.UseCustomForeColor = true;
            this.cboDescuento.UseSelectable = true;
            this.cboDescuento.UseStyleColors = true;
            this.cboDescuento.Visible = false;
            // 
            // cboPrecios
            // 
            this.cboPrecios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboPrecios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboPrecios.FormattingEnabled = true;
            this.cboPrecios.ItemHeight = 23;
            this.cboPrecios.Location = new System.Drawing.Point(809, 187);
            this.cboPrecios.Name = "cboPrecios";
            this.cboPrecios.Size = new System.Drawing.Size(117, 29);
            this.cboPrecios.TabIndex = 95;
            this.cboPrecios.UseCustomBackColor = true;
            this.cboPrecios.UseCustomForeColor = true;
            this.cboPrecios.UseSelectable = true;
            this.cboPrecios.UseStyleColors = true;
            this.cboPrecios.Visible = false;
            // 
            // cboSala
            // 
            this.cboSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.cboSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.cboSala.FormattingEnabled = true;
            this.cboSala.ItemHeight = 23;
            this.cboSala.Location = new System.Drawing.Point(810, 230);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(117, 29);
            this.cboSala.TabIndex = 97;
            this.cboSala.UseCustomBackColor = true;
            this.cboSala.UseCustomForeColor = true;
            this.cboSala.UseSelectable = true;
            this.cboSala.UseStyleColors = true;
            this.cboSala.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(809, 145);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(81, 31);
            this.metroButton1.TabIndex = 98;
            this.metroButton1.Text = "Cliente Nuevo";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // lbAsiento
            // 
            this.lbAsiento.AutoSize = true;
            this.lbAsiento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbAsiento.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbAsiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbAsiento.Location = new System.Drawing.Point(810, 262);
            this.lbAsiento.Name = "lbAsiento";
            this.lbAsiento.Size = new System.Drawing.Size(0, 0);
            this.lbAsiento.TabIndex = 99;
            this.lbAsiento.UseCustomBackColor = true;
            this.lbAsiento.UseCustomForeColor = true;
            this.lbAsiento.UseStyleColors = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(841, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 233);
            this.panel2.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.panel1.BackgroundImage = global::CapaVista.Properties.Resources.notepad_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(383, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 105);
            this.panel1.TabIndex = 2;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbAsiento);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.cboPrecios);
            this.Controls.Add(this.cboDescuento);
            this.Controls.Add(this.cboPromo);
            this.Controls.Add(this.cboLastFac);
            this.Controls.Add(this.cboTipoCliente);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lbNuevoCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel lbNuevoCliente;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbProyeccion;
        private MetroFramework.Controls.MetroComboBox cboProyeccion;
        private MetroFramework.Controls.MetroComboBox cboEmpleado;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboCliente;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DtFecha;
        private MetroFramework.Controls.MetroLabel LbFecha;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroLabel lbValor;
        private MetroFramework.Controls.MetroComboBox cboTipoCliente;
        private MetroFramework.Controls.MetroComboBox cboLastFac;
        private MetroFramework.Controls.MetroComboBox cboPromo;
        private MetroFramework.Controls.MetroComboBox cboDescuento;
        private MetroFramework.Controls.MetroComboBox cboPrecios;
        private MetroFramework.Controls.MetroComboBox cboSala;
        public System.Windows.Forms.DataGridView dgvVentas;
        private MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroLabel lbAsiento;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox cboAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProyeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinalización;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEstreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuent;
        private System.Windows.Forms.Panel panel2;
    }
}