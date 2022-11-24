namespace WF_Prestamo.Test.Forms
{
    partial class modificarProfesor
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
            this.textNombreP = new System.Windows.Forms.TextBox();
            this.textApellidoP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombreP
            // 
            this.textNombreP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.textNombreP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombreP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorBindingSource, "Nombre", true));
            this.textNombreP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreP.ForeColor = System.Drawing.Color.Transparent;
            this.textNombreP.Location = new System.Drawing.Point(23, 27);
            this.textNombreP.Name = "textNombreP";
            this.textNombreP.Size = new System.Drawing.Size(245, 20);
            this.textNombreP.TabIndex = 9;
            this.textNombreP.Text = "Nombre";
            this.textNombreP.TextChanged += new System.EventHandler(this.textNombreP_TextChanged);
            // 
            // textApellidoP
            // 
            this.textApellidoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.textApellidoP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textApellidoP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorBindingSource, "Apellido", true));
            this.textApellidoP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellidoP.ForeColor = System.Drawing.Color.Transparent;
            this.textApellidoP.Location = new System.Drawing.Point(23, 68);
            this.textApellidoP.Name = "textApellidoP";
            this.textApellidoP.Size = new System.Drawing.Size(245, 20);
            this.textApellidoP.TabIndex = 9;
            this.textApellidoP.Text = "Apellido";
            this.textApellidoP.TextChanged += new System.EventHandler(this.textApellidoP_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.button1.Location = new System.Drawing.Point(23, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Profesor);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(306, 172);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 267;
            this.lineShape1.Y1 = 47;
            this.lineShape1.Y2 = 47;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 23;
            this.lineShape2.X2 = 266;
            this.lineShape2.Y1 = 88;
            this.lineShape2.Y2 = 88;
            // 
            // modificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(306, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textApellidoP);
            this.Controls.Add(this.textNombreP);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modificarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarProfesor";
            this.Load += new System.EventHandler(this.modificarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombreP;
        private System.Windows.Forms.TextBox textApellidoP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}