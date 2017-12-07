namespace WindowsFormsApp3
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.picVulcanoLogo = new System.Windows.Forms.PictureBox();
            this.picTaLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.LinkLabel();
            this.txbUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txbContrasena = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVulcanoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSize = true;
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciar.Location = new System.Drawing.Point(149, 336);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(115, 29);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // picVulcanoLogo
            // 
            this.picVulcanoLogo.Image = global::WindowsFormsApp3.Properties.Resources.icoLogoSolo;
            this.picVulcanoLogo.Location = new System.Drawing.Point(1, 527);
            this.picVulcanoLogo.Name = "picVulcanoLogo";
            this.picVulcanoLogo.Size = new System.Drawing.Size(114, 55);
            this.picVulcanoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVulcanoLogo.TabIndex = 4;
            this.picVulcanoLogo.TabStop = false;
            // 
            // picTaLogo
            // 
            this.picTaLogo.BackColor = System.Drawing.Color.Transparent;
            this.picTaLogo.Image = ((System.Drawing.Image)(resources.GetObject("picTaLogo.Image")));
            this.picTaLogo.Location = new System.Drawing.Point(132, 62);
            this.picTaLogo.Name = "picTaLogo";
            this.picTaLogo.Size = new System.Drawing.Size(166, 155);
            this.picTaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTaLogo.TabIndex = 1;
            this.picTaLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.icoLogoTexto;
            this.pictureBox1.Location = new System.Drawing.Point(113, 550);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblPregunta.Location = new System.Drawing.Point(110, 387);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(113, 15);
            this.lblPregunta.TabIndex = 9;
            this.lblPregunta.Text = "¿No tienes cuenta?";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnRegistrar.Location = new System.Drawing.Point(225, 387);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(73, 15);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.TabStop = true;
            this.btnRegistrar.Text = "Regístrate";
            this.btnRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRegistrar_LinkClicked);
            // 
            // txbUsuario
            // 
            this.txbUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txbUsuario.CustomButton.Image = null;
            this.txbUsuario.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txbUsuario.CustomButton.Name = "";
            this.txbUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbUsuario.CustomButton.TabIndex = 1;
            this.txbUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbUsuario.CustomButton.UseSelectable = true;
            this.txbUsuario.CustomButton.Visible = false;
            this.txbUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbUsuario.Lines = new string[0];
            this.txbUsuario.Location = new System.Drawing.Point(113, 248);
            this.txbUsuario.MaxLength = 20;
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.PromptText = "Usuario";
            this.txbUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.SelectionLength = 0;
            this.txbUsuario.SelectionStart = 0;
            this.txbUsuario.ShortcutsEnabled = true;
            this.txbUsuario.Size = new System.Drawing.Size(201, 23);
            this.txbUsuario.TabIndex = 1;
            this.txbUsuario.UseSelectable = true;
            this.txbUsuario.WaterMark = "Usuario";
            this.txbUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsuario_KeyPress);
            // 
            // txbContrasena
            // 
            // 
            // 
            // 
            this.txbContrasena.CustomButton.Image = null;
            this.txbContrasena.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txbContrasena.CustomButton.Name = "";
            this.txbContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbContrasena.CustomButton.TabIndex = 1;
            this.txbContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbContrasena.CustomButton.UseSelectable = true;
            this.txbContrasena.CustomButton.Visible = false;
            this.txbContrasena.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbContrasena.Lines = new string[0];
            this.txbContrasena.Location = new System.Drawing.Point(113, 290);
            this.txbContrasena.MaxLength = 20;
            this.txbContrasena.Name = "txbContrasena";
            this.txbContrasena.PasswordChar = '•';
            this.txbContrasena.PromptText = "Contraseña";
            this.txbContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbContrasena.SelectedText = "";
            this.txbContrasena.SelectionLength = 0;
            this.txbContrasena.SelectionStart = 0;
            this.txbContrasena.ShortcutsEnabled = true;
            this.txbContrasena.Size = new System.Drawing.Size(201, 23);
            this.txbContrasena.TabIndex = 2;
            this.txbContrasena.UseSelectable = true;
            this.txbContrasena.WaterMark = "Contraseña";
            this.txbContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContrasena_KeyPress);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(417, 585);
            this.Controls.Add(this.txbContrasena);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picVulcanoLogo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.picTaLogo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInicio_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picVulcanoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picTaLogo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox picVulcanoLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.LinkLabel btnRegistrar;
        private MetroFramework.Controls.MetroTextBox txbUsuario;
        private MetroFramework.Controls.MetroTextBox txbContrasena;
    }
}

