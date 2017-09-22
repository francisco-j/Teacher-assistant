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
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.picNombre = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUserImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txbContraseña
            // 
            this.txbContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(109)))), ((int)(((byte)(94)))));
            this.txbContraseña.Location = new System.Drawing.Point(79, 304);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '¤';
            this.txbContraseña.Size = new System.Drawing.Size(204, 20);
            this.txbContraseña.TabIndex = 0;
            this.txbContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(109, 270);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(155, 31);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(125, 330);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(115, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // picNombre
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.icoLogoTexto;
            this.pictureBox1.Location = new System.Drawing.Point(121, 552);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::WindowsFormsApp3.Properties.Resources.icoLogoSolo;
            this.picLogo.Location = new System.Drawing.Point(1, 527);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(114, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // picUserImage
            // 
            this.picUserImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(216)))), ((int)(((byte)(213)))));
            this.picUserImage.Image = ((System.Drawing.Image)(resources.GetObject("picUserImage.Image")));
            this.picUserImage.Location = new System.Drawing.Point(111, 57);
            this.picUserImage.Name = "picUserImage";
            this.picUserImage.Size = new System.Drawing.Size(153, 151);
            this.picUserImage.TabIndex = 1;
            this.picUserImage.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(375, 524);
            this.Controls.Add(this.picNombre);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.picUserImage);
            this.Controls.Add(this.txbContraseña);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Name = "FormInicio";
            this.Text = "Inicio de Sesion";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.picNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.PictureBox picUserImage;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picNombre;
    }
}

