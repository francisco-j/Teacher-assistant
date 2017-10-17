namespace WindowsFormsApp3.vistas
{
    partial class FormBorrarGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrarGrupo));
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.numGrado = new System.Windows.Forms.NumericUpDown();
            this.txbEscuela = new System.Windows.Forms.TextBox();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblEscuela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Location = new System.Drawing.Point(25, 31);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(228, 13);
            this.lblIndicaciones.TabIndex = 0;
            this.lblIndicaciones.Text = "Confirma la informacion del grupo para borrarlo.";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(101, 148);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
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
            this.cbGrupo.Location = new System.Drawing.Point(164, 65);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(37, 21);
            this.cbGrupo.TabIndex = 1;
            // 
            // numGrado
            // 
            this.numGrado.Location = new System.Drawing.Point(85, 66);
            this.numGrado.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numGrado.Name = "numGrado";
            this.numGrado.Size = new System.Drawing.Size(34, 20);
            this.numGrado.TabIndex = 0;
            // 
            // txbEscuela
            // 
            this.txbEscuela.Location = new System.Drawing.Point(101, 107);
            this.txbEscuela.Name = "txbEscuela";
            this.txbEscuela.Size = new System.Drawing.Size(100, 20);
            this.txbEscuela.TabIndex = 2;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(45, 66);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(39, 13);
            this.lblGrado.TabIndex = 11;
            this.lblGrado.Text = "Grado:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(125, 66);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 15;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Location = new System.Drawing.Point(47, 107);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(48, 13);
            this.lblEscuela.TabIndex = 13;
            this.lblEscuela.Text = "Escuela:";
            // 
            // FormBorrarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(264, 181);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.numGrado);
            this.Controls.Add(this.txbEscuela);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblEscuela);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblIndicaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBorrarGrupo";
            this.Text = "Borrar ";
            this.Load += new System.EventHandler(this.FormBorrarGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.NumericUpDown numGrado;
        private System.Windows.Forms.TextBox txbEscuela;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblEscuela;
    }
}