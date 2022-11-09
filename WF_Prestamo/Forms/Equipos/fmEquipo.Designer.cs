namespace WF_Prestamo.Forms.Equipos
{
    partial class fmEquipo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataEquipo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBajaEquipo = new System.Windows.Forms.Button();
            this.btnAltaEquipo = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataEquipo);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 495);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipo";
            // 
            // dataEquipo
            // 
            this.dataEquipo.AllowUserToAddRows = false;
            this.dataEquipo.AllowUserToDeleteRows = false;
            this.dataEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataEquipo.AutoGenerateColumns = false;
            this.dataEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEquipo,
            this.CantidadEquipo,
            this.TipoEquipo});
            this.dataEquipo.DataSource = this.equipoBindingSource;
            this.dataEquipo.Location = new System.Drawing.Point(3, 16);
            this.dataEquipo.Name = "dataEquipo";
            this.dataEquipo.ReadOnly = true;
            this.dataEquipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEquipo.Size = new System.Drawing.Size(339, 472);
            this.dataEquipo.TabIndex = 0;
            this.dataEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnBajaEquipo);
            this.groupBox2.Controls.Add(this.btnAltaEquipo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(359, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 495);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ABM";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(6, 92);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Equipo";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBajaEquipo
            // 
            this.btnBajaEquipo.Location = new System.Drawing.Point(6, 63);
            this.btnBajaEquipo.Name = "btnBajaEquipo";
            this.btnBajaEquipo.Size = new System.Drawing.Size(99, 23);
            this.btnBajaEquipo.TabIndex = 1;
            this.btnBajaEquipo.Text = "Eliminar Equipo";
            this.btnBajaEquipo.UseVisualStyleBackColor = true;
            this.btnBajaEquipo.Click += new System.EventHandler(this.btnBajaEquipo_Click);
            // 
            // btnAltaEquipo
            // 
            this.btnAltaEquipo.Location = new System.Drawing.Point(6, 34);
            this.btnAltaEquipo.Name = "btnAltaEquipo";
            this.btnAltaEquipo.Size = new System.Drawing.Size(99, 23);
            this.btnAltaEquipo.TabIndex = 0;
            this.btnAltaEquipo.Text = "Agregar Equipo";
            this.btnAltaEquipo.UseVisualStyleBackColor = true;
            this.btnAltaEquipo.Click += new System.EventHandler(this.btnAltaEquipo_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TipoEquipo";
            this.dataGridViewTextBoxColumn1.HeaderText = "TipoEquipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Equipo);
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Prestamo);
            // 
            // NombreEquipo
            // 
            this.NombreEquipo.DataPropertyName = "NombreEquipo";
            this.NombreEquipo.HeaderText = "Nombre Equipo";
            this.NombreEquipo.Name = "NombreEquipo";
            this.NombreEquipo.ReadOnly = true;
            this.NombreEquipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CantidadEquipo
            // 
            this.CantidadEquipo.DataPropertyName = "CantidadEquipo";
            this.CantidadEquipo.HeaderText = "Cantidad Equipo";
            this.CantidadEquipo.Name = "CantidadEquipo";
            this.CantidadEquipo.ReadOnly = true;
            this.CantidadEquipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TipoEquipo
            // 
            this.TipoEquipo.DataPropertyName = "TipoEquipo";
            this.TipoEquipo.HeaderText = "Tipo Equipo";
            this.TipoEquipo.Name = "TipoEquipo";
            this.TipoEquipo.ReadOnly = true;
            this.TipoEquipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmEquipo";
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.fmEquipo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBajaEquipo;
        private System.Windows.Forms.Button btnAltaEquipo;
        private System.Windows.Forms.DataGridView dataEquipo;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}