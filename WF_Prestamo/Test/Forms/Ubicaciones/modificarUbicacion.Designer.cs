namespace WF_Prestamo.Test.Forms.Ubicaciones
{
    partial class modificarUbicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarUbicacion));
            this.textUbicacion = new System.Windows.Forms.TextBox();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.btnAltaUbicacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textUbicacion
            // 
            this.textUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.textUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUbicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ubicacionBindingSource, "Aula", true));
            this.textUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUbicacion.ForeColor = System.Drawing.Color.Transparent;
            this.textUbicacion.Location = new System.Drawing.Point(23, 27);
            this.textUbicacion.Name = "textUbicacion";
            this.textUbicacion.Size = new System.Drawing.Size(245, 20);
            this.textUbicacion.TabIndex = 9;
            this.textUbicacion.Text = "Aula";
            this.textUbicacion.TextChanged += new System.EventHandler(this.textNombreP_TextChanged);
            // 
            // txtEdificio
            // 
            this.txtEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.txtEdificio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdificio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ubicacionBindingSource, "Edificio", true));
            this.txtEdificio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdificio.ForeColor = System.Drawing.Color.Transparent;
            this.txtEdificio.Location = new System.Drawing.Point(23, 64);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(245, 20);
            this.txtEdificio.TabIndex = 9;
            this.txtEdificio.Text = "Edificio";
            this.txtEdificio.TextChanged += new System.EventHandler(this.textApellidoP_TextChanged);
            // 
            // btnAltaUbicacion
            // 
            this.btnAltaUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAltaUbicacion.FlatAppearance.BorderSize = 0;
            this.btnAltaUbicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAltaUbicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAltaUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.btnAltaUbicacion.Location = new System.Drawing.Point(23, 117);
            this.btnAltaUbicacion.Name = "btnAltaUbicacion";
            this.btnAltaUbicacion.Size = new System.Drawing.Size(245, 40);
            this.btnAltaUbicacion.TabIndex = 9;
            this.btnAltaUbicacion.Text = "Actualizar";
            this.btnAltaUbicacion.UseVisualStyleBackColor = false;
            this.btnAltaUbicacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.lineShape1.X1 = 23;
            this.lineShape1.X2 = 262;
            this.lineShape1.Y1 = 49;
            this.lineShape1.Y2 = 49;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 24;
            this.lineShape2.X2 = 263;
            this.lineShape2.Y1 = 86;
            this.lineShape2.Y2 = 86;
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Ubicacion);
            // 
            // modificarUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(306, 172);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAltaUbicacion);
            this.Controls.Add(this.textUbicacion);
            this.Controls.Add(this.txtEdificio);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modificarUbicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarUbicacion";
            this.Load += new System.EventHandler(this.modificarUbicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.TextBox textUbicacion;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.Button btnAltaUbicacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}