namespace WindowsFormsApp3
{
    partial class FormListaMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaMaterias));
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.contenedorMaterias = new System.Windows.Forms.FlowLayoutPanel();
            this.grbAsistencia = new System.Windows.Forms.GroupBox();
            this.flowLPAsistencias = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAlumnos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAsistencias = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbAsistencia.SuspendLayout();
            this.flowLPAsistencias.SuspendLayout();
            this.panelAsistencias.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblGrupo.Location = new System.Drawing.Point(71, 9);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(187, 61);
            this.lblGrupo.TabIndex = 2;
            this.lblGrupo.Text = "Grupo ";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusqueda.Location = new System.Drawing.Point(697, 24);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(211, 30);
            this.txbBusqueda.TabIndex = 13;
            this.txbBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBusqueda_KeyPress);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoMenu;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Marlett", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Location = new System.Drawing.Point(407, 20);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(40, 34);
            this.btnAjustes.TabIndex = 16;
            this.btnAjustes.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoAgregar;
            this.btnAgregarMateria.FlatAppearance.BorderSize = 0;
            this.btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMateria.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(169, 368);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(32, 32);
            this.btnAgregarMateria.TabIndex = 16;
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
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
            this.btnBuscar.Image = global::WindowsFormsApp3.Properties.Resources.icoBuscar;
            this.btnBuscar.Location = new System.Drawing.Point(914, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // contenedorMaterias
            // 
            this.contenedorMaterias.AutoScroll = true;
            this.contenedorMaterias.Location = new System.Drawing.Point(6, 30);
            this.contenedorMaterias.Name = "contenedorMaterias";
            this.contenedorMaterias.Size = new System.Drawing.Size(195, 332);
            this.contenedorMaterias.TabIndex = 18;
            // 
            // grbAsistencia
            // 
            this.grbAsistencia.Controls.Add(this.flowLPAsistencias);
            this.grbAsistencia.Controls.Add(this.btnAgregarAlumno);
            this.grbAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.grbAsistencia.Location = new System.Drawing.Point(225, 80);
            this.grbAsistencia.Name = "grbAsistencia";
            this.grbAsistencia.Size = new System.Drawing.Size(721, 406);
            this.grbAsistencia.TabIndex = 0;
            this.grbAsistencia.TabStop = false;
            this.grbAsistencia.Text = "Asistencia";
            // 
            // flowLPAsistencias
            // 
            this.flowLPAsistencias.AutoSize = true;
            this.flowLPAsistencias.Controls.Add(this.panelAlumnos);
            this.flowLPAsistencias.Controls.Add(this.panelAsistencias);
            this.flowLPAsistencias.Location = new System.Drawing.Point(6, 30);
            this.flowLPAsistencias.Name = "flowLPAsistencias";
            this.flowLPAsistencias.Size = new System.Drawing.Size(170, 100);
            this.flowLPAsistencias.TabIndex = 2;
            // 
            // panelAlumnos
            // 
            this.panelAlumnos.AutoSize = true;
            this.panelAlumnos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelAlumnos.Location = new System.Drawing.Point(3, 3);
            this.panelAlumnos.Name = "panelAlumnos";
            this.panelAlumnos.Size = new System.Drawing.Size(0, 0);
            this.panelAlumnos.TabIndex = 0;
            this.panelAlumnos.WrapContents = false;
            // 
            // panelAsistencias
            // 
            this.panelAsistencias.AutoSize = true;
            this.panelAsistencias.Controls.Add(this.checkBox1);
            this.panelAsistencias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelAsistencias.Location = new System.Drawing.Point(9, 3);
            this.panelAsistencias.Name = "panelAsistencias";
            this.panelAsistencias.Size = new System.Drawing.Size(21, 20);
            this.panelAsistencias.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoAgregar;
            this.btnAgregarAlumno.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(689, 368);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(32, 32);
            this.btnAgregarAlumno.TabIndex = 19;
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contenedorMaterias);
            this.groupBox1.Controls.Add(this.btnAgregarMateria);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 406);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // FormListaMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(954, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbAsistencia);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblGrupo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListaG_FormClosed);
            this.grbAsistencia.ResumeLayout(false);
            this.grbAsistencia.PerformLayout();
            this.flowLPAsistencias.ResumeLayout(false);
            this.flowLPAsistencias.PerformLayout();
            this.panelAsistencias.ResumeLayout(false);
            this.panelAsistencias.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.FlowLayoutPanel contenedorMaterias;
        private System.Windows.Forms.GroupBox grbAsistencia;
        private System.Windows.Forms.FlowLayoutPanel panelAlumnos;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.FlowLayoutPanel panelAsistencias;
        private System.Windows.Forms.FlowLayoutPanel flowLPAsistencias;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}