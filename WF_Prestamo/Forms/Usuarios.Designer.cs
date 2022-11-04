namespace WF_Prestamo.Forms
{
    partial class Usuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profesoresYUbicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUbicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPréstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(253, 341);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.userDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGridViewTextBoxColumn.Frozen = true;
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            this.userDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGridViewTextBoxColumn.Width = 230;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(WF_Prestamo.Entidades.Usuario);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 401);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoresYUbicaciónToolStripMenuItem,
            this.ubicacionesToolStripMenuItem,
            this.equipoToolStripMenuItem,
            this.préstamosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // profesoresYUbicaciónToolStripMenuItem
            // 
            this.profesoresYUbicaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarProfesoresToolStripMenuItem});
            this.profesoresYUbicaciónToolStripMenuItem.Name = "profesoresYUbicaciónToolStripMenuItem";
            this.profesoresYUbicaciónToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.profesoresYUbicaciónToolStripMenuItem.Text = "Profesores";
            this.profesoresYUbicaciónToolStripMenuItem.Click += new System.EventHandler(this.profesoresYUbicaciónToolStripMenuItem_Click);
            // 
            // listarProfesoresToolStripMenuItem
            // 
            this.listarProfesoresToolStripMenuItem.Name = "listarProfesoresToolStripMenuItem";
            this.listarProfesoresToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listarProfesoresToolStripMenuItem.Text = "Listar Profesores";
            this.listarProfesoresToolStripMenuItem.Click += new System.EventHandler(this.listarProfesoresToolStripMenuItem_Click);
            // 
            // ubicacionesToolStripMenuItem
            // 
            this.ubicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarUbicacionesToolStripMenuItem});
            this.ubicacionesToolStripMenuItem.Name = "ubicacionesToolStripMenuItem";
            this.ubicacionesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ubicacionesToolStripMenuItem.Text = "Ubicaciones";
            // 
            // listarUbicacionesToolStripMenuItem
            // 
            this.listarUbicacionesToolStripMenuItem.Name = "listarUbicacionesToolStripMenuItem";
            this.listarUbicacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarUbicacionesToolStripMenuItem.Text = "Listar Ubicaciones";
            this.listarUbicacionesToolStripMenuItem.Click += new System.EventHandler(this.listarUbicacionesToolStripMenuItem_Click);
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarEquiposToolStripMenuItem});
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // listarEquiposToolStripMenuItem
            // 
            this.listarEquiposToolStripMenuItem.Name = "listarEquiposToolStripMenuItem";
            this.listarEquiposToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listarEquiposToolStripMenuItem.Text = "Listar Equipos";
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarPréstamosToolStripMenuItem});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // listarPréstamosToolStripMenuItem
            // 
            this.listarPréstamosToolStripMenuItem.Name = "listarPréstamosToolStripMenuItem";
            this.listarPréstamosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listarPréstamosToolStripMenuItem.Text = "Listar Préstamos";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profesoresYUbicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUbicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPréstamosToolStripMenuItem;
    }
}