namespace WindowsFormsApp3
{
    partial class FormGrupo
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
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblDatosGrupo = new System.Windows.Forms.Label();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnEvaluaciones = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAgregarDia = new System.Windows.Forms.Button();
            this.lblNombres = new System.Windows.Forms.Label();
            this.groupBoxAsistencia = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblMateria = new System.Windows.Forms.Label();
            this.groupBoxAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.lblGrupo.Location = new System.Drawing.Point(12, 9);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(127, 63);
            this.lblGrupo.TabIndex = 0;
            this.lblGrupo.Text = "5º A";
            // 
            // lblDatosGrupo
            // 
            this.lblDatosGrupo.AutoSize = true;
            this.lblDatosGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(240)))), ((int)(((byte)(215)))));
            this.lblDatosGrupo.Location = new System.Drawing.Point(145, 9);
            this.lblDatosGrupo.Name = "lblDatosGrupo";
            this.lblDatosGrupo.Size = new System.Drawing.Size(168, 50);
            this.lblDatosGrupo.TabIndex = 13;
            this.lblDatosGrupo.Text = "(#) Alumnos\r\nPrimaria (nombre)";
            // 
            // btnTareas
            // 
            this.btnTareas.BackColor = System.Drawing.Color.Transparent;
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnTareas.Image = global::WindowsFormsApp3.Properties.Resources.icoTareas;
            this.btnTareas.Location = new System.Drawing.Point(12, 174);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(70, 70);
            this.btnTareas.TabIndex = 15;
            this.btnTareas.Text = " ";
            this.btnTareas.UseVisualStyleBackColor = false;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnAlumnos.Image = global::WindowsFormsApp3.Properties.Resources.icoAlumnos;
            this.btnAlumnos.Location = new System.Drawing.Point(12, 242);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(70, 70);
            this.btnAlumnos.TabIndex = 15;
            this.btnAlumnos.Text = " ";
            this.btnAlumnos.UseVisualStyleBackColor = false;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnEvaluaciones
            // 
            this.btnEvaluaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnEvaluaciones.FlatAppearance.BorderSize = 0;
            this.btnEvaluaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnEvaluaciones.Image = global::WindowsFormsApp3.Properties.Resources.icoEvaluaciones;
            this.btnEvaluaciones.Location = new System.Drawing.Point(12, 312);
            this.btnEvaluaciones.Name = "btnEvaluaciones";
            this.btnEvaluaciones.Size = new System.Drawing.Size(70, 70);
            this.btnEvaluaciones.TabIndex = 15;
            this.btnEvaluaciones.Text = " ";
            this.btnEvaluaciones.UseVisualStyleBackColor = false;
            // 
            // btnNotas
            // 
            this.btnNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnNotas.Image = global::WindowsFormsApp3.Properties.Resources.icoNotas;
            this.btnNotas.Location = new System.Drawing.Point(12, 384);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(70, 70);
            this.btnNotas.TabIndex = 15;
            this.btnNotas.Text = " ";
            this.btnNotas.UseVisualStyleBackColor = false;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnAsistencia.Image = global::WindowsFormsApp3.Properties.Resources.icoAsistencia;
            this.btnAsistencia.Location = new System.Drawing.Point(12, 105);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(70, 70);
            this.btnAsistencia.TabIndex = 15;
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnAgregarDia
            // 
            this.btnAgregarDia.FlatAppearance.BorderSize = 0;
            this.btnAgregarDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDia.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDia.Location = new System.Drawing.Point(599, 20);
            this.btnAgregarDia.Name = "btnAgregarDia";
            this.btnAgregarDia.Size = new System.Drawing.Size(63, 67);
            this.btnAgregarDia.TabIndex = 15;
            this.btnAgregarDia.Text = "+";
            this.btnAgregarDia.UseVisualStyleBackColor = true;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(240)))), ((int)(((byte)(215)))));
            this.lblNombres.Location = new System.Drawing.Point(6, 17);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(87, 25);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombre:";
            // 
            // groupBoxAsistencia
            // 
            this.groupBoxAsistencia.Controls.Add(this.lblNombres);
            this.groupBoxAsistencia.Controls.Add(this.splitContainer1);
            this.groupBoxAsistencia.Controls.Add(this.btnAgregarDia);
            this.groupBoxAsistencia.Location = new System.Drawing.Point(125, 88);
            this.groupBoxAsistencia.Name = "groupBoxAsistencia";
            this.groupBoxAsistencia.Size = new System.Drawing.Size(662, 433);
            this.groupBoxAsistencia.TabIndex = 16;
            this.groupBoxAsistencia.TabStop = false;
            this.groupBoxAsistencia.Text = "Asistencias";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(11, 45);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(582, 382);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 16;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblMateria.ForeColor = System.Drawing.Color.Sienna;
            this.lblMateria.Location = new System.Drawing.Point(382, 9);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(152, 46);
            this.lblMateria.TabIndex = 13;
            this.lblMateria.Text = "materia";
            // 
            // FormGrupo
            // 
            this.AccessibleName = "FormGrupo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(795, 530);
            this.Controls.Add(this.groupBoxAsistencia);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.btnEvaluaciones);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.btnTareas);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDatosGrupo);
            this.Controls.Add(this.lblGrupo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Name = "FormGrupo";
            this.Tag = "FormGrupo";
            this.Text = "Grupo ";
            this.groupBoxAsistencia.ResumeLayout(false);
            this.groupBoxAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblDatosGrupo;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnEvaluaciones;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnAgregarDia;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.GroupBox groupBoxAsistencia;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblMateria;
    }
}