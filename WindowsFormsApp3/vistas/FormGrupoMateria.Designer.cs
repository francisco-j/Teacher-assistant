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
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flPanelAlumnos = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flPanelTitulos = new System.Windows.Forms.FlowLayoutPanel();
            this.dateLabel2 = new WindowsFormsApp3.componentes_visuales.dateLabel();
            this.flPanelEntregas = new System.Windows.Forms.FlowLayoutPanel();
            this.ckBox1 = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.btnExamenes = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpBxModulo.SuspendLayout();
            this.tlPanel.SuspendLayout();
            this.flPanelAlumnos.SuspendLayout();
            this.flPanelTitulos.SuspendLayout();
            this.flPanelEntregas.SuspendLayout();
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
            this.grpBxModulo.Controls.Add(this.tlPanel);
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
            // tlPanel
            // 
            this.tlPanel.AutoSize = true;
            this.tlPanel.ColumnCount = 2;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.Controls.Add(this.flPanelAlumnos, 0, 1);
            this.tlPanel.Controls.Add(this.flPanelTitulos, 1, 0);
            this.tlPanel.Controls.Add(this.flPanelEntregas, 1, 1);
            this.tlPanel.Location = new System.Drawing.Point(6, 28);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 2;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.91045F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.08955F));
            this.tlPanel.Size = new System.Drawing.Size(681, 313);
            this.tlPanel.TabIndex = 21;
            // 
            // flPanelAlumnos
            // 
            this.flPanelAlumnos.AutoSize = true;
            this.flPanelAlumnos.Controls.Add(this.label2);
            this.flPanelAlumnos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelAlumnos.Location = new System.Drawing.Point(3, 59);
            this.flPanelAlumnos.Name = "flPanelAlumnos";
            this.flPanelAlumnos.Size = new System.Drawing.Size(327, 26);
            this.flPanelAlumnos.TabIndex = 0;
            this.flPanelAlumnos.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Francisco Javier Fuentes Torres";
            // 
            // flPanelTitulos
            // 
            this.flPanelTitulos.AutoSize = true;
            this.flPanelTitulos.Controls.Add(this.dateLabel2);
            this.flPanelTitulos.Location = new System.Drawing.Point(336, 3);
            this.flPanelTitulos.Name = "flPanelTitulos";
            this.flPanelTitulos.Size = new System.Drawing.Size(38, 45);
            this.flPanelTitulos.TabIndex = 0;
            this.flPanelTitulos.WrapContents = false;
            // 
            // dateLabel2
            // 
            this.dateLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel2.Fecha = new System.DateTime(((long)(0)));
            this.dateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateLabel2.Location = new System.Drawing.Point(0, 0);
            this.dateLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.RotationAngle = -52D;
            this.dateLabel2.Size = new System.Drawing.Size(38, 45);
            this.dateLabel2.TabIndex = 2;
            this.dateLabel2.Text = "30/12/17";
            // 
            // flPanelEntregas
            // 
            this.flPanelEntregas.AutoSize = true;
            this.flPanelEntregas.Controls.Add(this.ckBox1);
            this.flPanelEntregas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelEntregas.Location = new System.Drawing.Point(336, 59);
            this.flPanelEntregas.Name = "flPanelEntregas";
            this.flPanelEntregas.Size = new System.Drawing.Size(21, 20);
            this.flPanelEntregas.TabIndex = 1;
            // 
            // ckBox1
            // 
            this.ckBox1.AutoSize = true;
            this.ckBox1.Location = new System.Drawing.Point(3, 3);
            this.ckBox1.Name = "ckBox1";
            this.ckBox1.Size = new System.Drawing.Size(15, 14);
            this.ckBox1.TabIndex = 0;
            this.ckBox1.UseVisualStyleBackColor = true;
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
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.No;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Notas 2 peque.png");
            this.imageList1.Images.SetKeyName(1, "Notaspeque.png");
            this.imageList1.Images.SetKeyName(2, "Examenes o calificacionespeque.png");
            this.imageList1.Images.SetKeyName(3, "examenespeque.png");
            // 
            // FormGrupoMateria
            // 
            this.AccessibleName = "FormGrupo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(954, 501);
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
            this.grpBxModulo.ResumeLayout(false);
            this.grpBxModulo.PerformLayout();
            this.tlPanel.ResumeLayout(false);
            this.tlPanel.PerformLayout();
            this.flPanelAlumnos.ResumeLayout(false);
            this.flPanelAlumnos.PerformLayout();
            this.flPanelTitulos.ResumeLayout(false);
            this.flPanelEntregas.ResumeLayout(false);
            this.flPanelEntregas.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.FlowLayoutPanel flPanelAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flPanelTitulos;
        private componentes_visuales.dateLabel dateLabel2;
        private System.Windows.Forms.FlowLayoutPanel flPanelEntregas;
        private System.Windows.Forms.CheckBox ckBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}