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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrupoMateria));
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblDatosGrupo = new System.Windows.Forms.Label();
            this.grpBxModulo = new System.Windows.Forms.GroupBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flPanelAlumnos = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flPanelTitulos = new System.Windows.Forms.FlowLayoutPanel();
            this.flPanelEntregas = new System.Windows.Forms.FlowLayoutPanel();
            this.ckBox1 = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.btnExamenes = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.upDnProyectos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.upDnTareas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.upDnExamenes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblTareas = new System.Windows.Forms.Label();
            this.lblExamenes = new System.Windows.Forms.Label();
            this.lblProyectos = new System.Windows.Forms.Label();
            this.lblCalificaciones = new System.Windows.Forms.Label();
            this.grpBxModulo.SuspendLayout();
            this.tlPanel.SuspendLayout();
            this.flPanelAlumnos.SuspendLayout();
            this.flPanelEntregas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDnProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnExamenes)).BeginInit();
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
            this.grpBxModulo.Controls.Add(this.btnAgregarAlumno);
            this.grpBxModulo.Controls.Add(this.tlPanel);
            this.grpBxModulo.Controls.Add(this.btnAgregar);
            this.grpBxModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpBxModulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.grpBxModulo.Location = new System.Drawing.Point(225, 80);
            this.grpBxModulo.Name = "grpBxModulo";
            this.grpBxModulo.Size = new System.Drawing.Size(842, 486);
            this.grpBxModulo.TabIndex = 16;
            this.grpBxModulo.TabStop = false;
            this.grpBxModulo.Text = "Módulo";
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoAddAlumno;
            this.btnAgregarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarAlumno.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(6, 450);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(48, 40);
            this.btnAgregarAlumno.TabIndex = 22;
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 2;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.Controls.Add(this.flPanelAlumnos, 0, 1);
            this.tlPanel.Controls.Add(this.flPanelTitulos, 1, 0);
            this.tlPanel.Controls.Add(this.flPanelEntregas, 1, 1);
            this.tlPanel.Location = new System.Drawing.Point(6, 30);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 2;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.91045F));
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.08955F));
            this.tlPanel.Size = new System.Drawing.Size(809, 419);
            this.tlPanel.TabIndex = 21;
            // 
            // flPanelAlumnos
            // 
            this.flPanelAlumnos.AutoScroll = true;
            this.flPanelAlumnos.Controls.Add(this.label2);
            this.flPanelAlumnos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelAlumnos.Location = new System.Drawing.Point(3, 78);
            this.flPanelAlumnos.Name = "flPanelAlumnos";
            this.flPanelAlumnos.Size = new System.Drawing.Size(327, 319);
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
            this.flPanelTitulos.Location = new System.Drawing.Point(336, 3);
            this.flPanelTitulos.Name = "flPanelTitulos";
            this.flPanelTitulos.Size = new System.Drawing.Size(455, 69);
            this.flPanelTitulos.TabIndex = 0;
            this.flPanelTitulos.WrapContents = false;
            // 
            // flPanelEntregas
            // 
            this.flPanelEntregas.AutoScroll = true;
            this.flPanelEntregas.Controls.Add(this.ckBox1);
            this.flPanelEntregas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelEntregas.Location = new System.Drawing.Point(336, 78);
            this.flPanelEntregas.Name = "flPanelEntregas";
            this.flPanelEntregas.Size = new System.Drawing.Size(470, 336);
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
            this.btnAgregar.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoAddGeneric;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(783, 450);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(32, 32);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(87)))));
            this.lblMateria.Location = new System.Drawing.Point(510, 14);
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
            this.btnCalificaciones.Image = global::WindowsFormsApp3.Properties.Resources.icoMenCalif;
            this.btnCalificaciones.Location = new System.Drawing.Point(12, 436);
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
            this.btnExamenes.Image = global::WindowsFormsApp3.Properties.Resources.icoMenExam;
            this.btnExamenes.Location = new System.Drawing.Point(12, 330);
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
            this.btnProyectos.Image = ((System.Drawing.Image)(resources.GetObject("btnProyectos.Image")));
            this.btnProyectos.Location = new System.Drawing.Point(12, 221);
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
            this.btnTareas.Image = ((System.Drawing.Image)(resources.GetObject("btnTareas.Image")));
            this.btnTareas.Location = new System.Drawing.Point(12, 110);
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
            // upDnProyectos
            // 
            this.upDnProyectos.DecimalPlaces = 1;
            this.upDnProyectos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDnProyectos.Location = new System.Drawing.Point(927, 9);
            this.upDnProyectos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDnProyectos.Name = "upDnProyectos";
            this.upDnProyectos.Size = new System.Drawing.Size(36, 20);
            this.upDnProyectos.TabIndex = 25;
            this.upDnProyectos.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(982, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tareas";
            this.label1.UseWaitCursor = true;
            // 
            // upDnTareas
            // 
            this.upDnTareas.DecimalPlaces = 1;
            this.upDnTareas.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDnTareas.Location = new System.Drawing.Point(1030, 9);
            this.upDnTareas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDnTareas.Name = "upDnTareas";
            this.upDnTareas.Size = new System.Drawing.Size(36, 20);
            this.upDnTareas.TabIndex = 25;
            this.upDnTareas.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(968, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Exámenes";
            this.label3.UseWaitCursor = true;
            // 
            // upDnExamenes
            // 
            this.upDnExamenes.DecimalPlaces = 1;
            this.upDnExamenes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDnExamenes.Location = new System.Drawing.Point(1030, 37);
            this.upDnExamenes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDnExamenes.Name = "upDnExamenes";
            this.upDnExamenes.Size = new System.Drawing.Size(36, 20);
            this.upDnExamenes.TabIndex = 25;
            this.upDnExamenes.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(867, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Proyectos";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(933, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Total";
            this.label6.UseWaitCursor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.lblTotal.Location = new System.Drawing.Point(967, 69);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 13);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "10";
            this.lblTotal.UseWaitCursor = true;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(557, 167);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(470, 19);
            this.lbl1.TabIndex = 27;
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(542, 195);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(22, 317);
            this.lbl2.TabIndex = 28;
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(234, 505);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(330, 15);
            this.lbl3.TabIndex = 29;
            // 
            // lblTareas
            // 
            this.lblTareas.AutoSize = true;
            this.lblTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTareas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.lblTareas.Location = new System.Drawing.Point(91, 138);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Size = new System.Drawing.Size(68, 24);
            this.lblTareas.TabIndex = 30;
            this.lblTareas.Text = "Tareas";
            // 
            // lblExamenes
            // 
            this.lblExamenes.AutoSize = true;
            this.lblExamenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.lblExamenes.Location = new System.Drawing.Point(91, 246);
            this.lblExamenes.Name = "lblExamenes";
            this.lblExamenes.Size = new System.Drawing.Size(93, 24);
            this.lblExamenes.TabIndex = 31;
            this.lblExamenes.Text = "Proyectos";
            // 
            // lblProyectos
            // 
            this.lblProyectos.AutoSize = true;
            this.lblProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.lblProyectos.Location = new System.Drawing.Point(92, 355);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(101, 24);
            this.lblProyectos.TabIndex = 32;
            this.lblProyectos.Text = "Exámenes";
            // 
            // lblCalificaciones
            // 
            this.lblCalificaciones.AutoSize = true;
            this.lblCalificaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.lblCalificaciones.Location = new System.Drawing.Point(92, 466);
            this.lblCalificaciones.Name = "lblCalificaciones";
            this.lblCalificaciones.Size = new System.Drawing.Size(125, 24);
            this.lblCalificaciones.TabIndex = 33;
            this.lblCalificaciones.Text = "Calificaciones";
            // 
            // FormGrupoMateria
            // 
            this.AccessibleName = "FormGrupo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1083, 582);
            this.Controls.Add(this.lblCalificaciones);
            this.Controls.Add(this.lblProyectos);
            this.Controls.Add(this.lblExamenes);
            this.Controls.Add(this.lblTareas);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upDnExamenes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upDnTareas);
            this.Controls.Add(this.upDnProyectos);
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
            this.tlPanel.ResumeLayout(false);
            this.flPanelAlumnos.ResumeLayout(false);
            this.flPanelAlumnos.PerformLayout();
            this.flPanelEntregas.ResumeLayout(false);
            this.flPanelEntregas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDnProyectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDnExamenes)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flPanelEntregas;
        private System.Windows.Forms.CheckBox ckBox1;
        private System.Windows.Forms.NumericUpDown upDnProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDnTareas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upDnExamenes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.Label lblExamenes;
        private System.Windows.Forms.Label lblProyectos;
        private System.Windows.Forms.Label lblCalificaciones;
    }
}