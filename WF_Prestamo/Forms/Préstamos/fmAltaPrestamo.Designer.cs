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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profesor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ubicacion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hora De Final Del Prestamo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hora De Inicio Del Prestamo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Estado Del Prestamo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Fecha Del Prestamo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.profesorBindingSource;
            this.comboBox1.DisplayMember = "Id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Nombre";
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Prestamo);
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Profesor);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.ubicacionBindingSource;
            this.comboBox2.DisplayMember = "Aula";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(160, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(241, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "Aula";
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
            this.comboBox3.Location = new System.Drawing.Point(160, 90);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(241, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.ValueMember = "NombreEquipo";
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Equipo);
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.prestamoBindingSource;
            this.comboBox5.DisplayMember = "EstadoPrestamo";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(160, 150);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(241, 21);
            this.comboBox5.TabIndex = 15;
            this.comboBox5.ValueMember = "EstadoPrestamo";
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.prestamoBindingSource;
            this.comboBox6.DisplayMember = "HoraInicio";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(160, 180);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(241, 21);
            this.comboBox6.TabIndex = 16;
            this.comboBox6.ValueMember = "HoraInicio";
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.prestamoBindingSource;
            this.comboBox7.DisplayMember = "HoraFin";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(160, 210);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(241, 21);
            this.comboBox7.TabIndex = 17;
            this.comboBox7.ValueMember = "HoraFin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // fmAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 301);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "fmAltaPrestamo";
            this.Text = "fmAltaPrestamo";
            this.Load += new System.EventHandler(this.fmAltaPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}