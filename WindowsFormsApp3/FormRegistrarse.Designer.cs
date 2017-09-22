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
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.txbConfirmacion = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblConfirmación = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(215, 42);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(131, 20);
            this.txbUsuario.TabIndex = 0;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(215, 75);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(131, 20);
            this.txbContraseña.TabIndex = 1;
            // 
            // txbConfirmacion
            // 
            this.txbConfirmacion.Location = new System.Drawing.Point(215, 113);
            this.txbConfirmacion.Name = "txbConfirmacion";
            this.txbConfirmacion.Size = new System.Drawing.Size(131, 20);
            this.txbConfirmacion.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(53, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(147, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Nombre de usuario:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(151, 159);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(104, 75);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 20);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblConfirmación
            // 
            this.lblConfirmación.AutoSize = true;
            this.lblConfirmación.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmación.Location = new System.Drawing.Point(10, 115);
            this.lblConfirmación.Name = "lblConfirmación";
            this.lblConfirmación.Size = new System.Drawing.Size(190, 20);
            this.lblConfirmación.TabIndex = 6;
            this.lblConfirmación.Text = "Confirmación contraseña:";
            // 
            // FormRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 227);
            this.Controls.Add(this.lblConfirmación);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txbConfirmacion);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbUsuario);
            this.Name = "FormRegistrarse";
            this.Text = "FormRegistrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.TextBox txbConfirmacion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblConfirmación;
    }
}