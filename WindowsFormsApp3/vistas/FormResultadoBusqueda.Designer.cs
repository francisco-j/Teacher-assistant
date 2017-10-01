namespace WindowsFormsApp3.vistas
{
    partial class FormResultadoBusqueda
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultadoBusqueda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstBxGrados = new System.Windows.Forms.ListBox();
            this.lstBxNombres = new System.Windows.Forms.ListBox();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lstBxGrados);
            this.panel1.Controls.Add(this.lstBxNombres);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 359);
            this.panel1.TabIndex = 0;
            // 
            // lstBxGrados
            // 
            this.lstBxGrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstBxGrados.FormattingEnabled = true;
            this.lstBxGrados.ItemHeight = 20;
            this.lstBxGrados.Items.AddRange(new object[] {
            "grado alumno"});
            this.lstBxGrados.Location = new System.Drawing.Point(226, 3);
            this.lstBxGrados.Name = "lstBxGrados";
            this.lstBxGrados.Size = new System.Drawing.Size(57, 24);
            this.lstBxGrados.TabIndex = 1;
            // 
            // lstBxNombres
            // 
            this.lstBxNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstBxNombres.FormattingEnabled = true;
            this.lstBxNombres.ItemHeight = 20;
            this.lstBxNombres.Items.AddRange(new object[] {
            "nombre alumno"});
            this.lstBxNombres.Location = new System.Drawing.Point(0, 3);
            this.lstBxNombres.Name = "lstBxNombres";
            this.lstBxNombres.Size = new System.Drawing.Size(220, 24);
            this.lstBxNombres.TabIndex = 1;
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(245, 30);
            this.txbBusqueda.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::WindowsFormsApp3.Properties.Resources.icoBuscar;
            this.btnBuscar.Location = new System.Drawing.Point(263, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSinResultados.ForeColor = System.Drawing.Color.Tomato;
            this.lblSinResultados.Location = new System.Drawing.Point(12, 54);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(283, 40);
            this.lblSinResultados.TabIndex = 2;
            this.lblSinResultados.Text = "La busqueda no arrojo resultados.\r\nIntenta con algo mas simple.";
            this.lblSinResultados.Visible = false;
            // 
            // FormResultadoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(307, 438);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResultadoBusqueda";
            this.Text = "Resultado de Busqueda";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstBxNombres;
        private System.Windows.Forms.ListBox lstBxGrados;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSinResultados;
    }
}