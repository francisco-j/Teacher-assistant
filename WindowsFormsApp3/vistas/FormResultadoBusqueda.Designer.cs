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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstBxGrados = new System.Windows.Forms.ListBox();
            this.lstBxNombres = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lstBxGrados);
            this.panel1.Controls.Add(this.lstBxNombres);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 354);
            this.panel1.TabIndex = 0;
            // 
            // lstBxGrados
            // 
            this.lstBxGrados.FormattingEnabled = true;
            this.lstBxGrados.Items.AddRange(new object[] {
            "grado alumno"});
            this.lstBxGrados.Location = new System.Drawing.Point(226, 0);
            this.lstBxGrados.Name = "lstBxGrados";
            this.lstBxGrados.Size = new System.Drawing.Size(67, 264);
            this.lstBxGrados.TabIndex = 1;
            // 
            // lstBxNombres
            // 
            this.lstBxNombres.FormattingEnabled = true;
            this.lstBxNombres.Items.AddRange(new object[] {
            "nombre alumno"});
            this.lstBxNombres.Location = new System.Drawing.Point(3, 3);
            this.lstBxNombres.Name = "lstBxNombres";
            this.lstBxNombres.Size = new System.Drawing.Size(217, 264);
            this.lstBxNombres.TabIndex = 1;
            // 
            // FormResultadoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 438);
            this.Controls.Add(this.panel1);
            this.Name = "FormResultadoBusqueda";
            this.Text = "FormResultadoBusqueda";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstBxNombres;
        private System.Windows.Forms.ListBox lstBxGrados;
    }
}