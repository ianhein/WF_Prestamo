namespace WF_Prestamo.Forms.Préstamos
{
    partial class fmAltaPrestamo
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
            this.components = new System.ComponentModel.Container();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtProfesor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProfesor = new System.Windows.Forms.ComboBox();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tipoEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxEstadoPrestamo = new System.Windows.Forms.ComboBox();
            this.buttonAltaPrestamo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEquipoBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Prestamo);
            // 
            // txtProfesor
            // 
            this.txtProfesor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtProfesor.AutoSize = true;
            this.txtProfesor.Location = new System.Drawing.Point(82, 7);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(49, 13);
            this.txtProfesor.TabIndex = 0;
            this.txtProfesor.Text = "Profesor:";
            this.txtProfesor.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubicación:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha del préstamo:";
            // 
            // comboBoxProfesor
            // 
            this.comboBoxProfesor.DataSource = this.profesorBindingSource;
            this.comboBoxProfesor.DisplayMember = "NombreCompleto";
            this.comboBoxProfesor.FormattingEnabled = true;
            this.comboBoxProfesor.Location = new System.Drawing.Point(152, 12);
            this.comboBoxProfesor.Name = "comboBoxProfesor";
            this.comboBoxProfesor.Size = new System.Drawing.Size(197, 21);
            this.comboBoxProfesor.TabIndex = 6;
            this.comboBoxProfesor.ValueMember = "Id";
            this.comboBoxProfesor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Profesor);
            // 
            // comboBoxUbicacion
            // 
            this.comboBoxUbicacion.DataSource = this.ubicacionBindingSource;
            this.comboBoxUbicacion.DisplayMember = "NombreCompleto";
            this.comboBoxUbicacion.FormattingEnabled = true;
            this.comboBoxUbicacion.Location = new System.Drawing.Point(152, 40);
            this.comboBoxUbicacion.Name = "comboBoxUbicacion";
            this.comboBoxUbicacion.Size = new System.Drawing.Size(197, 21);
            this.comboBoxUbicacion.TabIndex = 7;
            this.comboBoxUbicacion.ValueMember = "Id";
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Ubicacion);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.equipoBindingSource;
            this.comboBox3.DisplayMember = "NombreCompleto";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(152, 68);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(197, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.ValueMember = "Id";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Equipo);
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.DataSource = this.usuarioBindingSource;
            this.comboBoxUsuario.DisplayMember = "User";
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(152, 125);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(197, 21);
            this.comboBoxUsuario.TabIndex = 9;
            this.comboBoxUsuario.ValueMember = "IdUsuario";
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Usuario);
            // 
            // dateTimeFechaPrestamo
            // 
            this.dateTimeFechaPrestamo.Location = new System.Drawing.Point(152, 152);
            this.dateTimeFechaPrestamo.Name = "dateTimeFechaPrestamo";
            this.dateTimeFechaPrestamo.Size = new System.Drawing.Size(197, 20);
            this.dateTimeFechaPrestamo.TabIndex = 11;
            this.dateTimeFechaPrestamo.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Estado del equipo";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tipoEquipoBindingSource;
            this.comboBox2.DisplayMember = "Nombre";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.ValueMember = "Id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tipoEquipoBindingSource
            // 
            this.tipoEquipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.TipoEquipo);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora inicio del préstamo:";
            // 
            // dateTimeHoraInicio
            // 
            this.dateTimeHoraInicio.CustomFormat = "HH:mm";
            this.dateTimeHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeHoraInicio.Location = new System.Drawing.Point(152, 180);
            this.dateTimeHoraInicio.Name = "dateTimeHoraInicio";
            this.dateTimeHoraInicio.ShowUpDown = true;
            this.dateTimeHoraInicio.Size = new System.Drawing.Size(197, 20);
            this.dateTimeHoraInicio.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hora fin del préstamo:";
            // 
            // dateTimeHoraFin
            // 
            this.dateTimeHoraFin.CustomFormat = "HH:mm";
            this.dateTimeHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeHoraFin.Location = new System.Drawing.Point(152, 208);
            this.dateTimeHoraFin.Name = "dateTimeHoraFin";
            this.dateTimeHoraFin.ShowUpDown = true;
            this.dateTimeHoraFin.Size = new System.Drawing.Size(197, 20);
            this.dateTimeHoraFin.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Estado del préstamo;";
            // 
            // comboBoxEstadoPrestamo
            // 
            this.comboBoxEstadoPrestamo.FormattingEnabled = true;
            this.comboBoxEstadoPrestamo.Items.AddRange(new object[] {
            "Pendiente",
            "Aceptado",
            "Cancelado",
            "Finalizado"});
            this.comboBoxEstadoPrestamo.Location = new System.Drawing.Point(152, 236);
            this.comboBoxEstadoPrestamo.Name = "comboBoxEstadoPrestamo";
            this.comboBoxEstadoPrestamo.Size = new System.Drawing.Size(197, 21);
            this.comboBoxEstadoPrestamo.TabIndex = 21;
            this.comboBoxEstadoPrestamo.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstadoPrestamo_SelectedIndexChanged);
            // 
            // buttonAltaPrestamo
            // 
            this.buttonAltaPrestamo.Location = new System.Drawing.Point(152, 287);
            this.buttonAltaPrestamo.Name = "buttonAltaPrestamo";
            this.buttonAltaPrestamo.Size = new System.Drawing.Size(197, 23);
            this.buttonAltaPrestamo.TabIndex = 22;
            this.buttonAltaPrestamo.Text = "Guardar";
            this.buttonAltaPrestamo.UseVisualStyleBackColor = true;
            this.buttonAltaPrestamo.Click += new System.EventHandler(this.buttonAltaPrestamo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtProfesor, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(134, 245);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // fmAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 322);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBoxEstadoPrestamo);
            this.Controls.Add(this.dateTimeHoraFin);
            this.Controls.Add(this.dateTimeHoraInicio);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimeFechaPrestamo);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.comboBoxUbicacion);
            this.Controls.Add(this.comboBoxProfesor);
            this.Controls.Add(this.buttonAltaPrestamo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fmAltaPrestamo";
            this.Text = "fmAltaPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEquipoBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private System.Windows.Forms.Label txtProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProfesor;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.ComboBox comboBoxUbicacion;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimeFechaPrestamo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource tipoEquipoBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeHoraInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeHoraFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxEstadoPrestamo;
        private System.Windows.Forms.Button buttonAltaPrestamo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}