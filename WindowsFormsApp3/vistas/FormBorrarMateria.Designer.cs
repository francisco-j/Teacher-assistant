namespace WindowsFormsApp3.vistas
{
    partial class FormBorrarMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrarMateria));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNombreMateria = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(93, 113);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Para borrar la materia confirme el nombre ésta";
            // 
            // txbNombreMateria
            // 
            // 
            // 
            // 
            this.txbNombreMateria.CustomButton.Image = null;
            this.txbNombreMateria.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txbNombreMateria.CustomButton.Name = "";
            this.txbNombreMateria.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbNombreMateria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNombreMateria.CustomButton.TabIndex = 1;
            this.txbNombreMateria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNombreMateria.CustomButton.UseSelectable = true;
            this.txbNombreMateria.CustomButton.Visible = false;
            this.txbNombreMateria.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbNombreMateria.Lines = new string[0];
            this.txbNombreMateria.Location = new System.Drawing.Point(15, 37);
            this.txbNombreMateria.MaxLength = 20;
            this.txbNombreMateria.Name = "txbNombreMateria";
            this.txbNombreMateria.PasswordChar = '\0';
            this.txbNombreMateria.PromptText = "Nombre de la materia";
            this.txbNombreMateria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNombreMateria.SelectedText = "";
            this.txbNombreMateria.SelectionLength = 0;
            this.txbNombreMateria.SelectionStart = 0;
            this.txbNombreMateria.ShortcutsEnabled = true;
            this.txbNombreMateria.Size = new System.Drawing.Size(217, 23);
            this.txbNombreMateria.TabIndex = 0;
            this.txbNombreMateria.UseSelectable = true;
            this.txbNombreMateria.WaterMark = "Nombre de la materia";
            this.txbNombreMateria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNombreMateria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombreMateria_KeyPress);
            // 
            // FormBorrarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(255, 148);
            this.Controls.Add(this.txbNombreMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBorrarMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Borrar materia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txbNombreMateria;
    }
}