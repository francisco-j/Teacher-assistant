namespace WindowsFormsApp3
{
    partial class FormRegistrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarse));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txbConfirmacion = new MetroFramework.Controls.MetroTextBox();
            this.txbContrasena = new MetroFramework.Controls.MetroTextBox();
            this.txbUsuario = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.btnRegistrar.Location = new System.Drawing.Point(133, 139);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 28);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txbConfirmacion
            // 
            // 
            // 
            // 
            this.txbConfirmacion.CustomButton.Image = null;
            this.txbConfirmacion.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txbConfirmacion.CustomButton.Name = "";
            this.txbConfirmacion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbConfirmacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbConfirmacion.CustomButton.TabIndex = 1;
            this.txbConfirmacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbConfirmacion.CustomButton.UseSelectable = true;
            this.txbConfirmacion.CustomButton.Visible = false;
            this.txbConfirmacion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbConfirmacion.Lines = new string[0];
            this.txbConfirmacion.Location = new System.Drawing.Point(41, 95);
            this.txbConfirmacion.MaxLength = 20;
            this.txbConfirmacion.Name = "txbConfirmacion";
            this.txbConfirmacion.PasswordChar = '•';
            this.txbConfirmacion.PromptText = "Confirmación contraseña";
            this.txbConfirmacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbConfirmacion.SelectedText = "";
            this.txbConfirmacion.SelectionLength = 0;
            this.txbConfirmacion.SelectionStart = 0;
            this.txbConfirmacion.ShortcutsEnabled = true;
            this.txbConfirmacion.Size = new System.Drawing.Size(276, 23);
            this.txbConfirmacion.TabIndex = 2;
            this.txbConfirmacion.UseSelectable = true;
            this.txbConfirmacion.WaterMark = "Confirmación contraseña";
            this.txbConfirmacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbConfirmacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbConfirmacion_KeyPress);
            // 
            // txbContrasena
            // 
            // 
            // 
            // 
            this.txbContrasena.CustomButton.Image = null;
            this.txbContrasena.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txbContrasena.CustomButton.Name = "";
            this.txbContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbContrasena.CustomButton.TabIndex = 1;
            this.txbContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbContrasena.CustomButton.UseSelectable = true;
            this.txbContrasena.CustomButton.Visible = false;
            this.txbContrasena.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbContrasena.Lines = new string[0];
            this.txbContrasena.Location = new System.Drawing.Point(41, 60);
            this.txbContrasena.MaxLength = 20;
            this.txbContrasena.Name = "txbContrasena";
            this.txbContrasena.PasswordChar = '•';
            this.txbContrasena.PromptText = "Contraseña";
            this.txbContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbContrasena.SelectedText = "";
            this.txbContrasena.SelectionLength = 0;
            this.txbContrasena.SelectionStart = 0;
            this.txbContrasena.ShortcutsEnabled = true;
            this.txbContrasena.Size = new System.Drawing.Size(276, 23);
            this.txbContrasena.TabIndex = 1;
            this.txbContrasena.UseSelectable = true;
            this.txbContrasena.WaterMark = "Contraseña";
            this.txbContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContrasena_KeyPress);
            // 
            // txbUsuario
            // 
            // 
            // 
            // 
            this.txbUsuario.CustomButton.Image = null;
            this.txbUsuario.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txbUsuario.CustomButton.Name = "";
            this.txbUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbUsuario.CustomButton.TabIndex = 1;
            this.txbUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbUsuario.CustomButton.UseSelectable = true;
            this.txbUsuario.CustomButton.Visible = false;
            this.txbUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbUsuario.Lines = new string[0];
            this.txbUsuario.Location = new System.Drawing.Point(41, 26);
            this.txbUsuario.MaxLength = 20;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.PromptText = "Usuario";
            this.txbUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.SelectionLength = 0;
            this.txbUsuario.SelectionStart = 0;
            this.txbUsuario.ShortcutsEnabled = true;
            this.txbUsuario.Size = new System.Drawing.Size(276, 23);
            this.txbUsuario.TabIndex = 0;
            this.txbUsuario.UseSelectable = true;
            this.txbUsuario.WaterMark = "Usuario";
            this.txbUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsuario_KeyPress);
            // 
            // FormRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(354, 181);
            this.Controls.Add(this.txbConfirmacion);
            this.Controls.Add(this.txbContrasena);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.btnRegistrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrar;
        private MetroFramework.Controls.MetroTextBox txbConfirmacion;
        private MetroFramework.Controls.MetroTextBox txbContrasena;
        private MetroFramework.Controls.MetroTextBox txbUsuario;
    }
}