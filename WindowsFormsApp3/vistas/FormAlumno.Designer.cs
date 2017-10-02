namespace WindowsFormsApp3.vistas
{
    partial class FormAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumno));
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(33, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "nombre";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(33, 90);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(20, 13);
            this.lblAP.TabIndex = 0;
            this.lblAP.Text = "aP";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Location = new System.Drawing.Point(33, 118);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(22, 13);
            this.lblAM.TabIndex = 0;
            this.lblAM.Text = "aM";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(33, 159);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(34, 13);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "grupo";
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(521, 451);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblAM);
            this.Controls.Add(this.lblAP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlumno";
            this.Text = "Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label lblGrupo;
    }
}