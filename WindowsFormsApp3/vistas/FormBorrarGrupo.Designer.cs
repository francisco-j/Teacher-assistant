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
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txbEscuela = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Location = new System.Drawing.Point(25, 31);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(228, 13);
            this.lblIndicaciones.TabIndex = 4;
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
            "H"});
            this.cbGrupo.Location = new System.Drawing.Point(164, 65);
            this.cbGrupo.MaxLength = 1;
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(37, 21);
            this.cbGrupo.TabIndex = 1;
            this.cbGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGrupo_KeyPress);
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
            this.numGrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numGrado_KeyPress);
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(45, 66);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(39, 13);
            this.lblGrado.TabIndex = 5;
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
            // txbEscuela
            // 
            // 
            // 
            // 
            this.txbEscuela.CustomButton.Image = null;
            this.txbEscuela.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txbEscuela.CustomButton.Name = "";
            this.txbEscuela.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbEscuela.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbEscuela.CustomButton.TabIndex = 1;
            this.txbEscuela.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbEscuela.CustomButton.UseSelectable = true;
            this.txbEscuela.CustomButton.Visible = false;
            this.txbEscuela.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbEscuela.Lines = new string[0];
            this.txbEscuela.Location = new System.Drawing.Point(28, 108);
            this.txbEscuela.MaxLength = 35;
            this.txbEscuela.Name = "txbEscuela";
            this.txbEscuela.PasswordChar = '\0';
            this.txbEscuela.PromptText = "Nombre";
            this.txbEscuela.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbEscuela.SelectedText = "";
            this.txbEscuela.SelectionLength = 0;
            this.txbEscuela.SelectionStart = 0;
            this.txbEscuela.ShortcutsEnabled = true;
            this.txbEscuela.Size = new System.Drawing.Size(217, 23);
            this.txbEscuela.TabIndex = 2;
            this.txbEscuela.UseSelectable = true;
            this.txbEscuela.WaterMark = "Nombre";
            this.txbEscuela.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbEscuela.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEscuela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEscuela_KeyPress);
            // 
            // FormBorrarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(264, 181);
            this.Controls.Add(this.txbEscuela);
            this.Controls.Add(this.cbGrupo);
            this.Controls.Add(this.numGrado);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblIndicaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBorrarGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar ";
            ((System.ComponentModel.ISupportInitialize)(this.numGrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.NumericUpDown numGrado;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblGrupo;
        private MetroFramework.Controls.MetroTextBox txbEscuela;
    }
}