namespace WindowsFormsApp3.vistas
{
    partial class FormAgregarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarAlumno));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbNombre = new MetroFramework.Controls.MetroTextBox();
            this.txbPaterno = new MetroFramework.Controls.MetroTextBox();
            this.txbMaterno = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGuardar.Location = new System.Drawing.Point(80, 141);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbNombre
            // 
            // 
            // 
            // 
            this.txbNombre.CustomButton.Image = null;
            this.txbNombre.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txbNombre.CustomButton.Name = "";
            this.txbNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNombre.CustomButton.TabIndex = 1;
            this.txbNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNombre.CustomButton.UseSelectable = true;
            this.txbNombre.CustomButton.Visible = false;
            this.txbNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbNombre.Lines = new string[0];
            this.txbNombre.Location = new System.Drawing.Point(26, 23);
            this.txbNombre.MaxLength = 20;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PasswordChar = '\0';
            this.txbNombre.PromptText = "Nombre";
            this.txbNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNombre.SelectedText = "";
            this.txbNombre.SelectionLength = 0;
            this.txbNombre.SelectionStart = 0;
            this.txbNombre.ShortcutsEnabled = true;
            this.txbNombre.Size = new System.Drawing.Size(217, 23);
            this.txbNombre.TabIndex = 0;
            this.txbNombre.UseSelectable = true;
            this.txbNombre.WaterMark = "Nombre";
            this.txbNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombre_KeyPress);
            // 
            // txbPaterno
            // 
            // 
            // 
            // 
            this.txbPaterno.CustomButton.Image = null;
            this.txbPaterno.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txbPaterno.CustomButton.Name = "";
            this.txbPaterno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbPaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPaterno.CustomButton.TabIndex = 1;
            this.txbPaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPaterno.CustomButton.UseSelectable = true;
            this.txbPaterno.CustomButton.Visible = false;
            this.txbPaterno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbPaterno.Lines = new string[0];
            this.txbPaterno.Location = new System.Drawing.Point(26, 57);
            this.txbPaterno.MaxLength = 15;
            this.txbPaterno.Name = "txbPaterno";
            this.txbPaterno.PasswordChar = '\0';
            this.txbPaterno.PromptText = "Apellido Paterno";
            this.txbPaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPaterno.SelectedText = "";
            this.txbPaterno.SelectionLength = 0;
            this.txbPaterno.SelectionStart = 0;
            this.txbPaterno.ShortcutsEnabled = true;
            this.txbPaterno.Size = new System.Drawing.Size(217, 23);
            this.txbPaterno.TabIndex = 1;
            this.txbPaterno.UseSelectable = true;
            this.txbPaterno.WaterMark = "Apellido Paterno";
            this.txbPaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPaterno_KeyPress);
            // 
            // txbMaterno
            // 
            // 
            // 
            // 
            this.txbMaterno.CustomButton.Image = null;
            this.txbMaterno.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txbMaterno.CustomButton.Name = "";
            this.txbMaterno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbMaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbMaterno.CustomButton.TabIndex = 1;
            this.txbMaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbMaterno.CustomButton.UseSelectable = true;
            this.txbMaterno.CustomButton.Visible = false;
            this.txbMaterno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbMaterno.Lines = new string[0];
            this.txbMaterno.Location = new System.Drawing.Point(26, 92);
            this.txbMaterno.MaxLength = 15;
            this.txbMaterno.Name = "txbMaterno";
            this.txbMaterno.PasswordChar = '\0';
            this.txbMaterno.PromptText = "Apellido Materno";
            this.txbMaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMaterno.SelectedText = "";
            this.txbMaterno.SelectionLength = 0;
            this.txbMaterno.SelectionStart = 0;
            this.txbMaterno.ShortcutsEnabled = true;
            this.txbMaterno.Size = new System.Drawing.Size(217, 23);
            this.txbMaterno.TabIndex = 2;
            this.txbMaterno.UseSelectable = true;
            this.txbMaterno.WaterMark = "Apellido Materno";
            this.txbMaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbMaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaterno_KeyPress);
            // 
            // FormAgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(256, 188);
            this.Controls.Add(this.txbMaterno);
            this.Controls.Add(this.txbPaterno);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Alumno";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroTextBox txbNombre;
        private MetroFramework.Controls.MetroTextBox txbPaterno;
        private MetroFramework.Controls.MetroTextBox txbMaterno;
    }
}