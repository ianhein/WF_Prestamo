namespace WF_Prestamo.Test.Forms.Equipos
{
    partial class EquiposForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridEquipo = new System.Windows.Forms.DataGridView();
            this.nombreEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEquipoNombre = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.comboBoxTipoEquipo = new System.Windows.Forms.ComboBox();
            this.tipoEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEquipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEquipo
            // 
            this.dataGridEquipo.AllowDrop = true;
            this.dataGridEquipo.AllowUserToOrderColumns = true;
            this.dataGridEquipo.AllowUserToResizeRows = false;
            this.dataGridEquipo.AutoGenerateColumns = false;
            this.dataGridEquipo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.dataGridEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEquipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEquipoDataGridViewTextBoxColumn,
            this.tipoEquipoDataGridViewTextBoxColumn});
            this.dataGridEquipo.DataSource = this.equipoBindingSource;
            this.dataGridEquipo.EnableHeadersVisualStyles = false;
            this.dataGridEquipo.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridEquipo.Location = new System.Drawing.Point(15, 12);
            this.dataGridEquipo.Name = "dataGridEquipo";
            this.dataGridEquipo.ReadOnly = true;
            this.dataGridEquipo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEquipo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridEquipo.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridEquipo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridEquipo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEquipo.ShowCellErrors = false;
            this.dataGridEquipo.ShowCellToolTips = false;
            this.dataGridEquipo.ShowEditingIcon = false;
            this.dataGridEquipo.Size = new System.Drawing.Size(344, 386);
            this.dataGridEquipo.TabIndex = 0;
            this.dataGridEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProfe_CellContentClick);
            // 
            // nombreEquipoDataGridViewTextBoxColumn
            // 
            this.nombreEquipoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreEquipoDataGridViewTextBoxColumn.DataPropertyName = "NombreEquipo";
            this.nombreEquipoDataGridViewTextBoxColumn.HeaderText = "Nombre Equipo";
            this.nombreEquipoDataGridViewTextBoxColumn.Name = "nombreEquipoDataGridViewTextBoxColumn";
            this.nombreEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEquipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tipoEquipoDataGridViewTextBoxColumn
            // 
            this.tipoEquipoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoEquipoDataGridViewTextBoxColumn.DataPropertyName = "TipoEquipo";
            this.tipoEquipoDataGridViewTextBoxColumn.HeaderText = "Tipo Equipo";
            this.tipoEquipoDataGridViewTextBoxColumn.Name = "tipoEquipoDataGridViewTextBoxColumn";
            this.tipoEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Equipo);
            // 
            // txtEquipoNombre
            // 
            this.txtEquipoNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.txtEquipoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEquipoNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipoNombre.ForeColor = System.Drawing.Color.Transparent;
            this.txtEquipoNombre.Location = new System.Drawing.Point(365, 64);
            this.txtEquipoNombre.Name = "txtEquipoNombre";
            this.txtEquipoNombre.Size = new System.Drawing.Size(408, 20);
            this.txtEquipoNombre.TabIndex = 2;
            this.txtEquipoNombre.Text = "Equipo";
            this.txtEquipoNombre.TextChanged += new System.EventHandler(this.txtProfesorNombre_TextChanged);
            this.txtEquipoNombre.Enter += new System.EventHandler(this.txtEquipoNombre_Enter);
            this.txtEquipoNombre.Leave += new System.EventHandler(this.txtEquipoNombre_Leave);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAlta.FlatAppearance.BorderSize = 0;
            this.btnAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.btnAlta.Location = new System.Drawing.Point(365, 358);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(410, 40);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "Guardar";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnlogin_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(365, 405);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(202, 40);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
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
            this.btnEliminar.Location = new System.Drawing.Point(573, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 40);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.lblmsg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.DarkGray;
            this.lblmsg.Location = new System.Drawing.Point(377, 207);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(35, 17);
            this.lblmsg.TabIndex = 8;
            this.lblmsg.Text = "msg";
            this.lblmsg.Visible = false;
            this.lblmsg.Click += new System.EventHandler(this.lblmsg_Click);
            // 
            // comboBoxTipoEquipo
            // 
            this.comboBoxTipoEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.comboBoxTipoEquipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoEquipoBindingSource, "Estado", true));
            this.comboBoxTipoEquipo.DataSource = this.tipoEquipoBindingSource;
            this.comboBoxTipoEquipo.DisplayMember = "Estado";
            this.comboBoxTipoEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipoEquipo.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxTipoEquipo.FormattingEnabled = true;
            this.comboBoxTipoEquipo.Location = new System.Drawing.Point(365, 151);
            this.comboBoxTipoEquipo.Name = "comboBoxTipoEquipo";
            this.comboBoxTipoEquipo.Size = new System.Drawing.Size(408, 21);
            this.comboBoxTipoEquipo.TabIndex = 9;
            this.comboBoxTipoEquipo.ValueMember = "Id";
            this.comboBoxTipoEquipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoEquipo_SelectedIndexChanged);
            // 
            // tipoEquipoBindingSource
            // 
            this.tipoEquipoBindingSource.DataSource = typeof(WF_Prestamo.Entidades.TipoEquipo);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(785, 457);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 365;
            this.lineShape1.X2 = 771;
            this.lineShape1.Y1 = 86;
            this.lineShape1.Y2 = 86;
            // 
            // EquiposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(785, 457);
            this.Controls.Add(this.comboBoxTipoEquipo);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.dataGridEquipo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtEquipoNombre);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquiposForm";
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.EquiposForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoEquipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEquipo;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private System.Windows.Forms.TextBox txtEquipoNombre;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.ComboBox comboBoxTipoEquipo;
        private System.Windows.Forms.BindingSource tipoEquipoBindingSource;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEquipoDataGridViewTextBoxColumn;
    }
}