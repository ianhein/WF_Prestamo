namespace WF_Prestamo.Forms.Ubicaciones
{
    partial class fmUbicacion
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
            this.dataUbicacion = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBajaUbicacion = new System.Windows.Forms.Button();
            this.btnAltaUbicacion = new System.Windows.Forms.Button();
            this.edificioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUbicacion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataUbicacion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicaciones";
            // 
            // dataUbicacion
            // 
            this.dataUbicacion.AllowUserToAddRows = false;
            this.dataUbicacion.AllowUserToDeleteRows = false;
            this.dataUbicacion.AllowUserToResizeColumns = false;
            this.dataUbicacion.AllowUserToResizeRows = false;
            this.dataUbicacion.AutoGenerateColumns = false;
            this.dataUbicacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUbicacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edificioDataGridViewTextBoxColumn,
            this.aulaDataGridViewTextBoxColumn});
            this.dataUbicacion.DataSource = this.ubicacionBindingSource;
            this.dataUbicacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataUbicacion.Location = new System.Drawing.Point(3, 16);
            this.dataUbicacion.Name = "dataUbicacion";
            this.dataUbicacion.ReadOnly = true;
            this.dataUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataUbicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUbicacion.ShowCellErrors = false;
            this.dataUbicacion.ShowCellToolTips = false;
            this.dataUbicacion.ShowEditingIcon = false;
            this.dataUbicacion.Size = new System.Drawing.Size(240, 431);
            this.dataUbicacion.TabIndex = 0;
            this.dataUbicacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnBajaUbicacion);
            this.groupBox2.Controls.Add(this.btnAltaUbicacion);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(265, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ABM";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar Ubicacion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBajaUbicacion
            // 
            this.btnBajaUbicacion.Location = new System.Drawing.Point(6, 48);
            this.btnBajaUbicacion.Name = "btnBajaUbicacion";
            this.btnBajaUbicacion.Size = new System.Drawing.Size(113, 23);
            this.btnBajaUbicacion.TabIndex = 1;
            this.btnBajaUbicacion.Text = "Eliminar Ubicacion";
            this.btnBajaUbicacion.UseVisualStyleBackColor = true;
            this.btnBajaUbicacion.Click += new System.EventHandler(this.btnBajaUbicacion_Click);
            // 
            // btnAltaUbicacion
            // 
            this.btnAltaUbicacion.Location = new System.Drawing.Point(6, 19);
            this.btnAltaUbicacion.Name = "btnAltaUbicacion";
            this.btnAltaUbicacion.Size = new System.Drawing.Size(113, 23);
            this.btnAltaUbicacion.TabIndex = 0;
            this.btnAltaUbicacion.Text = "Alta Ubicacion";
            this.btnAltaUbicacion.UseVisualStyleBackColor = true;
            this.btnAltaUbicacion.Click += new System.EventHandler(this.btnAltaUbicacion_Click);
            // 
            // edificioDataGridViewTextBoxColumn
            // 
            this.edificioDataGridViewTextBoxColumn.DataPropertyName = "Edificio";
            this.edificioDataGridViewTextBoxColumn.HeaderText = "Edificio";
            this.edificioDataGridViewTextBoxColumn.Name = "edificioDataGridViewTextBoxColumn";
            this.edificioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aulaDataGridViewTextBoxColumn
            // 
            this.aulaDataGridViewTextBoxColumn.DataPropertyName = "Aula";
            this.aulaDataGridViewTextBoxColumn.HeaderText = "Aula";
            this.aulaDataGridViewTextBoxColumn.Name = "aulaDataGridViewTextBoxColumn";
            this.aulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Ubicacion);
            // 
            // fmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmUbicacion";
            this.Text = "Ubicacion";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUbicacion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataUbicacion;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBajaUbicacion;
        private System.Windows.Forms.Button btnAltaUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn edificioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aulaDataGridViewTextBoxColumn;
    }
}