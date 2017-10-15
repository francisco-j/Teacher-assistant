using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.clases;

namespace WindowsFormsApp3
{
    public partial class FormGrupoMateria : Form
    {
        int idMateria;
        int idGrupo;
        Alumno[] alumnos;


//*************************** constructor ******************************************

        /// <summary> muestra informacion y funciones del grupo indicado </summary>
        public FormGrupoMateria(int idMateria, int idGrupo)
        {
            InitializeComponent();

            this.idMateria = idMateria;

            this.idGrupo = idGrupo;
            alumnos = Program.alumnosGrupo(idGrupo);

            personalizarVentana(idMateria, idGrupo);

            btnTareas.PerformClick();

        }


// ******************************** btn Eventos ***************************************************

        /// <summary> muestra la ventana tareas </summary>
        private void btnTareas_Click(object sender, EventArgs e)
        {
            grpBxModulo.Text = "tareas";
            PersonalizacionComponentes.decorarPanelTareas(ref fLPanel, alumnos, idGrupo, idMateria);
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            grpBxModulo.Text = "proyectos";
            //PersonalizacionComponentes.decorarPanelProyectos(ref fLPanel);
        }

        private void btnExamenes_Click(object sender, EventArgs e)
        {
            grpBxModulo.Text = "examenes";
            //PersonalizacionComponentes.decorarPanelExamenes(ref fLPanel);
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            grpBxModulo.Text = "calificaciones";
            //PersonalizacionComponentes.decorarPanelCalificaciones(ref fLPanel);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.returnToListaMaterias();
            this.Dispose();
        }


//**************************************** otros eventos *******************************************

        private void FormGrupoMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

// **************************************** privados **************************************************

        private void personalizarVentana(int idMateria,int idGrupo)
        {
            string grupo, materia, numeroAlumnos, escuela;

            Program.getIfo(idMateria, idGrupo, out grupo, out materia, out numeroAlumnos, out escuela);

            lblGrupo.Text = grupo;
            lblMateria.Text = materia;
            lblDatosGrupo.Text = numeroAlumnos + lblDatosGrupo.Text + escuela;

            this.Text = grupo + " " + materia;
        }

    }
}
