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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.txbBusqueda = new MetroFramework.Controls.MetroTextBox();
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
            this.lstBxNombres.TabIndex = 0;
            this.lstBxNombres.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBxNombres_MouseDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoBuscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(263, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSinResultados.ForeColor = System.Drawing.Color.White;
            this.lblSinResultados.Location = new System.Drawing.Point(12, 54);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(283, 40);
            this.lblSinResultados.TabIndex = 2;
            this.lblSinResultados.Text = "La búsqueda no arrojó resultados.\r\nIntenta con algo más simple.";
            this.lblSinResultados.Visible = false;
            // 
            // txbBusqueda
            // 
            // 
            // 
            // 
            this.txbBusqueda.CustomButton.Image = null;
            this.txbBusqueda.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txbBusqueda.CustomButton.Name = "";
            this.txbBusqueda.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbBusqueda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbBusqueda.CustomButton.TabIndex = 1;
            this.txbBusqueda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbBusqueda.CustomButton.UseSelectable = true;
            this.txbBusqueda.CustomButton.Visible = false;
            this.txbBusqueda.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbBusqueda.Lines = new string[0];
            this.txbBusqueda.Location = new System.Drawing.Point(12, 14);
            this.txbBusqueda.MaxLength = 50;
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.PasswordChar = '\0';
            this.txbBusqueda.PromptText = "Nombre del alumno";
            this.txbBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBusqueda.SelectedText = "";
            this.txbBusqueda.SelectionLength = 0;
            this.txbBusqueda.SelectionStart = 0;
            this.txbBusqueda.ShortcutsEnabled = true;
            this.txbBusqueda.Size = new System.Drawing.Size(254, 23);
            this.txbBusqueda.TabIndex = 0;
            this.txbBusqueda.UseSelectable = true;
            this.txbBusqueda.WaterMark = "Nombre del alumno";
            this.txbBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbBusqueda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBusqueda_KeyPress);
            // 
            // FormResultadoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(307, 438);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResultadoBusqueda";
            this.Text = "Resultado de Búsqueda";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstBxNombres;
        private System.Windows.Forms.ListBox lstBxGrados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSinResultados;
        private MetroFramework.Controls.MetroTextBox txbBusqueda;
    }
}