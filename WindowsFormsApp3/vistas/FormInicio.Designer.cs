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
            this.txbContrasena = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.picVulcanoLogo = new System.Windows.Forms.PictureBox();
            this.picTaLogo = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVulcanoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbContrasena
            // 
            this.txbContrasena.BackColor = System.Drawing.Color.White;
            this.txbContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(109)))), ((int)(((byte)(94)))));
            this.txbContrasena.Location = new System.Drawing.Point(113, 304);
            this.txbContrasena.Name = "txbContrasena";
            this.txbContrasena.PasswordChar = '•';
            this.txbContrasena.Size = new System.Drawing.Size(200, 20);
            this.txbContrasena.TabIndex = 1;
            this.txbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContrasena_KeyPress);
            // 
            // btnIniciar
            // 
            this.btnIniciar.AutoSize = true;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(149, 330);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(115, 27);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = true;
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
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(320, 12);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(97, 29);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(39, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(11, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(113, 279);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(200, 20);
            this.txbUsuario.TabIndex = 0;
            this.txbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsuario_KeyPress);
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
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(417, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.picVulcanoLogo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.picTaLogo);
            this.Controls.Add(this.txbContrasena);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInicio_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picVulcanoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbContrasena;
        private System.Windows.Forms.PictureBox picTaLogo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox picVulcanoLogo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

