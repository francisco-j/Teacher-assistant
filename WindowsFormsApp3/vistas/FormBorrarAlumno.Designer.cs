namespace WindowsFormsApp3.vistas
{
    partial class FormBorrarAlumno
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
            this.btnCambio = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtMaterno = new MetroFramework.Controls.MetroTextBox();
            this.txtPaterno = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnCambio
            // 
            this.btnCambio.AutoSize = true;
            this.btnCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambio.Location = new System.Drawing.Point(91, 204);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(75, 28);
            this.btnCambio.TabIndex = 3;
            this.btnCambio.Text = "Eliminar";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Black;
            this.lblInfo.Location = new System.Drawing.Point(46, 27);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(196, 15);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Escribe el nombre del alumno que";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.Black;
            this.lblInfo2.Location = new System.Drawing.Point(86, 55);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(119, 15);
            this.lblInfo2.TabIndex = 6;
            this.lblInfo2.Text = "que deseas eliminar";
            // 
            // txtMaterno
            // 
            // 
            // 
            // 
            this.txtMaterno.CustomButton.Image = null;
            this.txtMaterno.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtMaterno.CustomButton.Name = "";
            this.txtMaterno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaterno.CustomButton.TabIndex = 1;
            this.txtMaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaterno.CustomButton.UseSelectable = true;
            this.txtMaterno.CustomButton.Visible = false;
            this.txtMaterno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMaterno.Lines = new string[0];
            this.txtMaterno.Location = new System.Drawing.Point(35, 155);
            this.txtMaterno.MaxLength = 15;
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.PasswordChar = '\0';
            this.txtMaterno.PromptText = "Apellido Materno";
            this.txtMaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaterno.SelectedText = "";
            this.txtMaterno.SelectionLength = 0;
            this.txtMaterno.SelectionStart = 0;
            this.txtMaterno.ShortcutsEnabled = true;
            this.txtMaterno.Size = new System.Drawing.Size(217, 23);
            this.txtMaterno.TabIndex = 2;
            this.txtMaterno.UseSelectable = true;
            this.txtMaterno.WaterMark = "Apellido Materno";
            this.txtMaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterno_KeyPress);
            // 
            // txtPaterno
            // 
            // 
            // 
            // 
            this.txtPaterno.CustomButton.Image = null;
            this.txtPaterno.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtPaterno.CustomButton.Name = "";
            this.txtPaterno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaterno.CustomButton.TabIndex = 1;
            this.txtPaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaterno.CustomButton.UseSelectable = true;
            this.txtPaterno.CustomButton.Visible = false;
            this.txtPaterno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPaterno.Lines = new string[0];
            this.txtPaterno.Location = new System.Drawing.Point(35, 120);
            this.txtPaterno.MaxLength = 15;
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.PasswordChar = '\0';
            this.txtPaterno.PromptText = "Apellido Paterno";
            this.txtPaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaterno.SelectedText = "";
            this.txtPaterno.SelectionLength = 0;
            this.txtPaterno.SelectionStart = 0;
            this.txtPaterno.ShortcutsEnabled = true;
            this.txtPaterno.Size = new System.Drawing.Size(217, 23);
            this.txtPaterno.TabIndex = 1;
            this.txtPaterno.UseSelectable = true;
            this.txtPaterno.WaterMark = "Apellido Paterno";
            this.txtPaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaterno_KeyPress);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(35, 86);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Nombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(217, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Nombre";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // FormBorrarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(289, 264);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.lblInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBorrarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblInfo2;
        private MetroFramework.Controls.MetroTextBox txtMaterno;
        private MetroFramework.Controls.MetroTextBox txtPaterno;
        private MetroFramework.Controls.MetroTextBox txtNombre;
    }
}