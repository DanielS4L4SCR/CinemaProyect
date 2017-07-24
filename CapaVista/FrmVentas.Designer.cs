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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lbCantidad = new MetroFramework.Controls.MetroLabel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.lbTipoCliente = new MetroFramework.Controls.MetroLabel();
            this.lbValor = new MetroFramework.Controls.MetroLabel();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.IDProyeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinalización = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEstreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.lbCantidad);
            this.groupBox1.Controls.Add(this.cboProyeccion);
            this.groupBox1.Controls.Add(this.lbProyeccion);
            this.groupBox1.Location = new System.Drawing.Point(120, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(167, 91);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 33);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseCustomBackColor = true;
            this.btnAgregar.UseCustomForeColor = true;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.UseStyleColors = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.nudCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.nudCantidad.Location = new System.Drawing.Point(208, 57);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(41, 20);
            this.nudCantidad.TabIndex = 59;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbCantidad.Location = new System.Drawing.Point(137, 58);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(65, 19);
            this.lbCantidad.TabIndex = 58;
            this.lbCantidad.Text = "Cantidad:";
            this.lbCantidad.UseCustomBackColor = true;
            this.lbCantidad.UseCustomForeColor = true;
            this.lbCantidad.UseStyleColors = true;
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
            this.groupBox2.Location = new System.Drawing.Point(496, 146);
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
            this.LbFecha.Location = new System.Drawing.Point(10, 111);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(112, 19);
            this.LbFecha.TabIndex = 66;
            this.LbFecha.Text = "Fecha de estreno:";
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
            this.btnAceptar.Location = new System.Drawing.Point(752, 529);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 33);
            this.btnAceptar.TabIndex = 65;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseCustomBackColor = true;
            this.btnAceptar.UseCustomForeColor = true;
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.UseStyleColors = true;
            // 
            // lbTipoCliente
            // 
            this.lbTipoCliente.AutoSize = true;
            this.lbTipoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.lbTipoCliente.Location = new System.Drawing.Point(798, 166);
            this.lbTipoCliente.Name = "lbTipoCliente";
            this.lbTipoCliente.Size = new System.Drawing.Size(79, 19);
            this.lbTipoCliente.TabIndex = 67;
            this.lbTipoCliente.Text = "Tipo cliente:";
            this.lbTipoCliente.UseCustomBackColor = true;
            this.lbTipoCliente.UseCustomForeColor = true;
            this.lbTipoCliente.UseStyleColors = true;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
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
            this.Cantidad});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(100)))), ((int)(((byte)(104)))));
            this.dgvVentas.Location = new System.Drawing.Point(80, 299);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(747, 209);
            this.dgvVentas.TabIndex = 88;
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(890, 570);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbTipoCliente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lbNuevoCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private MetroFramework.Controls.MetroLabel lbCantidad;
        private MetroFramework.Controls.MetroComboBox cboEmpleado;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboCliente;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DtFecha;
        private MetroFramework.Controls.MetroLabel LbFecha;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroLabel lbTipoCliente;
        private MetroFramework.Controls.MetroLabel lbValor;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProyeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinalización;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEstreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}