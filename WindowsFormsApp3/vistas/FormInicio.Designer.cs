﻿namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picVulcanoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbContrasena
            // 
            this.txbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(109)))), ((int)(((byte)(94)))));
            this.txbContrasena.Location = new System.Drawing.Point(113, 304);
            this.txbContrasena.MaxLength = 20;
            this.txbContrasena.Name = "txbContrasena";
            this.txbContrasena.PasswordChar = '•';
            this.txbContrasena.Size = new System.Drawing.Size(200, 21);
            this.txbContrasena.TabIndex = 1;
            this.txbContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContrasena_KeyPress);
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
            this.btnIniciar.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(47, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(14, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(113, 279);
            this.txbUsuario.MaxLength = 20;
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
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.TabStop = true;
            this.btnRegistrar.Text = "Regístrate";
            this.btnRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRegistrar_LinkClicked);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(417, 585);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picVulcanoLogo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.picTaLogo);
            this.Controls.Add(this.txbContrasena);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.LinkLabel btnRegistrar;
    }
}

