namespace WF_Prestamo.Forms
{
    partial class fmBajaProfesores
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
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorBindingSource, "Id", true));
            this.textBox1.Location = new System.Drawing.Point(79, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Profesor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorBindingSource, "Apellido", true));
            this.textBox2.Location = new System.Drawing.Point(79, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorBindingSource, "Nombre", true));
            this.textBox3.Location = new System.Drawing.Point(79, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID:";
            // 
            // fmBajaProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(269, 141);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBajaProfesores";
            this.ShowIcon = false;
            this.Text = "Eliminar Profesor";
            this.Load += new System.EventHandler(this.fmBajaProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}