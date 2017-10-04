﻿namespace WindowsFormsApp3.vistas
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbPaterno = new System.Windows.Forms.TextBox();
            this.txbMaterno = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbNombre.Location = new System.Drawing.Point(118, 30);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 0;
            // 
            // txbPaterno
            // 
            this.txbPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbPaterno.Location = new System.Drawing.Point(118, 64);
            this.txbPaterno.Name = "txbPaterno";
            this.txbPaterno.Size = new System.Drawing.Size(100, 20);
            this.txbPaterno.TabIndex = 1;
            // 
            // txbMaterno
            // 
            this.txbMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbMaterno.Location = new System.Drawing.Point(118, 99);
            this.txbMaterno.Name = "txbMaterno";
            this.txbMaterno.Size = new System.Drawing.Size(100, 20);
            this.txbMaterno.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNombre.Location = new System.Drawing.Point(63, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblApellidoP.Location = new System.Drawing.Point(23, 67);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoP.TabIndex = 4;
            this.lblApellidoP.Text = "Apellido Paterno:";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblApellidoM.Location = new System.Drawing.Point(21, 102);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoM.TabIndex = 5;
            this.lblApellidoM.Text = "Apellido Materno:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGuardar.Location = new System.Drawing.Point(80, 141);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormAgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(256, 188);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblApellidoM);
            this.Controls.Add(this.lblApellidoP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbMaterno);
            this.Controls.Add(this.txbPaterno);
            this.Controls.Add(this.txbNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAgregarAlumno";
            this.Text = "Agregar Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbPaterno;
        private System.Windows.Forms.TextBox txbMaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.Button btnGuardar;
    }
}