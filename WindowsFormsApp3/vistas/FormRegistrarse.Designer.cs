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
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContrasena = new System.Windows.Forms.TextBox();
            this.txbConfirmacion = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(197, 22);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(130, 20);
            this.txbUsuario.TabIndex = 0;
            this.txbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsuario_KeyPress);
            // 
            // txbContrasena
            // 
            this.txbContrasena.Location = new System.Drawing.Point(197, 55);
            this.txbContrasena.Name = "txbContrasena";
            this.txbContrasena.PasswordChar = '•';
            this.txbContrasena.Size = new System.Drawing.Size(130, 20);
            this.txbContrasena.TabIndex = 1;
            this.txbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContrasena_KeyPress);
            // 
            // txbConfirmacion
            // 
            this.txbConfirmacion.Location = new System.Drawing.Point(197, 93);
            this.txbConfirmacion.Name = "txbConfirmacion";
            this.txbConfirmacion.PasswordChar = '•';
            this.txbConfirmacion.Size = new System.Drawing.Size(130, 20);
            this.txbConfirmacion.TabIndex = 2;
            this.txbConfirmacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbConfirmacion_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(35, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(147, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Nombre de usuario:";
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
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.White;
            this.lblContrasena.Location = new System.Drawing.Point(86, 55);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(96, 20);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacion.ForeColor = System.Drawing.Color.White;
            this.lblConfirmacion.Location = new System.Drawing.Point(16, 93);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(166, 20);
            this.lblConfirmacion.TabIndex = 6;
            this.lblConfirmacion.Text = "Confirmar contraseña:";
            // 
            // FormRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(354, 181);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txbConfirmacion);
            this.Controls.Add(this.txbContrasena);
            this.Controls.Add(this.txbUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrarse";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContrasena;
        private System.Windows.Forms.TextBox txbConfirmacion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblConfirmacion;
    }
}