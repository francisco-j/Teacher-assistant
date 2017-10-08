using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormGrupoMateria : Form
    {
        FlowLayoutPanel tareas, proyectos, examenes, calificaciones;
        int idMateria, idGrupo;


//*************************** constructor ******************************************

        /// <summary> muestra informacion y funciones del grupo indicado </summary>
        public FormGrupoMateria(int idMateria, int idGrupo)
        {
            InitializeComponent();

            this.idMateria = idMateria;
            this.idGrupo = idGrupo;

            personalizarVentana(idMateria, idGrupo);

            btnTareas.PerformClick();

        }


// ******************************** btn Eventos ***************************************************

        /// <summary> muestra la ventana tareas </summary>
        private void btnTareas_Click(object sender, EventArgs e)
        {
            grpBxModulo.Controls.Clear();

            FlowLayoutPanel panel = PersonalizacionComponentes.hacerPanelGenerico();
            grpBxModulo.Controls.Add(panel);
            panel.Location = new Point(3, 16);
            

            grpBxModulo.Text = "tareas";
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            grpBxModulo.Controls.Clear();

            grpBxModulo.Controls.Add(PersonalizacionComponentes.hacerPanelGenerico());

            grpBxModulo.Text = "proyectos";
        }

        private void btnExamenes_Click(object sender, EventArgs e)
        {
            grpBxModulo.Controls.Clear();

            grpBxModulo.Controls.Add(PersonalizacionComponentes.hacerPanelGenerico());

            grpBxModulo.Text = "examenes";
        }

        private void FormGrupoMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            grpBxModulo.Controls.Clear();

            grpBxModulo.Controls.Add(PersonalizacionComponentes.hacerPanelGenerico());

            grpBxModulo.Text = "examenes";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.returnToListaMaterias();
            this.Dispose();
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

        private void crearFLPanel (ref FlowLayoutPanel flPanel)
        {
            Console.Write("new ");
            flPanel = new FlowLayoutPanel();

            if (flPanel == tareas)
                flPanel.Name = "tareas";
            else if (flPanel == proyectos)
                flPanel.Name = "proyectos";
            else if (flPanel == examenes)
                flPanel.Name = "examenes";
            else if (flPanel == calificaciones)
                flPanel.Name = "calificaciones";

            Console.WriteLine(flPanel.Name + ".");

            flPanel.AutoSize = true;
        }

    }
}
