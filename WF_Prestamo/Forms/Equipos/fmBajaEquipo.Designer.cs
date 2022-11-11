namespace WF_Prestamo.Forms.Equipos
{
    partial class fmBajaEquipo
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoEquipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEquipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "Id", true));
            this.txtId.Location = new System.Drawing.Point(95, 10);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(145, 20);
            this.txtId.TabIndex = 24;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.No;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "NombreEquipo", true));
            this.txtNombre.Location = new System.Drawing.Point(95, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(95, 110);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(145, 23);
            this.btnBaja.TabIndex = 23;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID:";
            // 
            // txtTipoEquipo
            // 
            this.txtTipoEquipo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTipoEquipo.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTipoEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipoBindingSource, "TipoEquipo", true));
            this.txtTipoEquipo.Location = new System.Drawing.Point(95, 36);
            this.txtTipoEquipo.Name = "txtTipoEquipo";
            this.txtTipoEquipo.ReadOnly = true;
            this.txtTipoEquipo.Size = new System.Drawing.Size(145, 20);
            this.txtTipoEquipo.TabIndex = 26;
            this.txtTipoEquipo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Estado:";
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Equipo);
            // 
            // tipoEquipoBindingSource
            // 
            this.tipoEquipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.TipoEquipo);
            // 
            // fmBajaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 159);
            this.Controls.Add(this.txtTipoEquipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBaja);
            this.Name = "fmBajaEquipo";
            this.Text = "Eliminar Equipo";
            this.Load += new System.EventHandler(this.fmBajaEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEquipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.BindingSource tipoEquipoBindingSource;
        private System.Windows.Forms.TextBox txtTipoEquipo;
        private System.Windows.Forms.Label label4;
    }
}