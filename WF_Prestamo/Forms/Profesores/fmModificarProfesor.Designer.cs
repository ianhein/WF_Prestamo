﻿namespace WF_Prestamo.Forms
{
    partial class fmModificarProfesor
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ModificarProfeNombre = new System.Windows.Forms.Label();
            this.ModificarProfeApellido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorBindingSource, "Nombre", true));
            this.textBox1.Location = new System.Drawing.Point(79, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorBindingSource, "Apellido", true));
            this.textBox2.Location = new System.Drawing.Point(79, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ModificarProfeNombre
            // 
            this.ModificarProfeNombre.AutoSize = true;
            this.ModificarProfeNombre.Location = new System.Drawing.Point(26, 42);
            this.ModificarProfeNombre.Name = "ModificarProfeNombre";
            this.ModificarProfeNombre.Size = new System.Drawing.Size(47, 13);
            this.ModificarProfeNombre.TabIndex = 7;
            this.ModificarProfeNombre.Text = "Nombre:";
            // 
            // ModificarProfeApellido
            // 
            this.ModificarProfeApellido.AutoSize = true;
            this.ModificarProfeApellido.Location = new System.Drawing.Point(26, 68);
            this.ModificarProfeApellido.Name = "ModificarProfeApellido";
            this.ModificarProfeApellido.Size = new System.Drawing.Size(47, 13);
            this.ModificarProfeApellido.TabIndex = 8;
            this.ModificarProfeApellido.Text = "Apellido:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorBindingSource, "Id", true));
            this.textBox3.Location = new System.Drawing.Point(79, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID;";
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Profesor);
            this.profesorBindingSource.CurrentChanged += new System.EventHandler(this.profesorBindingSource_CurrentChanged);
            // 
            // fmModificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 141);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ModificarProfeApellido);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ModificarProfeNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmModificarProfesor";
            this.ShowIcon = false;
            this.Text = "Modificar Profesor";
            this.Load += new System.EventHandler(this.ModificarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ModificarProfeNombre;
        private System.Windows.Forms.Label ModificarProfeApellido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}