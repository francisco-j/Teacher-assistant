namespace WindowsFormsApp3
{
    partial class FormGrupoMateria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupoMateria));
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblDatosGrupo = new System.Windows.Forms.Label();
            this.grpBxModulo = new System.Windows.Forms.GroupBox();
            this.fLPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.btnExamenes = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpBxModulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.lblGrupo.Location = new System.Drawing.Point(55, 9);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(127, 63);
            this.lblGrupo.TabIndex = 0;
            this.lblGrupo.Text = "1º A";
            // 
            // lblDatosGrupo
            // 
            this.lblDatosGrupo.AutoSize = true;
            this.lblDatosGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.lblDatosGrupo.Location = new System.Drawing.Point(188, 9);
            this.lblDatosGrupo.Name = "lblDatosGrupo";
            this.lblDatosGrupo.Size = new System.Drawing.Size(94, 25);
            this.lblDatosGrupo.TabIndex = 13;
            this.lblDatosGrupo.Text = " Alumnos\r\n";
            // 
            // grpBxModulo
            // 
            this.grpBxModulo.Controls.Add(this.fLPanel);
            this.grpBxModulo.Controls.Add(this.btnAgregar);
            this.grpBxModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpBxModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.grpBxModulo.Location = new System.Drawing.Point(109, 88);
            this.grpBxModulo.Name = "grpBxModulo";
            this.grpBxModulo.Size = new System.Drawing.Size(788, 402);
            this.grpBxModulo.TabIndex = 16;
            this.grpBxModulo.TabStop = false;
            this.grpBxModulo.Text = "Modulo";
            // 
            // fLPanel
            // 
            this.fLPanel.AutoSize = true;
            this.fLPanel.Location = new System.Drawing.Point(6, 28);
            this.fLPanel.Name = "fLPanel";
            this.fLPanel.Size = new System.Drawing.Size(103, 75);
            this.fLPanel.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoMas;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(750, 364);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(32, 32);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.lblMateria.Location = new System.Drawing.Point(382, 9);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(152, 46);
            this.lblMateria.TabIndex = 13;
            this.lblMateria.Text = "Materia";
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.BackColor = System.Drawing.Color.Transparent;
            this.btnCalificaciones.FlatAppearance.BorderSize = 0;
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnCalificaciones.Image = global::WindowsFormsApp3.Properties.Resources.examenespeque;
            this.btnCalificaciones.Location = new System.Drawing.Point(12, 362);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(70, 88);
            this.btnCalificaciones.TabIndex = 15;
            this.btnCalificaciones.Text = " ";
            this.btnCalificaciones.UseVisualStyleBackColor = false;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // btnExamenes
            // 
            this.btnExamenes.BackColor = System.Drawing.Color.Transparent;
            this.btnExamenes.FlatAppearance.BorderSize = 0;
            this.btnExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnExamenes.Image = global::WindowsFormsApp3.Properties.Resources.Examenes_o_calificacionespeque;
            this.btnExamenes.Location = new System.Drawing.Point(12, 277);
            this.btnExamenes.Name = "btnExamenes";
            this.btnExamenes.Size = new System.Drawing.Size(70, 79);
            this.btnExamenes.TabIndex = 15;
            this.btnExamenes.Text = " ";
            this.btnExamenes.UseVisualStyleBackColor = false;
            this.btnExamenes.Click += new System.EventHandler(this.btnExamenes_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnProyectos.FlatAppearance.BorderSize = 0;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnProyectos.Image = global::WindowsFormsApp3.Properties.Resources.Notaspeque;
            this.btnProyectos.Location = new System.Drawing.Point(12, 181);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(70, 80);
            this.btnProyectos.TabIndex = 15;
            this.btnProyectos.Text = " ";
            this.btnProyectos.UseVisualStyleBackColor = false;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.BackColor = System.Drawing.Color.Transparent;
            this.btnTareas.FlatAppearance.BorderSize = 0;
            this.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.btnTareas.Image = global::WindowsFormsApp3.Properties.Resources.Notas_2_peque;
            this.btnTareas.Location = new System.Drawing.Point(12, 88);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(70, 87);
            this.btnTareas.TabIndex = 15;
            this.btnTareas.UseVisualStyleBackColor = false;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoBack;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 24;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormGrupoMateria
            // 
            this.AccessibleName = "FormGrupo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(958, 502);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpBxModulo);
            this.Controls.Add(this.btnCalificaciones);
            this.Controls.Add(this.btnExamenes);
            this.Controls.Add(this.btnProyectos);
            this.Controls.Add(this.btnTareas);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDatosGrupo);
            this.Controls.Add(this.lblGrupo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGrupoMateria";
            this.Tag = "FormGrupo";
            this.Text = "Grupo materia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGrupoMateria_FormClosed);
            this.Load += new System.EventHandler(this.FormGrupoMateria_Load);
            this.grpBxModulo.ResumeLayout(false);
            this.grpBxModulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblDatosGrupo;
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.Button btnExamenes;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpBxModulo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel fLPanel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}