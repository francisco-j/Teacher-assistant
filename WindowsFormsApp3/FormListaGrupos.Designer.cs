namespace WindowsFormsApp3
{
    partial class FormListaGrupos
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
            this.containerGrupos = new System.Windows.Forms.Panel();
            this.lblGrupos = new System.Windows.Forms.Label();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // containerGrupos
            // 
            this.containerGrupos.AutoScroll = true;
            this.containerGrupos.Location = new System.Drawing.Point(52, 131);
            this.containerGrupos.Name = "containerGrupos";
            this.containerGrupos.Size = new System.Drawing.Size(333, 375);
            this.containerGrupos.TabIndex = 18;
            // 
            // lblGrupos
            // 
            this.lblGrupos.AutoSize = true;
            this.lblGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblGrupos.Location = new System.Drawing.Point(41, 36);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(200, 61);
            this.lblGrupos.TabIndex = 19;
            this.lblGrupos.Text = "Grupos";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusqueda.Location = new System.Drawing.Point(291, 62);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.PasswordChar = 'a';
            this.txbBusqueda.Size = new System.Drawing.Size(211, 30);
            this.txbBusqueda.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::WindowsFormsApp3.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(508, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 30);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDia
            // 
            this.btnAgregarDia.FlatAppearance.BorderSize = 0;
            this.btnAgregarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDia.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDia.Location = new System.Drawing.Point(439, 439);
            this.btnAgregarDia.Name = "btnAgregarDia";
            this.btnAgregarDia.Size = new System.Drawing.Size(63, 67);
            this.btnAgregarDia.TabIndex = 22;
            this.btnAgregarDia.Text = "+";
            this.btnAgregarDia.UseVisualStyleBackColor = true;
            // 
            // FormListaGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 547);
            this.Controls.Add(this.btnAgregarDia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.lblGrupos);
            this.Controls.Add(this.containerGrupos);
            this.Name = "FormListaGrupos";
            this.Text = "Lista de grupos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel containerGrupos;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarDia;
    }
}