using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.componentes_visuales;
using WindowsFormsApp3.vistas;

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
        }
        
#endregion

#region eventos Módulos Click

        /// <summary> muestra la ventana tareas </summary>
        private void btnTareas_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = true;

            grpBxModulo.Text = "Tareas";
            grpBxModulo.AccessibleDescription = dbConection.tipoTarea.ToString();

            flPanelTitulos.Controls.Clear();
            flPanelTareas.Controls.Clear();
            Tarea[] listTareas = dbConection.getTareas(idMateria);

            foreach (Tarea tarea in listTareas)
            {
                tiltLabel nombreTarea = new tiltLabel(tarea.nombre);
                nombreTarea.Name = tarea.id.ToString();
                flPanelTitulos.Controls.Add(nombreTarea);
            }

            foreach (Alumno alumno in alumnos)
            {
                FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelTareas(alumno.getId(), listTareas);

                flPanelTareas.Controls.Add(entregas);
            }
        }

        /// <summary> muestra la ventana proyectos </summary>
        private void btnProyectos_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = true;

            grpBxModulo.Text = "Proyectos";
            grpBxModulo.AccessibleDescription = dbConection.tipoProy.ToString();

            flPanelTitulos.Controls.Clear();
            flPanelTareas.Controls.Clear();
            Proyecto[] listProyectos = dbConection.getProyectos(idMateria);

            foreach (Proyecto proyecto in listProyectos)
            {
                tiltLabel nombreEntrega = new tiltLabel(proyecto.nombre);
                nombreEntrega.Name = proyecto.id.ToString();

                //Sólo aquí cuando se van a mostrar NumericUpDown tenemos que dejar más espacio entre uno y otro porque sino se ve todo amontonado
                nombreEntrega.Margin = new Padding(0,0,10,0);

                MenuItem[] menu = {
                    new MenuItem("Borrar", borrarEntrega_Click)
                };
                menu[0].Name = proyecto.id.ToString();

                nombreEntrega.ContextMenu = new ContextMenu(menu);

                flPanelTitulos.Controls.Add(nombreEntrega);
            }

            foreach (Alumno alumno in alumnos)
            {
                FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelProyectos(alumno.getId(), listProyectos);
                entregas.Margin = new Padding(0, 0, 0, 3);
                flPanelTareas.Controls.Add(entregas);
            }
        }

        /// <summary> muestra la ventana examenes </summary>
        private void btnExamenes_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = true;

            grpBxModulo.Text = "Exámenes";
            grpBxModulo.AccessibleDescription = dbConection.tipoExam.ToString();

            flPanelTitulos.Controls.Clear();
            flPanelTareas.Controls.Clear();
            Examen[] listExamenes = dbConection.getExamenes(idMateria);

            foreach (Examen exam in listExamenes)
            {
                tiltLabel nombreEntrega = new tiltLabel(exam.nombre);
                nombreEntrega.Name = exam.id.ToString();

                //Sólo aquí cuando se van a mostrar NumericUpDown tenemos que dejar más espacio entre uno y otro porque sino se ve todo amontonado
                nombreEntrega.Margin = new Padding(0, 0, 10, 0);

                MenuItem[] menu = {
                    new MenuItem("Borrar", borrarEntrega_Click)
                };
                menu[0].Name = exam.id.ToString();

                nombreEntrega.ContextMenu = new ContextMenu(menu);
                flPanelTitulos.Controls.Add(nombreEntrega);
            }

            foreach (Alumno alumno in alumnos)
            {
                FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelExamenes(alumno.getId(), listExamenes);
                entregas.Margin = new Padding(0, 0, 0, 3);
                flPanelTareas.Controls.Add(entregas);
            }
            
        }

        /// <summary> muestra la ventana tareas </summary>
        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            grpBxModulo.Text = "Calificaciones";
            btnAgregar.Visible = false;

            flPanelTitulos.Controls.Clear();
            flPanelTareas.Controls.Clear();
            //PersonalizacionComponentes.decorarPanelCalificaciones(alumnos, idMateria, ref flPanelTitulos, ref flPanelTareas);
        }

        #endregion

        #region Otros eventos

        /// <summary>Cuando se presiona la opción contextual de las entregas para eliminar entregas</summary>
        private void borrarEntrega_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("¿Seguro que deseas eliminar esta entrega, al hacerlo se eliminarán los registros de los alumnos relacionados a ella?",
                "Eliminar entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                //Crear método en dbConection que elimine la tarea;
            }

        }

        /// <summary> cargar menu tareas </summary>
        private void FormGrupoMateria_Load(object sender, EventArgs e)
        {
            btnTareas.PerformClick();
        }

        /// <summary> te regresa a lista grupos </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.returnToListaMaterias();
            this.Dispose();
        }

        private void FormGrupoMateria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rubroUpDn_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;

            int tipo = int.Parse(nud.AccessibleDescription);
            dbConection.actualizarRubro(idMateria, tipo, (float)nud.Value);

            float total = (float) (upDnTareas.Value + upDnExamenes.Value + upDnProyectos.Value);

            lblTotal.Text = total.ToString();

            lblTotal.ForeColor = total!=10 ? Color.Salmon: Color.FromArgb(56, 164, 140);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int tipo = int.Parse(grpBxModulo.AccessibleDescription);
            FormAgregarEntregable newEntregable = new FormAgregarEntregable(tipo, idMateria);

            if (newEntregable.ShowDialog(this) == DialogResult.OK)
            {
                // @brandon, tu sabes que hacer aqui
            }
            
        }

        public void entregaSelected(string idAlumno, string idTarea)
        {
            (flPanelAlumnos.Controls.Find(idAlumno, false)[0] as Label).BackColor = Color.Silver;
            (flPanelTitulos.Controls.Find(idTarea, false)[0] as tiltLabel).BackColor = Color.Silver;
        }

        /// <summary>Cuando el puntero salga de algún TareaButton regresará a su color ordinario el nombre y la fecha de la asistencia correspondiente</summary>
        public void entregaLeaveSelected(string idAlumno, string idTarea)
        {
            (flPanelAlumnos.Controls.Find(idAlumno, false)[0] as Label).BackColor = Color.WhiteSmoke;
            (flPanelTitulos.Controls.Find(idTarea, false)[0] as Label).BackColor = Color.WhiteSmoke;
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

            int tareas, examenes, proyectos;
            dbConection.getPorcentages(idMateria, out tareas, out examenes, out proyectos);

            upDnTareas.Value = tareas;
            upDnExamenes.Value = examenes;
            upDnProyectos.Value = proyectos;

            upDnTareas.AccessibleDescription = dbConection.tipoTarea.ToString();
            upDnExamenes.AccessibleDescription = dbConection.tipoExam.ToString();
            upDnProyectos.AccessibleDescription = dbConection.tipoProy.ToString();

            upDnTareas.ValueChanged += rubroUpDn_ValueChanged;
            upDnExamenes.ValueChanged += rubroUpDn_ValueChanged;
            upDnProyectos.ValueChanged += rubroUpDn_ValueChanged;

            PersonalizacionComponentes.llenarPanelAlunos(flPanelAlumnos, alumnos);
        }

        #endregion
        
    }
}