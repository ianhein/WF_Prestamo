namespace WF_Prestamo.Test.Forms.Equipos
{
    partial class modificarEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarEquipos));
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxTipoEquipo = new System.Windows.Forms.ComboBox();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.txtBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "NombreEquipo", true));
            this.txtBoxNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.ForeColor = System.Drawing.Color.Transparent;
            this.txtBoxNombre.Location = new System.Drawing.Point(23, 21);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(279, 20);
            this.txtBoxNombre.TabIndex = 9;
            this.txtBoxNombre.Text = "Equipo";
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Equipo);
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
            this.button1.Location = new System.Drawing.Point(24, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxTipoEquipo
            // 
            this.comboBoxTipoEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.comboBoxTipoEquipo.DataSource = this.equipoBindingSource;
            this.comboBoxTipoEquipo.DisplayMember = "TipoEquipo";
            this.comboBoxTipoEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoEquipo.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxTipoEquipo.FormattingEnabled = true;
            this.comboBoxTipoEquipo.Location = new System.Drawing.Point(23, 67);
            this.comboBoxTipoEquipo.Name = "comboBoxTipoEquipo";
            this.comboBoxTipoEquipo.Size = new System.Drawing.Size(246, 21);
            this.comboBoxTipoEquipo.TabIndex = 13;
            this.comboBoxTipoEquipo.ValueMember = "Id";
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Prestamo);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(306, 172);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 268;
            this.lineShape1.Y1 = 42;
            this.lineShape1.Y2 = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // modificarEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(306, 172);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxTipoEquipo);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modificarEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarPrestamo";
            this.Load += new System.EventHandler(this.modificarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxTipoEquipo;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}