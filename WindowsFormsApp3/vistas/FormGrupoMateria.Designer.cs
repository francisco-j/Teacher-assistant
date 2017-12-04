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
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flPanelFechas = new System.Windows.Forms.FlowLayoutPanel();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.quitar = new System.Windows.Forms.CheckBox();
            this.lblInfoDias = new System.Windows.Forms.Label();
            this.flPanelAlumnos = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblTareas = new System.Windows.Forms.Label();
            this.lblExamenes = new System.Windows.Forms.Label();
            this.lblProyectos = new System.Windows.Forms.Label();
            this.lblCalificaciones = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.quitar2 = new WindowsFormsApp3.componentes_visuales.tiltLabel();
            this.grpBxModulo.SuspendLayout();
            this.tlPanel.SuspendLayout();
            this.flPanelFechas.SuspendLayout();
            this.flPanel.SuspendLayout();
            this.flPanelAlumnos.SuspendLayout();
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
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 2;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.Controls.Add(this.flPanelFechas, 1, 0);
            this.tlPanel.Controls.Add(this.flPanel, 0, 1);
            this.tlPanel.Controls.Add(this.flPanelAlumnos, 0, 1);
            this.tlPanel.Location = new System.Drawing.Point(6, 30);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 2;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanel.Size = new System.Drawing.Size(809, 419);
            this.tlPanel.TabIndex = 21;
            // 
            // flPanelFechas
            // 
            this.flPanelFechas.AutoScroll = true;
            this.flPanelFechas.Controls.Add(this.quitar2);
            this.flPanelFechas.Location = new System.Drawing.Point(336, 3);
            this.flPanelFechas.Name = "flPanelFechas";
            this.flPanelFechas.Size = new System.Drawing.Size(455, 71);
            this.flPanelFechas.TabIndex = 3;
            this.flPanelFechas.WrapContents = false;
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.Controls.Add(this.quitar);
            this.flPanel.Controls.Add(this.lblInfoDias);
            this.flPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanel.Location = new System.Drawing.Point(336, 80);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(470, 336);
            this.flPanel.TabIndex = 2;
            this.flPanel.WrapContents = false;
            // 
            // quitar
            // 
            this.quitar.AutoSize = true;
            this.quitar.Location = new System.Drawing.Point(3, 3);
            this.quitar.Name = "quitar";
            this.quitar.Size = new System.Drawing.Size(15, 14);
            this.quitar.TabIndex = 0;
            this.quitar.UseVisualStyleBackColor = true;
            // 
            // lblInfoDias
            // 
            this.lblInfoDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblInfoDias.Location = new System.Drawing.Point(3, 20);
            this.lblInfoDias.Name = "lblInfoDias";
            this.lblInfoDias.Size = new System.Drawing.Size(305, 310);
            this.lblInfoDias.TabIndex = 29;
            this.lblInfoDias.Text = "\r\n\r\nPara agregar un día de asistencia haz clic aquí";
            // 
            // flPanelAlumnos
            // 
            this.flPanelAlumnos.AutoScroll = true;
            this.flPanelAlumnos.Controls.Add(this.label2);
            this.flPanelAlumnos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelAlumnos.Location = new System.Drawing.Point(3, 80);
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
            this.upDnProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDnProyectos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDnProyectos.Location = new System.Drawing.Point(895, 44);
            this.upDnProyectos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDnProyectos.Name = "upDnProyectos";
            this.upDnProyectos.Size = new System.Drawing.Size(41, 22);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(835, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tareas";
            this.label1.UseWaitCursor = true;
            // 
            // upDnTareas
            // 
            this.upDnTareas.DecimalPlaces = 1;
            this.upDnTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDnTareas.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDnTareas.Location = new System.Drawing.Point(895, 9);
            this.upDnTareas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDnTareas.Name = "upDnTareas";
            this.upDnTareas.Size = new System.Drawing.Size(38, 22);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(954, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Exámenes";
            this.label3.UseWaitCursor = true;
            // 
            // upDnExamenes
            // 
            this.upDnExamenes.DecimalPlaces = 1;
            this.upDnExamenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDnExamenes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.upDnExamenes.Location = new System.Drawing.Point(1038, 9);
            this.upDnExamenes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDnExamenes.Name = "upDnExamenes";
            this.upDnExamenes.Size = new System.Drawing.Size(39, 22);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(813, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Proyectos";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.label6.Location = new System.Drawing.Point(954, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Total";
            this.label6.UseWaitCursor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(164)))), ((int)(((byte)(140)))));
            this.lblTotal.Location = new System.Drawing.Point(1001, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 18);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "10";
            this.lblTotal.UseWaitCursor = true;
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
            this.lblTareas.Click += new System.EventHandler(this.btnTareas_Click);
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
            this.lblExamenes.Click += new System.EventHandler(this.btnProyectos_Click);
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
            this.lblProyectos.Click += new System.EventHandler(this.btnExamenes_Click);
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
            this.lblCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(542, 190);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(22, 317);
            this.lbl2.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(234, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 15);
            this.label4.TabIndex = 35;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(557, 167);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(470, 19);
            this.lbl1.TabIndex = 36;
            // 
            // quitar2
            // 
            this.quitar2.Fecha = new System.DateTime(((long)(0)));
            this.quitar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitar2.Location = new System.Drawing.Point(3, 0);
            this.quitar2.Name = "quitar2";
            this.quitar2.RotationAngle = -60D;
            this.quitar2.Size = new System.Drawing.Size(44, 57);
            this.quitar2.TabIndex = 0;
            this.quitar2.Text = "00/00/00";
            // 
            // FormGrupoMateria
            // 
            this.AccessibleName = "FormGrupo";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1083, 582);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblCalificaciones);
            this.Controls.Add(this.lblProyectos);
            this.Controls.Add(this.lblExamenes);
            this.Controls.Add(this.lblTareas);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblTotal);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "FormGrupo";
            this.Text = "Grupo materia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGrupoMateria_FormClosed);
            this.Load += new System.EventHandler(this.FormGrupoMateria_Load);
            this.grpBxModulo.ResumeLayout(false);
            this.tlPanel.ResumeLayout(false);
            this.flPanelFechas.ResumeLayout(false);
            this.flPanel.ResumeLayout(false);
            this.flPanel.PerformLayout();
            this.flPanelAlumnos.ResumeLayout(false);
            this.flPanelAlumnos.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown upDnProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDnTareas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upDnExamenes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.Label lblExamenes;
        private System.Windows.Forms.Label lblProyectos;
        private System.Windows.Forms.Label lblCalificaciones;
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.FlowLayoutPanel flPanelAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.CheckBox quitar;
        private System.Windows.Forms.Label lblInfoDias;
        private System.Windows.Forms.FlowLayoutPanel flPanelFechas;
        private componentes_visuales.tiltLabel quitar2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl1;
    }
}