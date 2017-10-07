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
            this.dtPickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(77, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Location = new System.Drawing.Point(39, 63);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(48, 13);
            this.lblEscuela.TabIndex = 1;
            this.lblEscuela.Text = "Escuela:";
            // 
            // txbEscuela
            // 
            this.txbEscuela.Location = new System.Drawing.Point(93, 63);
            this.txbEscuela.Name = "txbEscuela";
            this.txbEscuela.Size = new System.Drawing.Size(100, 20);
            this.txbEscuela.TabIndex = 2;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(117, 22);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 9;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(37, 22);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(39, 13);
            this.lblGrado.TabIndex = 0;
            this.lblGrado.Text = "Grado:";
            // 
            // numGrado
            // 
            this.numGrado.Location = new System.Drawing.Point(77, 22);
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
            this.cbGrupo.Location = new System.Drawing.Point(156, 21);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(37, 21);
            this.cbGrupo.TabIndex = 1;
            this.cbGrupo.Text = "A";
            // 
            // dtPickerInicio
            // 
            this.dtPickerInicio.Location = new System.Drawing.Point(12, 123);
            this.dtPickerInicio.Name = "dtPickerInicio";
            this.dtPickerInicio.Size = new System.Drawing.Size(200, 20);
            this.dtPickerInicio.TabIndex = 3;
            // 
            // dtPickerFin
            // 
            this.dtPickerFin.Location = new System.Drawing.Point(12, 161);
            this.dtPickerFin.Name = "dtPickerFin";
            this.dtPickerFin.Size = new System.Drawing.Size(200, 20);
            this.dtPickerFin.TabIndex = 4;
            this.dtPickerFin.Value = new System.DateTime(2017, 10, 6, 23, 27, 5, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio del curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fin del curso:";
            // 
            // FormAgregarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(239, 266);
            this.Controls.Add(this.dtPickerFin);
            this.Controls.Add(this.dtPickerInicio);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.numGrado);
            this.Controls.Add(this.txbEscuela);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEscuela);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregarGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar nuevo grupo";
            this.Load += new System.EventHandler(this.FormAgregarGrupo_Load);
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
        private System.Windows.Forms.DateTimePicker dtPickerInicio;
        private System.Windows.Forms.DateTimePicker dtPickerFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}