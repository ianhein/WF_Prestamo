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
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEquipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Prestamo);
            // 
            // txtProfesor
            // 
            this.txtProfesor.AutoSize = true;
            this.txtProfesor.Location = new System.Drawing.Point(97, 18);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(49, 13);
            this.txtProfesor.TabIndex = 0;
            this.txtProfesor.Text = "Profesor:";
            this.txtProfesor.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubicación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 157);
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
            this.comboBoxProfesor.Location = new System.Drawing.Point(152, 18);
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
            this.comboBoxUbicacion.Location = new System.Drawing.Point(152, 45);
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
            this.comboBox3.Location = new System.Drawing.Point(152, 75);
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
            this.comboBoxUsuario.Location = new System.Drawing.Point(152, 129);
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
            this.dateTimeFechaPrestamo.Location = new System.Drawing.Point(152, 157);
            this.dateTimeFechaPrestamo.Name = "dateTimeFechaPrestamo";
            this.dateTimeFechaPrestamo.Size = new System.Drawing.Size(197, 20);
            this.dateTimeFechaPrestamo.TabIndex = 11;
            this.dateTimeFechaPrestamo.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 102);
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
            this.comboBox2.Location = new System.Drawing.Point(152, 102);
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
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora inicio del préstamo:";
            // 
            // dateTimeHoraInicio
            // 
            this.dateTimeHoraInicio.CustomFormat = "HH:mm";
            this.dateTimeHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeHoraInicio.Location = new System.Drawing.Point(152, 185);
            this.dateTimeHoraInicio.Name = "dateTimeHoraInicio";
            this.dateTimeHoraInicio.ShowUpDown = true;
            this.dateTimeHoraInicio.Size = new System.Drawing.Size(197, 20);
            this.dateTimeHoraInicio.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hora fin del préstamo:";
            // 
            // dateTimeHoraFin
            // 
            this.dateTimeHoraFin.CustomFormat = "HH:mm";
            this.dateTimeHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeHoraFin.Location = new System.Drawing.Point(152, 212);
            this.dateTimeHoraFin.Name = "dateTimeHoraFin";
            this.dateTimeHoraFin.ShowUpDown = true;
            this.dateTimeHoraFin.Size = new System.Drawing.Size(197, 20);
            this.dateTimeHoraFin.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 238);
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
            "Cancelado"});
            this.comboBoxEstadoPrestamo.Location = new System.Drawing.Point(152, 238);
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
            // fmAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 322);
            this.Controls.Add(this.buttonAltaPrestamo);
            this.Controls.Add(this.comboBoxEstadoPrestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimeHoraFin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimeHoraInicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeFechaPrestamo);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBoxUbicacion);
            this.Controls.Add(this.comboBoxProfesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfesor);
            this.Name = "fmAltaPrestamo";
            this.Text = "fmAltaPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEquipoBindingSource)).EndInit();
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
    }
}