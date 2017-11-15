using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.componentes_visuales;

namespace WindowsFormsApp3
{
    public partial class FormGrupoMateria : Form
    {
        int idMateria;
        int idGrupo;
        Alumno[] alumnos;

#region constructor

        /// <summary> muestra informacion y funciones del grupo indicado </summary>
        public FormGrupoMateria(int idMateria, int idGrupo)
        {
            InitializeComponent();
            this.idMateria = idMateria;

            this.idGrupo = idGrupo;
            alumnos = dbConection.alumnosGrupo(idGrupo);

            personalizarVentana(idMateria, idGrupo);

            btnTareas.PerformClick();
        }
        
#endregion

#region eventos

        /// <summary> muestra la ventana tareas </summary>
        private void btnTareas_Click(object sender, EventArgs e)
        {
            grpBxModulo.Text = "Tareas";

            flPanelTitulos.Controls.Clear();
            flPanelEntregas.Controls.Clear();
            Tarea[] listTareas = dbConection.getTareas(idMateria);

            foreach (Tarea tarea in listTareas)
            {
                flPanelTitulos.Controls.Add(new tiltLabel(tarea.nombre));
            }

            foreach (Alumno alumno in alumnos)
            {
                FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelTareas(alumno.getId(), listTareas);

                flPanelEntregas.Controls.Add(entregas);
            }
        }

        /// <summary> muestra la ventana proyectos </summary>
        private void btnProyectos_Click(object sender, EventArgs e)
        {
            grpBxModulo.Text = "Proyectos";

            flPanelTitulos.Controls.Clear();
            flPanelEntregas.Controls.Clear();
            Proyecto[] listProyectos = dbConection.getProyectos(idMateria);

            foreach (Proyecto proyecto in listProyectos)
            {
                flPanelTitulos.Controls.Add(new tiltLabel(proyecto.nombre));
            }

            foreach (Alumno alumno in alumnos)
            {
                //FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelProyectos(alumno.getId(), listProyectos);

                //flPanelEntregas.Controls.Add(entregas);
            }
        }

        /// <summary> muestra la ventana examenes </summary>
        private void btnExamenes_Click(object sender, EventArgs e)
        {
            grpBxModulo.Text = "Examenes";
            //PersonalizacionComponentes.decorarPanelExamenes(ref fLPanel);
        }

        /// <summary> muestra la ventana tareas </summary>
        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            grpBxModulo.Text = "Calificaciones";
            //PersonalizacionComponentes.decorarPanelCalificaciones(ref fLPanel);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.returnToListaMaterias();
            this.Dispose();
        }

        private void FormGrupoMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDn_ValueChanged(object sender, EventArgs e)
        {
            float total = (float) (upDnAsistencias.Value + upDnTareas.Value + upDnExamenes.Value + upDnProyectos.Value);

            lblTotal.Text = total.ToString();

            lblTotal.ForeColor = total!=10 ? Color.Salmon: Color.FromArgb(56, 164, 140);
        }

#endregion

#region metodos

        private void personalizarVentana(int idMateria,int idGrupo)
        {
            string grupo, materia, numeroAlumnos, escuela;

            dbConection.getInfo(idMateria, idGrupo, out grupo, out materia, out numeroAlumnos, out escuela);

            lblGrupo.Text = grupo;
            lblMateria.Text = materia;
            lblDatosGrupo.Text = numeroAlumnos + lblDatosGrupo.Text + escuela;

            this.Text = grupo + " " + materia;

            PersonalizacionComponentes.llenarPanelAlunos(flPanelAlumnos, alumnos);
        }

        #endregion
    }
}