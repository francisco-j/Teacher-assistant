namespace WindowsFormsApp3
{
    partial class FormListaG
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
            this.lblGrupos = new System.Windows.Forms.Label();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnAgregarGrupo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBoxAsistencia = new System.Windows.Forms.GroupBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAgregarDia = new System.Windows.Forms.Button();
            this.containerGrupos = new System.Windows.Forms.Panel();
            this.groupBoxAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrupos
            // 
            this.lblGrupos.AutoSize = true;
            this.lblGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblGrupos.Location = new System.Drawing.Point(81, 9);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(200, 61);
            this.lblGrupos.TabIndex = 2;
            this.lblGrupos.Text = "Grupos";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusqueda.Location = new System.Drawing.Point(634, 20);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.PasswordChar = 'a';
            this.txbBusqueda.Size = new System.Drawing.Size(211, 30);
            this.txbBusqueda.TabIndex = 13;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoMenu;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Marlett", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Location = new System.Drawing.Point(310, 20);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(40, 34);
            this.btnAjustes.TabIndex = 16;
            this.btnAjustes.UseVisualStyleBackColor = true;
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoAgregar;
            this.btnAgregarGrupo.FlatAppearance.BorderSize = 0;
            this.btnAgregarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarGrupo.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGrupo.Location = new System.Drawing.Point(12, 491);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(32, 32);
            this.btnAgregarGrupo.TabIndex = 16;
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoBack;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 20);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(32, 32);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::WindowsFormsApp3.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(851, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 30);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBoxAsistencia
            // 
            this.groupBoxAsistencia.Controls.Add(this.lblNombres);
            this.groupBoxAsistencia.Controls.Add(this.splitContainer1);
            this.groupBoxAsistencia.Controls.Add(this.btnAgregarDia);
            this.groupBoxAsistencia.Location = new System.Drawing.Point(236, 96);
            this.groupBoxAsistencia.Name = "groupBoxAsistencia";
            this.groupBoxAsistencia.Size = new System.Drawing.Size(662, 433);
            this.groupBoxAsistencia.TabIndex = 17;
            this.groupBoxAsistencia.TabStop = false;
            this.groupBoxAsistencia.Text = "Asistencias";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(240)))), ((int)(((byte)(215)))));
            this.lblNombres.Location = new System.Drawing.Point(15, 37);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(87, 25);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombre:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 71);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(581, 356);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 16;
            // 
            // btnAgregarDia
            // 
            this.btnAgregarDia.FlatAppearance.BorderSize = 0;
            this.btnAgregarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDia.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDia.Location = new System.Drawing.Point(593, 37);
            this.btnAgregarDia.Name = "btnAgregarDia";
            this.btnAgregarDia.Size = new System.Drawing.Size(63, 67);
            this.btnAgregarDia.TabIndex = 15;
            this.btnAgregarDia.Text = "+";
            this.btnAgregarDia.UseVisualStyleBackColor = true;
            // 
            // containerGrupos
            // 
            this.containerGrupos.AutoScroll = true;
            this.containerGrupos.Location = new System.Drawing.Point(12, 96);
            this.containerGrupos.Name = "containerGrupos";
            this.containerGrupos.Size = new System.Drawing.Size(218, 383);
            this.containerGrupos.TabIndex = 17;
            // 
            // FormListaG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(907, 539);
            this.Controls.Add(this.containerGrupos);
            this.Controls.Add(this.groupBoxAsistencia);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblGrupos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormListaG";
            this.Text = "Lista de Grupos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListaG_FormClosed);
            this.Load += new System.EventHandler(this.FormListaG_Load);
            this.groupBoxAsistencia.ResumeLayout(false);
            this.groupBoxAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAgregarGrupo;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.GroupBox groupBoxAsistencia;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAgregarDia;
        private System.Windows.Forms.Panel containerGrupos;
    }
}