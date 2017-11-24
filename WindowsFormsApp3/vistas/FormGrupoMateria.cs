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
        //Tareas = 0, Proyectos = 1, Examenes = 2, Calificaciones = 3;
        private int panelActivo;
        //Bandera para saber si el panel ya ha sido inicializado siguiendo la numeración de arriba
        private bool[] instancesPaneles;
        //Columa Tarea, filas Titulos
        private FlowLayoutPanel[,] flPanelEntregas;

        #region constructor

        /// <summary> muestra informacion y funciones del grupo indicado </summary>
        public FormGrupoMateria(int idMateria, int idGrupo)
        {
            InitializeComponent();

            this.idMateria = idMateria;
            flPanelEntregas = new FlowLayoutPanel[2,4];

            this.idGrupo = idGrupo;
            alumnos = dbConection.alumnosGrupo(idGrupo);

            personalizarVentana(idMateria, idGrupo);

        }
        
#endregion

#region eventos Módulos Click

        /// <summary> muestra la ventana tareas </summary>
        private void btnTareas_Click(object sender, EventArgs e)
        {
            desactivarPanelActivo(0);
            btnAgregar.Visible = true;
            panelActivo = 0;
            grpBxModulo.Text = "Tareas";

            if( instancesPaneles[0] )
            {
                //Si ya se instanció mostrará ese panel de tareas y el de los títulos de las tareas
                flPanelEntregas[0, 0].Show();
                flPanelEntregas[1, 0].Show();
            }
            else
            {
                instancesPaneles[ 0 ]= true;
                flPanelEntregas[0,0] = PersonalizacionComponentes.hacerContenedorEntregas("flPanelTareas");
                flPanelEntregas[1, 0] = PersonalizacionComponentes.hacerContenedorTitulosEntregas("flPanelTitulosTareas");

                grpBxModulo.AccessibleDescription = dbConection.tipoTarea.ToString();

                tlPanel.Controls.Add(flPanelEntregas[0, 0], 1, 1);
                tlPanel.Controls.Add(flPanelEntregas[1, 0], 1, 0);

                flPanelEntregas[0, 0].Show();
                flPanelEntregas[1, 0].Show();

                Tarea[] listTareas = dbConection.getTareas(idMateria);

                foreach (Tarea tarea in listTareas)
                {
                    tiltLabel nombreTarea = new tiltLabel(tarea.nombre);
                    nombreTarea.Name = tarea.id.ToString();

                    MenuItem[] menu = {
                        new MenuItem("Borrar", borrarEntrega_Click)
                    };
                    menu[0].Name = tarea.id.ToString();

                    nombreTarea.ContextMenu = new ContextMenu(menu);
                    //Se van agregando los títulos de las entregas al contenedor de titulos de tareas
                    flPanelEntregas[1, 0].Controls.Add(nombreTarea);
                }

                foreach (Alumno alumno in alumnos)
                {
                    FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelTareas(alumno.getId(), listTareas);
                    entregas.BorderStyle = BorderStyle.FixedSingle;
                    flPanelEntregas[0, 0].Controls.Add(entregas);
                }
            }
        }

        //Tareas = 0, Proyectos = 1, Examenes = 2, Calificaciones = 3;
        private void desactivarPanelActivo(int panelActivar )
        {
            if( panelActivar != panelActivo )
            {
                //Para hacer invisble el actual, el otro panel se debe mostrar después de llamar a este método
                switch (panelActivo)
                {
                    case 0:
                        flPanelEntregas[0, 0].Hide();
                        flPanelEntregas[1, 0].Hide();
                        break;
                    case 1:
                        flPanelEntregas[0, 1].Hide();
                        flPanelEntregas[1, 1].Hide();
                        break;
                    case 2:
                        flPanelEntregas[0, 2].Hide();
                        flPanelEntregas[1, 2].Hide();
                        break;
                    case 3:
                        flPanelEntregas[0, 3].Hide();
                        flPanelEntregas[1, 3].Hide();
                        break;
                }
            }
        }

        /// <summary> muestra la ventana proyectos </summary>
        private void btnProyectos_Click(object sender, EventArgs e)
        {
            desactivarPanelActivo(1);
            panelActivo = 1;
            grpBxModulo.Text = "Proyectos";
            btnAgregar.Visible = true;

            if( instancesPaneles[1] )
            {
                flPanelEntregas[0, 1].Show();
                flPanelEntregas[1, 1].Show();
            }
            else
            {
                instancesPaneles[1] = true;
                flPanelEntregas[0, 1] = PersonalizacionComponentes.hacerContenedorEntregas("flPanelProyectos");
                flPanelEntregas[1, 1] = PersonalizacionComponentes.hacerContenedorTitulosEntregas("flPanelTitulosProyectos");

                grpBxModulo.AccessibleDescription = dbConection.tipoProy.ToString();

                tlPanel.Controls.Add(flPanelEntregas[0, 1], 1, 1);
                tlPanel.Controls.Add(flPanelEntregas[1, 1], 1, 0);

                flPanelEntregas[0, 1].Show();
                flPanelEntregas[1, 1].Show();

                Proyecto[] listProyectos = dbConection.getProyectos(idMateria);

                foreach (Proyecto proyecto in listProyectos)
                {
                    tiltLabel nombreEntrega = new tiltLabel(proyecto.nombre);
                    nombreEntrega.Name = proyecto.id.ToString();

                    //Sólo aquí cuando se van a mostrar NumericUpDown tenemos que dejar más espacio entre uno y otro porque sino se ve todo amontonado
                    nombreEntrega.Margin = new Padding(0, 0, 10, 0);

                    MenuItem[] menu = { new MenuItem("Borrar", borrarEntrega_Click) };
                    menu[0].Name = proyecto.id.ToString();

                    nombreEntrega.ContextMenu = new ContextMenu(menu);

                    flPanelEntregas[1, 1].Controls.Add(nombreEntrega);
                }

                foreach (Alumno alumno in alumnos)
                {
                    FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelProyectos(alumno.getId(), listProyectos);
                    entregas.Margin = new Padding(0, 0, 0, 3);
                    flPanelEntregas[0, 1].Controls.Add(entregas);
                }
            }
        }

        /// <summary> muestra la ventana examenes </summary>
        private void btnExamenes_Click(object sender, EventArgs e)
        {
            desactivarPanelActivo(2);
            btnAgregar.Visible = true;
            grpBxModulo.Text = "Exámenes";
            panelActivo = 2;

            if (instancesPaneles[2])
            {
                //Si ya se instanció mostrará ese panel de tareas y el de los títulos de las tareas
                flPanelEntregas[0, 2].Show();
                flPanelEntregas[1, 2].Show();
            }
            else
            {
                //Le dice que ya se instanció para que la siguiente vez que se entre en est opción no cargue todo el panel de nuevo
                instancesPaneles[2] = true;
                flPanelEntregas[0, 2] = PersonalizacionComponentes.hacerContenedorEntregas("flPanelExamenes");
                flPanelEntregas[1, 2] = PersonalizacionComponentes.hacerContenedorTitulosEntregas("flPanelTitulosExamenes");
                
                grpBxModulo.AccessibleDescription = dbConection.tipoExam.ToString();

                tlPanel.Controls.Add(flPanelEntregas[0, 2], 1, 1);
                tlPanel.Controls.Add(flPanelEntregas[1, 2], 1, 0);

                flPanelEntregas[0, 2].Show();
                flPanelEntregas[1, 2].Show();


                Examen[] listExamenes = dbConection.getExamenes(idMateria);

                foreach (Examen exam in listExamenes)
                {
                    tiltLabel nombreEntrega = new tiltLabel(exam.nombre);
                    nombreEntrega.Name = exam.id.ToString();

                    //Sólo aquí cuando se van a mostrar NumericUpDown tenemos que dejar más espacio entre uno y otro porque sino se ve todo amontonado
                    nombreEntrega.Margin = new Padding(0, 0, 10, 0);

                    MenuItem[] menu = { new MenuItem("Borrar", borrarEntrega_Click) };
                    menu[0].Name = exam.id.ToString();

                    nombreEntrega.ContextMenu = new ContextMenu(menu);
                    flPanelEntregas[1, 2].Controls.Add(nombreEntrega);
                }

                foreach (Alumno alumno in alumnos)
                {
                    FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelExamenes(alumno.getId(), listExamenes);
                    entregas.Margin = new Padding(0, 0, 0, 3);
                    flPanelEntregas[0, 2].Controls.Add(entregas);
                }
            }            
        }

        /// <summary> muestra la ventana tareas </summary>
        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            desactivarPanelActivo(3);
            btnAgregar.Visible = true;
            grpBxModulo.Text = "Calificaciones";
            panelActivo = 3;

            if (instancesPaneles[3])
            {
                //Si ya se instanció mostrará ese panel de calificaciones y el de los títulos de las calificaciones
                flPanelEntregas[0, 3].Show();
                flPanelEntregas[1, 3].Show();
            }
            else
            {
                Console.WriteLine("Dentro del panel de calificaciones");
                //PersonalizacionComponentes.decorarPanelCalificaciones(alumnos, idMateria, ref flPanelTitulos, ref flPanelTareas);
            }
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
            //El primer panel que se cargará para ser utilizado es el de tareas(1)
            panelActivo = 0;
            instancesPaneles = new bool[4] { false, false, false, false };

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
            //(flPanelTitulos.Controls.Find(idTarea, false)[0] as tiltLabel).BackColor = Color.Silver;
        }

        /// <summary>Cuando el puntero salga de algún TareaButton regresará a su color ordinario el nombre y la fecha de la asistencia correspondiente</summary>
        public void entregaLeaveSelected(string idAlumno, string idTarea)
        {
            (flPanelAlumnos.Controls.Find(idAlumno, false)[0] as Label).BackColor = Color.WhiteSmoke;
            //(flPanelTitulos.Controls.Find(idTarea, false)[0] as Label).BackColor = Color.WhiteSmoke;
        }

        #endregion

        #region metodos

        /// <summary>Pone la información del grupo en las etiquetas, el valor en los numeric de rubros y llena la lista de nombres</summary>
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