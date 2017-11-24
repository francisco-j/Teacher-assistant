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
            this.flPanelMaterias = new System.Windows.Forms.FlowLayoutPanel();
            this.grBoxAsistencia = new System.Windows.Forms.GroupBox();
            this.btnAddDia = new System.Windows.Forms.Button();
            this.tlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flPanelAlumnos = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flPanelFechas = new System.Windows.Forms.FlowLayoutPanel();
            this.tiltLabel1 = new WindowsFormsApp3.componentes_visuales.tiltLabel();
            this.flPanelAsistencias = new System.Windows.Forms.FlowLayoutPanel();
            this.ckBox1 = new System.Windows.Forms.CheckBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.grBoxMaterias = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.grBoxAsistencia.SuspendLayout();
            this.tlPanel.SuspendLayout();
            this.flPanelAlumnos.SuspendLayout();
            this.flPanelFechas.SuspendLayout();
            this.flPanelAsistencias.SuspendLayout();
            this.grBoxMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.txbBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBusqueda.Location = new System.Drawing.Point(818, 30);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.ReadOnly = true;
            this.txbBusqueda.Size = new System.Drawing.Size(211, 30);
            this.txbBusqueda.TabIndex = 13;
            this.txbBusqueda.Text = "Nombre del alumno";
            this.txbBusqueda.Click += new System.EventHandler(this.txbBusqueda_Click);
            this.txbBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBusqueda_KeyPress);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Menu;
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
            this.btnAgregarMateria.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoAddMateria;
            this.btnAgregarMateria.FlatAppearance.BorderSize = 0;
            this.btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMateria.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(6, 446);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(32, 32);
            this.btnAgregarMateria.TabIndex = 16;
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoBack;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 20);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(32, 32);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::WindowsFormsApp3.Properties.Resources.icoBuscar;
            this.btnBuscar.Location = new System.Drawing.Point(1035, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // flPanelMaterias
            // 
            this.flPanelMaterias.AutoScroll = true;
            this.flPanelMaterias.Location = new System.Drawing.Point(6, 30);
            this.flPanelMaterias.Name = "flPanelMaterias";
            this.flPanelMaterias.Size = new System.Drawing.Size(195, 410);
            this.flPanelMaterias.TabIndex = 18;
            // 
            // grBoxAsistencia
            // 
            this.grBoxAsistencia.Controls.Add(this.btnAddDia);
            this.grBoxAsistencia.Controls.Add(this.tlPanel);
            this.grBoxAsistencia.Controls.Add(this.btnAgregarAlumno);
            this.grBoxAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxAsistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.grBoxAsistencia.Location = new System.Drawing.Point(225, 80);
            this.grBoxAsistencia.Name = "grBoxAsistencia";
            this.grBoxAsistencia.Size = new System.Drawing.Size(842, 486);
            this.grBoxAsistencia.TabIndex = 0;
            this.grBoxAsistencia.TabStop = false;
            this.grBoxAsistencia.Text = "Asistencia";
            // 
            // btnAddDia
            // 
            this.btnAddDia.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoAddDia;
            this.btnAddDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDia.FlatAppearance.BorderSize = 0;
            this.btnAddDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDia.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDia.Location = new System.Drawing.Point(783, 446);
            this.btnAddDia.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddDia.Name = "btnAddDia";
            this.btnAddDia.Size = new System.Drawing.Size(38, 36);
            this.btnAddDia.TabIndex = 21;
            this.btnAddDia.UseVisualStyleBackColor = true;
            this.btnAddDia.Click += new System.EventHandler(this.btnAddDia_Click);
            // 
            // tlPanel
            // 
            this.tlPanel.ColumnCount = 2;
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPanel.Controls.Add(this.flPanelAlumnos, 0, 1);
            this.tlPanel.Controls.Add(this.flPanelFechas, 1, 0);
            this.tlPanel.Controls.Add(this.flPanelAsistencias, 1, 1);
            this.tlPanel.Location = new System.Drawing.Point(6, 30);
            this.tlPanel.Name = "tlPanel";
            this.tlPanel.RowCount = 2;
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPanel.Size = new System.Drawing.Size(809, 419);
            this.tlPanel.TabIndex = 20;
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
            this.flPanelAlumnos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flPanelAlumnos_Scroll);
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
            // flPanelFechas
            // 
            this.flPanelFechas.AutoScroll = true;
            this.flPanelFechas.Controls.Add(this.tiltLabel1);
            this.flPanelFechas.Location = new System.Drawing.Point(336, 3);
            this.flPanelFechas.Name = "flPanelFechas";
            this.flPanelFechas.Size = new System.Drawing.Size(455, 71);
            this.flPanelFechas.TabIndex = 0;
            this.flPanelFechas.WrapContents = false;
            this.flPanelFechas.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flPanelFechas_Scroll);
            // 
            // tiltLabel1
            // 
            this.tiltLabel1.Fecha = new System.DateTime(((long)(0)));
            this.tiltLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiltLabel1.Location = new System.Drawing.Point(3, 0);
            this.tiltLabel1.Name = "tiltLabel1";
            this.tiltLabel1.RotationAngle = -60D;
            this.tiltLabel1.Size = new System.Drawing.Size(44, 57);
            this.tiltLabel1.TabIndex = 0;
            this.tiltLabel1.Text = "00/00/00";
            // 
            // flPanelAsistencias
            // 
            this.flPanelAsistencias.AutoScroll = true;
            this.flPanelAsistencias.Controls.Add(this.ckBox1);
            this.flPanelAsistencias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flPanelAsistencias.Location = new System.Drawing.Point(336, 80);
            this.flPanelAsistencias.Name = "flPanelAsistencias";
            this.flPanelAsistencias.Size = new System.Drawing.Size(470, 336);
            this.flPanelAsistencias.TabIndex = 1;
            this.flPanelAsistencias.WrapContents = false;
            this.flPanelAsistencias.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flPanelAsistencias_Scroll);
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
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icoAddAlumno;
            this.btnAgregarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarAlumno.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Marlett", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(0, 446);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(48, 40);
            this.btnAgregarAlumno.TabIndex = 19;
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // grBoxMaterias
            // 
            this.grBoxMaterias.Controls.Add(this.flPanelMaterias);
            this.grBoxMaterias.Controls.Add(this.btnAgregarMateria);
            this.grBoxMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.grBoxMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.grBoxMaterias.Location = new System.Drawing.Point(12, 80);
            this.grBoxMaterias.Name = "grBoxMaterias";
            this.grBoxMaterias.Size = new System.Drawing.Size(207, 486);
            this.grBoxMaterias.TabIndex = 20;
            this.grBoxMaterias.TabStop = false;
            this.grBoxMaterias.Text = "Materias";
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(542, 195);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(22, 317);
            this.lbl2.TabIndex = 21;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(557, 167);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(470, 19);
            this.lbl1.TabIndex = 1;
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(234, 505);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(330, 15);
            this.lbl3.TabIndex = 23;
            // 
            // FormListaMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1079, 578);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.grBoxMaterias);
            this.Controls.Add(this.grBoxAsistencia);
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
            this.grBoxAsistencia.ResumeLayout(false);
            this.tlPanel.ResumeLayout(false);
            this.flPanelAlumnos.ResumeLayout(false);
            this.flPanelAlumnos.PerformLayout();
            this.flPanelFechas.ResumeLayout(false);
            this.flPanelAsistencias.ResumeLayout(false);
            this.flPanelAsistencias.PerformLayout();
            this.grBoxMaterias.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flPanelMaterias;
        private System.Windows.Forms.GroupBox grBoxAsistencia;
        private System.Windows.Forms.FlowLayoutPanel flPanelAlumnos;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.FlowLayoutPanel flPanelAsistencias;
        private System.Windows.Forms.CheckBox ckBox1;
        private System.Windows.Forms.GroupBox grBoxMaterias;
        private System.Windows.Forms.TableLayoutPanel tlPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flPanelFechas;
        private System.Windows.Forms.Button btnAddDia;
        private componentes_visuales.tiltLabel tiltLabel1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
    }
}