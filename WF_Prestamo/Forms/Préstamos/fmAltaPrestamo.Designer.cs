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
            this.button1 = new System.Windows.Forms.Button();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblAula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.comboBoxProfesor = new System.Windows.Forms.ComboBox();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxAula = new System.Windows.Forms.ComboBox();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datePrestamo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHoraFin = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(105, 41);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(46, 13);
            this.lblProfesor.TabIndex = 2;
            this.lblProfesor.Text = "Profesor";
            this.lblProfesor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(114, 68);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(28, 13);
            this.lblAula.TabIndex = 3;
            this.lblAula.Text = "Aula";
            this.lblAula.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 1120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario";
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(33, 228);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(115, 13);
            this.lblHoraFinal.TabIndex = 7;
            this.lblHoraFinal.Text = "Hora final del prestamo";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(28, 202);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(120, 13);
            this.lblHoraInicio.TabIndex = 8;
            this.lblHoraInicio.Text = "Hora inicio del prestamo";
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(48, 147);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(103, 13);
            this.lblPrestamo.TabIndex = 9;
            this.lblPrestamo.Text = "Estado del prestamo";
            this.lblPrestamo.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(48, 176);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(100, 13);
            this.lblFechaPrestamo.TabIndex = 10;
            this.lblFechaPrestamo.Text = "Fecha del prestamo";
            this.lblFechaPrestamo.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBoxProfesor
            // 
            this.comboBoxProfesor.DataSource = this.profesorBindingSource;
            this.comboBoxProfesor.DisplayMember = "Nombre";
            this.comboBoxProfesor.FormattingEnabled = true;
            this.comboBoxProfesor.Location = new System.Drawing.Point(154, 38);
            this.comboBoxProfesor.Name = "comboBoxProfesor";
            this.comboBoxProfesor.Size = new System.Drawing.Size(241, 21);
            this.comboBoxProfesor.TabIndex = 11;
            this.comboBoxProfesor.ValueMember = "Id";
            this.comboBoxProfesor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Profesor);
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Prestamo);
            // 
            // comboBoxAula
            // 
            this.comboBoxAula.DataSource = this.ubicacionBindingSource;
            this.comboBoxAula.DisplayMember = "Aula";
            this.comboBoxAula.FormattingEnabled = true;
            this.comboBoxAula.Location = new System.Drawing.Point(154, 65);
            this.comboBoxAula.Name = "comboBoxAula";
            this.comboBoxAula.Size = new System.Drawing.Size(241, 21);
            this.comboBoxAula.TabIndex = 12;
            this.comboBoxAula.ValueMember = "IdUbicacion";
            this.comboBoxAula.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Ubicacion);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.equipoBindingSource;
            this.comboBox3.DisplayMember = "NombreEquipo";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(154, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(241, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.ValueMember = "NombreEquipo";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Equipo);
            // 
            // datePrestamo
            // 
            this.datePrestamo.Location = new System.Drawing.Point(154, 170);
            this.datePrestamo.Name = "datePrestamo";
            this.datePrestamo.Size = new System.Drawing.Size(241, 20);
            this.datePrestamo.TabIndex = 18;
            this.datePrestamo.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimeHoraInicio
            // 
            this.dateTimeHoraInicio.CustomFormat = "HH:mm";
            this.dateTimeHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeHoraInicio.Location = new System.Drawing.Point(154, 196);
            this.dateTimeHoraInicio.Name = "dateTimeHoraInicio";
            this.dateTimeHoraInicio.ShowUpDown = true;
            this.dateTimeHoraInicio.Size = new System.Drawing.Size(241, 20);
            this.dateTimeHoraInicio.TabIndex = 19;
            this.dateTimeHoraInicio.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimeHoraFin
            // 
            this.dateTimeHoraFin.CustomFormat = "HH:mm";
            this.dateTimeHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeHoraFin.Location = new System.Drawing.Point(154, 222);
            this.dateTimeHoraFin.Name = "dateTimeHoraFin";
            this.dateTimeHoraFin.ShowUpDown = true;
            this.dateTimeHoraFin.Size = new System.Drawing.Size(241, 20);
            this.dateTimeHoraFin.TabIndex = 20;
            this.dateTimeHoraFin.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Usuario:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usuarioBindingSource;
            this.comboBox1.DisplayMember = "User";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "IdUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Usuario);
            // 
            // fmAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 301);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimeHoraFin);
            this.Controls.Add(this.dateTimeHoraInicio);
            this.Controls.Add(this.datePrestamo);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBoxAula);
            this.Controls.Add(this.comboBoxProfesor);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblHoraFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.button1);
            this.Name = "fmAltaPrestamo";
            this.Text = "fmAltaPrestamo";
            this.Load += new System.EventHandler(this.fmAltaPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHoraFinal;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.ComboBox comboBoxProfesor;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private System.Windows.Forms.ComboBox comboBoxAula;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.DateTimePicker datePrestamo;
        private System.Windows.Forms.DateTimePicker dateTimeHoraFin;
        private System.Windows.Forms.DateTimePicker dateTimeHoraInicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
    }
}