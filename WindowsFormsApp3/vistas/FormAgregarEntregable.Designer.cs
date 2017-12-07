namespace WindowsFormsApp3.vistas
{
    partial class FormAgregarEntregable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarEntregable));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbNombreEntregable = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(92, 92);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbNombreEntregable
            // 
            // 
            // 
            // 
            this.txbNombreEntregable.CustomButton.Image = null;
            this.txbNombreEntregable.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txbNombreEntregable.CustomButton.Name = "";
            this.txbNombreEntregable.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbNombreEntregable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNombreEntregable.CustomButton.TabIndex = 1;
            this.txbNombreEntregable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNombreEntregable.CustomButton.UseSelectable = true;
            this.txbNombreEntregable.CustomButton.Visible = false;
            this.txbNombreEntregable.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbNombreEntregable.Lines = new string[0];
            this.txbNombreEntregable.Location = new System.Drawing.Point(30, 44);
            this.txbNombreEntregable.MaxLength = 20;
            this.txbNombreEntregable.Name = "txbNombreEntregable";
            this.txbNombreEntregable.PasswordChar = '\0';
            this.txbNombreEntregable.PromptText = "Nombre";
            this.txbNombreEntregable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNombreEntregable.SelectedText = "";
            this.txbNombreEntregable.SelectionLength = 0;
            this.txbNombreEntregable.SelectionStart = 0;
            this.txbNombreEntregable.ShortcutsEnabled = true;
            this.txbNombreEntregable.Size = new System.Drawing.Size(217, 23);
            this.txbNombreEntregable.TabIndex = 0;
            this.txbNombreEntregable.UseSelectable = true;
            this.txbNombreEntregable.WaterMark = "Nombre";
            this.txbNombreEntregable.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNombreEntregable.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreEntregable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombreEntregable_KeyPress);
            // 
            // FormAgregarEntregable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(269, 148);
            this.Controls.Add(this.txbNombreEntregable);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarEntregable";
            this.Text = "Agregar ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroTextBox txbNombreEntregable;
    }
}