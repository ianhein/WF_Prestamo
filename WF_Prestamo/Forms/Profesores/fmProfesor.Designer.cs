namespace WF_Prestamo.Forms
{
    partial class fmProfesor
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
            this.dataProfesores = new System.Windows.Forms.DataGridView();
            this.ModificarProfesor = new System.Windows.Forms.Button();
            this.BajaProfesor = new System.Windows.Forms.Button();
            this.btnAltaProfe = new System.Windows.Forms.Button();
            this.altaBajaModificacion = new System.Windows.Forms.GroupBox();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProfesores)).BeginInit();
            this.altaBajaModificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataProfesores);
            this.groupBox1.Location = new System.Drawing.Point(0, -12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataProfesores
            // 
            this.dataProfesores.AllowUserToAddRows = false;
            this.dataProfesores.AllowUserToDeleteRows = false;
            this.dataProfesores.AllowUserToResizeColumns = false;
            this.dataProfesores.AllowUserToResizeRows = false;
            this.dataProfesores.AutoGenerateColumns = false;
            this.dataProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProfesores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dataProfesores.DataSource = this.profesorBindingSource;
            this.dataProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataProfesores.Location = new System.Drawing.Point(3, 16);
            this.dataProfesores.Name = "dataProfesores";
            this.dataProfesores.ReadOnly = true;
            this.dataProfesores.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProfesores.ShowCellErrors = false;
            this.dataProfesores.ShowCellToolTips = false;
            this.dataProfesores.ShowEditingIcon = false;
            this.dataProfesores.Size = new System.Drawing.Size(519, 405);
            this.dataProfesores.TabIndex = 0;
            this.dataProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProfesores_CellContentClick);
            // 
            // ModificarProfesor
            // 
            this.ModificarProfesor.Location = new System.Drawing.Point(6, 92);
            this.ModificarProfesor.Name = "ModificarProfesor";
            this.ModificarProfesor.Size = new System.Drawing.Size(107, 23);
            this.ModificarProfesor.TabIndex = 3;
            this.ModificarProfesor.Text = "Modificar Profesor";
            this.ModificarProfesor.UseVisualStyleBackColor = true;
            this.ModificarProfesor.Click += new System.EventHandler(this.ModificarProfesor_Click);
            // 
            // BajaProfesor
            // 
            this.BajaProfesor.Location = new System.Drawing.Point(6, 63);
            this.BajaProfesor.Name = "BajaProfesor";
            this.BajaProfesor.Size = new System.Drawing.Size(107, 23);
            this.BajaProfesor.TabIndex = 2;
            this.BajaProfesor.Text = "Eliminar Profesor";
            this.BajaProfesor.UseVisualStyleBackColor = true;
            this.BajaProfesor.Click += new System.EventHandler(this.BajaProfesor_Click);
            // 
            // btnAltaProfe
            // 
            this.btnAltaProfe.Location = new System.Drawing.Point(6, 34);
            this.btnAltaProfe.Name = "btnAltaProfe";
            this.btnAltaProfe.Size = new System.Drawing.Size(107, 23);
            this.btnAltaProfe.TabIndex = 1;
            this.btnAltaProfe.Text = "Agregar Profesor";
            this.btnAltaProfe.UseVisualStyleBackColor = true;
            this.btnAltaProfe.Click += new System.EventHandler(this.btnAltaProfe_Click);
            // 
            // altaBajaModificacion
            // 
            this.altaBajaModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.altaBajaModificacion.Controls.Add(this.btnAltaProfe);
            this.altaBajaModificacion.Controls.Add(this.ModificarProfesor);
            this.altaBajaModificacion.Controls.Add(this.BajaProfesor);
            this.altaBajaModificacion.Location = new System.Drawing.Point(524, 0);
            this.altaBajaModificacion.Name = "altaBajaModificacion";
            this.altaBajaModificacion.Size = new System.Drawing.Size(211, 450);
            this.altaBajaModificacion.TabIndex = 8;
            this.altaBajaModificacion.TabStop = false;
            this.altaBajaModificacion.Text = "ABM";
            this.altaBajaModificacion.Enter += new System.EventHandler(this.altaBajaModificacion_Enter);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Profesor);
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Ubicacion);
            // 
            // fmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 412);
            this.Controls.Add(this.altaBajaModificacion);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmProfesor";
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.fmProfesor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProfesores)).EndInit();
            this.altaBajaModificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private System.Windows.Forms.DataGridView dataProfesores;
        private System.Windows.Forms.Button ModificarProfesor;
        private System.Windows.Forms.Button BajaProfesor;
        private System.Windows.Forms.Button btnAltaProfe;
        private System.Windows.Forms.GroupBox altaBajaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
    }
}