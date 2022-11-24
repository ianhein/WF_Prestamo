namespace WF_Prestamo.Test.Forms.Prestamos
{
    partial class prestamoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridProfe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEquipoPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProfe
            // 
            this.dataGridProfe.AllowDrop = true;
            this.dataGridProfe.AllowUserToAddRows = false;
            this.dataGridProfe.AllowUserToDeleteRows = false;
            this.dataGridProfe.AllowUserToResizeRows = false;
            this.dataGridProfe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridProfe.AutoGenerateColumns = false;
            this.dataGridProfe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.dataGridProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProfe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProfe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProfe.ColumnHeadersHeight = 35;
            this.dataGridProfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridProfe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaFinDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.equipoPrestamoDataGridViewTextBoxColumn,
            this.profesorPrestamoDataGridViewTextBoxColumn,
            this.ubicacionPrestamoDataGridViewTextBoxColumn,
            this.usuarioPrestamoDataGridViewTextBoxColumn,
            this.tipoEquipoPrestamoDataGridViewTextBoxColumn,
            this.fechaPrestamoDataGridViewTextBoxColumn});
            this.dataGridProfe.DataSource = this.prestamoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProfe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProfe.EnableHeadersVisualStyles = false;
            this.dataGridProfe.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridProfe.Location = new System.Drawing.Point(10, 12);
            this.dataGridProfe.Name = "dataGridProfe";
            this.dataGridProfe.ReadOnly = true;
            this.dataGridProfe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProfe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridProfe.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridProfe.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridProfe.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridProfe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProfe.ShowCellErrors = false;
            this.dataGridProfe.ShowCellToolTips = false;
            this.dataGridProfe.ShowEditingIcon = false;
            this.dataGridProfe.Size = new System.Drawing.Size(850, 344);
            this.dataGridProfe.TabIndex = 0;
            this.dataGridProfe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProfe_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdPrestamo";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "Hora Inicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaFinDataGridViewTextBoxColumn
            // 
            this.horaFinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horaFinDataGridViewTextBoxColumn.DataPropertyName = "HoraFin";
            this.horaFinDataGridViewTextBoxColumn.HeaderText = "Hora Fin";
            this.horaFinDataGridViewTextBoxColumn.Name = "horaFinDataGridViewTextBoxColumn";
            this.horaFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EstadoPrestamo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Estado Prestamo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // equipoPrestamoDataGridViewTextBoxColumn
            // 
            this.equipoPrestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipoPrestamoDataGridViewTextBoxColumn.DataPropertyName = "EquipoPrestamo";
            this.equipoPrestamoDataGridViewTextBoxColumn.HeaderText = "Equipo Prestamo";
            this.equipoPrestamoDataGridViewTextBoxColumn.Name = "equipoPrestamoDataGridViewTextBoxColumn";
            this.equipoPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesorPrestamoDataGridViewTextBoxColumn
            // 
            this.profesorPrestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.profesorPrestamoDataGridViewTextBoxColumn.DataPropertyName = "ProfesorPrestamo";
            this.profesorPrestamoDataGridViewTextBoxColumn.HeaderText = "Profesor Prestamo";
            this.profesorPrestamoDataGridViewTextBoxColumn.Name = "profesorPrestamoDataGridViewTextBoxColumn";
            this.profesorPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionPrestamoDataGridViewTextBoxColumn
            // 
            this.ubicacionPrestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ubicacionPrestamoDataGridViewTextBoxColumn.DataPropertyName = "UbicacionPrestamo";
            this.ubicacionPrestamoDataGridViewTextBoxColumn.HeaderText = "Ubicacion Prestamo";
            this.ubicacionPrestamoDataGridViewTextBoxColumn.Name = "ubicacionPrestamoDataGridViewTextBoxColumn";
            this.ubicacionPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ubicacionPrestamoDataGridViewTextBoxColumn.Width = 139;
            // 
            // usuarioPrestamoDataGridViewTextBoxColumn
            // 
            this.usuarioPrestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuarioPrestamoDataGridViewTextBoxColumn.DataPropertyName = "UsuarioPrestamo";
            this.usuarioPrestamoDataGridViewTextBoxColumn.HeaderText = "Usuario Prestamo";
            this.usuarioPrestamoDataGridViewTextBoxColumn.Name = "usuarioPrestamoDataGridViewTextBoxColumn";
            this.usuarioPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoEquipoPrestamoDataGridViewTextBoxColumn
            // 
            this.tipoEquipoPrestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoEquipoPrestamoDataGridViewTextBoxColumn.DataPropertyName = "TipoEquipoPrestamo";
            this.tipoEquipoPrestamoDataGridViewTextBoxColumn.HeaderText = "Tipo Equipo";
            this.tipoEquipoPrestamoDataGridViewTextBoxColumn.Name = "tipoEquipoPrestamoDataGridViewTextBoxColumn";
            this.tipoEquipoPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPrestamoDataGridViewTextBoxColumn
            // 
            this.fechaPrestamoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "FechaPrestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.HeaderText = "Fecha Prestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.Name = "fechaPrestamoDataGridViewTextBoxColumn";
            this.fechaPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Prestamo);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.btn.Location = new System.Drawing.Point(272, 405);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(330, 40);
            this.btn.TabIndex = 5;
            this.btn.Text = "Agregar préstamo";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.btnModificar.Location = new System.Drawing.Point(55, 404);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(202, 41);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar préstamo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.btnEliminar.Location = new System.Drawing.Point(614, 404);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Finalizar préstamo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.lblmsg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.DarkGray;
            this.lblmsg.Location = new System.Drawing.Point(416, 371);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(35, 17);
            this.lblmsg.TabIndex = 8;
            this.lblmsg.Text = "msg";
            this.lblmsg.Visible = false;
            this.lblmsg.Click += new System.EventHandler(this.lblmsg_Click);
            // 
            // prestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(872, 457);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.dataGridProfe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "prestamoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarPrestamo";
            this.Load += new System.EventHandler(this.prestamoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProfe;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEquipoPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
    }
}