namespace WindowsFormsApp3
{
    partial class FormAgregarGrupo
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
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarGrupo));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEscuela = new System.Windows.Forms.Label();
            this.txbEscuela = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.numGrado = new System.Windows.Forms.NumericUpDown();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(88, 103);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Location = new System.Drawing.Point(46, 59);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(48, 13);
            this.lblEscuela.TabIndex = 1;
            this.lblEscuela.Text = "Escuela:";
            // 
            // txbEscuela
            // 
            this.txbEscuela.Location = new System.Drawing.Point(100, 59);
            this.txbEscuela.Name = "txbEscuela";
            this.txbEscuela.Size = new System.Drawing.Size(100, 20);
            this.txbEscuela.TabIndex = 2;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(124, 18);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 9;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(44, 18);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(39, 13);
            this.lblGrado.TabIndex = 0;
            this.lblGrado.Text = "Grado:";
            // 
            // numGrado
            // 
            this.numGrado.Location = new System.Drawing.Point(84, 18);
            this.numGrado.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numGrado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGrado.Name = "numGrado";
            this.numGrado.Size = new System.Drawing.Size(34, 20);
            this.numGrado.TabIndex = 0;
            this.numGrado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbGrupo
            // 
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "j",
            "K"});
            this.cbGrupo.Location = new System.Drawing.Point(163, 17);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(37, 21);
            this.cbGrupo.TabIndex = 1;
            this.cbGrupo.Text = "A";
            // 
            // FormAgregarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(255, 148);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.numGrado);
            this.Controls.Add(this.txbEscuela);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblEscuela);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregarGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar nuevo grupo";
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEscuela;
        private System.Windows.Forms.TextBox txbEscuela;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.NumericUpDown numGrado;
        private System.Windows.Forms.ComboBox cbGrupo;
    }
}