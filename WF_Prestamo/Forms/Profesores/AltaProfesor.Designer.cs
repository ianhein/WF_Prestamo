namespace WF_Prestamo.Forms
{
    partial class AltaProfesor
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
            this.profeNombreTxt = new System.Windows.Forms.TextBox();
            this.profeApellidoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profeNombreTxt
            // 
            this.profeNombreTxt.Location = new System.Drawing.Point(79, 36);
            this.profeNombreTxt.Name = "profeNombreTxt";
            this.profeNombreTxt.Size = new System.Drawing.Size(145, 20);
            this.profeNombreTxt.TabIndex = 0;
            this.profeNombreTxt.TextChanged += new System.EventHandler(this.profeNombreTxt_TextChanged);
            // 
            // profeApellidoTxt
            // 
            this.profeApellidoTxt.Location = new System.Drawing.Point(79, 72);
            this.profeApellidoTxt.Name = "profeApellidoTxt";
            this.profeApellidoTxt.Size = new System.Drawing.Size(145, 20);
            this.profeApellidoTxt.TabIndex = 1;
            this.profeApellidoTxt.TextChanged += new System.EventHandler(this.profeApellidoTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profeApellidoTxt);
            this.Controls.Add(this.profeNombreTxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaProfesor";
            this.Text = "AltaProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox profeNombreTxt;
        private System.Windows.Forms.TextBox profeApellidoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}