using System;
using System.Collections.Generic;
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
        List<Alumno> alumnos;
        //Tareas = 0, Proyectos = 1, Examenes = 2, Calificaciones = 3;
        private enum Entregas { TAREAS = 0, PROYECTOS, EXAMENES, CALIFICACIONES }
        private Entregas panelActivo;
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
            flPanelEntregas = new FlowLayoutPanel[ 2, 4 ];

            this.idGrupo = idGrupo;
            alumnos = dbConection.alumnosGrupo(idGrupo);

            personalizarVentana(idMateria, idGrupo);
        }
        
#endregion

#region eventos Módulos Click

        /// <summary> muestra la ventana tareas </summary>
        private void btnTareas_Click(object sender, EventArgs e)
        {
            desactivarPanelActivo( (int)Entregas.TAREAS );
            btnAgregar.Visible = true;
            panelActivo = Entregas.TAREAS;
            grpBxModulo.Text = "Tareas";

            if( instancesPaneles[ (int)Entregas.TAREAS ] )
            {
                //Si ya se instanció mostrará ese panel de tareas y el de los títulos de las tareas
                //Las filas representan los títulos de ese panel y siempre van en la fila 1
                flPanelEntregas[0, (int)Entregas.TAREAS ].Show();
                flPanelEntregas[1, (int)Entregas.TAREAS].Show();
            }
            else
            {
                instancesPaneles[ (int)Entregas.TAREAS ] = true;
                flPanelEntregas[ 0, (int)Entregas.TAREAS ] = PersonalizacionComponentes.hacerContenedorEntregas("flPanelTareas");
                flPanelEntregas[ 1, (int)Entregas.TAREAS ] = PersonalizacionComponentes.hacerContenedorTitulosEntregas("flPanelTitulosTareas");

                grpBxModulo.AccessibleDescription = dbConection.tipoTarea.ToString();

                //Se creó el panel de tareas y se agrega al contenedor en la columna 1, los títulos en la fila 0 y los entregables en la fila 1
                tlPanel.Controls.Add(flPanelEntregas[ 0, (int)Entregas.TAREAS ], 1, 1);
                tlPanel.Controls.Add(flPanelEntregas[ 1, (int)Entregas.TAREAS ], 1, 0);

                flPanelEntregas[0, (int)Entregas.TAREAS].Show();
                flPanelEntregas[1, (int)Entregas.TAREAS].Show();

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
                    flPanelEntregas[ 1, (int)Entregas.TAREAS ].Controls.Add(nombreTarea);
                }

                
                foreach (Alumno alumno in alumnos)
                {
                    FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelTareas(alumno.getId(), listTareas);
                    flPanelEntregas[ 0, (int)Entregas.TAREAS ].Controls.Add(entregas);
                }
            }
        }

        /// <summary> muestra la ventana proyectos </summary>
        private void btnProyectos_Click(object sender, EventArgs e)
        {
            desactivarPanelActivo( (int)Entregas.PROYECTOS );
            panelActivo = Entregas.PROYECTOS;
            grpBxModulo.Text = "Proyectos";
            btnAgregar.Visible = true;

            if( instancesPaneles[(int)Entregas.PROYECTOS] )
            {
                flPanelEntregas[ 0, (int)Entregas.PROYECTOS ].Show();
                flPanelEntregas[ 1, (int)Entregas.PROYECTOS ].Show();
            }
            else
            {
                instancesPaneles[(int)Entregas.PROYECTOS ] = true;
                flPanelEntregas[ 0, (int)Entregas.PROYECTOS ] = PersonalizacionComponentes.hacerContenedorEntregas("flPanelProyectos");
                flPanelEntregas[ 1, (int)Entregas.PROYECTOS ] = PersonalizacionComponentes.hacerContenedorTitulosEntregas("flPanelTitulosProyectos");

                grpBxModulo.AccessibleDescription = dbConection.tipoProy.ToString();

                tlPanel.Controls.Add(flPanelEntregas[ 0, (int)Entregas.PROYECTOS ], 1, 1);
                tlPanel.Controls.Add(flPanelEntregas[ 1, (int)Entregas.PROYECTOS ], 1, 0);

                flPanelEntregas[0, (int)Entregas.PROYECTOS ].Show();
                flPanelEntregas[1, (int)Entregas.PROYECTOS ].Show();

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

                    flPanelEntregas[1, (int)Entregas.PROYECTOS ].Controls.Add(nombreEntrega);
                }

                foreach (Alumno alumno in alumnos)
                {
                    FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelProyectos(alumno.getId(), listProyectos);
                    entregas.Margin = new Padding(0, 0, 0, 3);
                    flPanelEntregas[ 0, (int)Entregas.PROYECTOS ].Controls.Add(entregas);
                }
            }
        }

        /// <summary> muestra la ventana examenes </summary>
        private void btnExamenes_Click(object sender, EventArgs e)
        {
            desactivarPanelActivo((int)Entregas.EXAMENES );
            btnAgregar.Visible = true;
            grpBxModulo.Text = "Exámenes";
            panelActivo = Entregas.EXAMENES;

            if (instancesPaneles[(int)Entregas.EXAMENES ])
            {
                //Si ya se instanció mostrará ese panel de tareas y el de los títulos de las tareas
                flPanelEntregas[ 0, (int)Entregas.EXAMENES ].Show();
                flPanelEntregas[ 1, (int)Entregas.EXAMENES ].Show();
            }
            else
            {
                //Le dice que ya se instanció para que la siguiente vez que se entre en est opción no cargue todo el panel de nuevo
                instancesPaneles[(int)Entregas.EXAMENES ] = true;
                flPanelEntregas[ 0, (int)Entregas.EXAMENES ] = PersonalizacionComponentes.hacerContenedorEntregas("flPanelExamenes");
                flPanelEntregas[ 1, (int)Entregas.EXAMENES ] = PersonalizacionComponentes.hacerContenedorTitulosEntregas("flPanelTitulosExamenes");
                
                grpBxModulo.AccessibleDescription = dbConection.tipoExam.ToString();

                tlPanel.Controls.Add(flPanelEntregas[ 0, (int)Entregas.EXAMENES ], 1, 1);
                tlPanel.Controls.Add(flPanelEntregas[ 1, (int)Entregas.EXAMENES ], 1, 0);

                flPanelEntregas[ 0, (int)Entregas.EXAMENES ].Show();
                flPanelEntregas[ 1, (int)Entregas.EXAMENES ].Show();


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
                    flPanelEntregas[ 1, (int)Entregas.EXAMENES ].Controls.Add(nombreEntrega);
                }

                foreach (Alumno alumno in alumnos)
                {
                    FlowLayoutPanel entregas = PersonalizacionComponentes.hacerPanelExamenes(alumno.getId(), listExamenes);
                    entregas.Margin = new Padding(0, 0, 0, 3);
                    flPanelEntregas[ 0, (int)Entregas.EXAMENES ].Controls.Add(entregas);
                }
            }            
        }

        /// <summary> muestra la ventana tareas </summary>
        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            desactivarPanelActivo((int)Entregas.CALIFICACIONES );
            btnAgregar.Visible = true;
            grpBxModulo.Text = "Calificaciones";
            panelActivo = Entregas.CALIFICACIONES;

            if (instancesPaneles[(int)Entregas.CALIFICACIONES ])
            {
                //Si ya se instanció mostrará ese panel de calificaciones y el de los títulos de las calificaciones
                flPanelEntregas[0, (int)Entregas.CALIFICACIONES ].Show();
                flPanelEntregas[1, (int)Entregas.CALIFICACIONES ].Show();
            }
            else
            {
                instancesPaneles[ (int)Entregas.CALIFICACIONES ] = true;
                flPanelEntregas[0, (int)Entregas.CALIFICACIONES] = PersonalizacionComponentes.hacerContenedorEntregas("flPanelCalificaciones");
                flPanelEntregas[1, (int)Entregas.CALIFICACIONES] = PersonalizacionComponentes.hacerContenedorTitulosEntregas("flPanelTitulosCalificaciones");

                tlPanel.Controls.Add(flPanelEntregas[0, (int)Entregas.CALIFICACIONES], 1, 1);
                tlPanel.Controls.Add(flPanelEntregas[1, (int)Entregas.CALIFICACIONES], 1, 0);

                flPanelEntregas[0, (int)Entregas.CALIFICACIONES].Show();
                flPanelEntregas[1, (int)Entregas.CALIFICACIONES].Show();
                //PersonalizacionComponentes.decorarPanelCalificaciones(alumnos, idMateria, ref flPanelTitulos, ref flPanelTareas);
            }
        }

        #endregion

        #region Otros eventos

        /// <summary>Cuando se presiona la opción contextual de las entregas para eliminar entregas</summary>
        private void borrarEntrega_Click(object sender, EventArgs e)
        {
            //Se saca el id de la tarea, examen  o proyecto del nombre del componente que activa este método
            string idTareaEliminar = (sender as MenuItem).Name;

            if( MessageBox.Show("¿Seguro que deseas eliminar esta entrega, al hacerlo se eliminarán los registros de los alumnos relacionados a ella?",
                "Eliminar entrega", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                if( grpBxModulo.Text == "Tareas" )
                {
                    //Se elimina del panel de fechas el dateLabel
                    flPanelEntregas[ 1, (int)Entregas.TAREAS ].Controls.RemoveByKey( idTareaEliminar );
                    
                    System.Collections.IEnumerator tareasAlumnos = flPanelEntregas[ 0, (int)Entregas.TAREAS ].Controls.GetEnumerator();

                    while (tareasAlumnos.MoveNext())
                    {
                        ((FlowLayoutPanel)tareasAlumnos.Current).Controls.RemoveByKey( idTareaEliminar );
                        ((FlowLayoutPanel)tareasAlumnos.Current).Size = ((FlowLayoutPanel)tareasAlumnos.Current).PreferredSize;
                    }
                }
                else if( grpBxModulo.Text == "Proyectos" )
                {
                    //Se elimina del panel de fechas el dateLabel
                    flPanelEntregas[1, (int)Entregas.PROYECTOS].Controls.RemoveByKey(idTareaEliminar);

                    System.Collections.IEnumerator proyectosAlumnos = flPanelEntregas[0, (int)Entregas.PROYECTOS].Controls.GetEnumerator();

                    while (proyectosAlumnos.MoveNext())
                    {
                        ((FlowLayoutPanel)proyectosAlumnos.Current).Controls.RemoveByKey(idTareaEliminar);
                        ((FlowLayoutPanel)proyectosAlumnos.Current).Size = ((FlowLayoutPanel)proyectosAlumnos.Current).PreferredSize;
                    }
                }
                else //Exámenes, porque de calificaciones no se podrá eliminar nada
                {
                    //Se elimina del panel de fechas el dateLabel
                    flPanelEntregas[ 1, (int)Entregas.EXAMENES ].Controls.RemoveByKey(idTareaEliminar);

                    System.Collections.IEnumerator examenesAlumnos = flPanelEntregas[0, (int)Entregas.EXAMENES].Controls.GetEnumerator();

                    while (examenesAlumnos.MoveNext())
                    {
                        ((FlowLayoutPanel)examenesAlumnos.Current).Controls.RemoveByKey(idTareaEliminar);
                        ((FlowLayoutPanel)examenesAlumnos.Current).Size = ((FlowLayoutPanel)examenesAlumnos.Current).PreferredSize;
                    }
                }
                //Lo elimina de la base de datos
                dbConection.eliminarEntrega(Convert.ToInt32( idTareaEliminar ) );
            }

        }

        /// <summary> cargar menu tareas </summary>
        private void FormGrupoMateria_Load(object sender, EventArgs e)
        {
            //El primer panel que se cargará para ser utilizado es el de tareas(0) por lo que es panel que se establece primero como activo
            panelActivo = Entregas.TAREAS;
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
            //La siguiente línea estaba mandando tipos diferentes, por eso la cambié
            //int tipo = int.Parse(grpBxModulo.AccessibleDescription);
            int tipo;
            if (grpBxModulo.Text == "Tareas")
                tipo = 1;
            else if (grpBxModulo.Text == "Proyectos")
                tipo = 3;
            else
                tipo = 2;

            FormAgregarEntregable newEntregable = new FormAgregarEntregable(tipo, idMateria);
            newEntregable.ShowDialog(this);   
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

        /// <summary>Recibe como parámetro el número del panel que se quiere activar, comprueba que no esté ya activo, de lo contrario cierra el que está como activo</summary>
        //Tareas = 0, Proyectos = 1, Examenes = 2, Calificaciones = 3
        private void desactivarPanelActivo(int panelActivar)
        {
            if (panelActivar != (int)panelActivo)
            {
                //Para hacer invisble el actual, el otro panel se debe mostrar después de llamar a este método
                switch ((int)panelActivo)
                {
                    case 0:
                        flPanelEntregas[0, (int)Entregas.TAREAS].Hide();
                        flPanelEntregas[1, (int)Entregas.TAREAS].Hide();
                        break;
                    case 1:
                        flPanelEntregas[0, (int)Entregas.PROYECTOS].Hide();
                        flPanelEntregas[1, (int)Entregas.PROYECTOS].Hide();
                        break;
                    case 2:
                        flPanelEntregas[0, (int)Entregas.EXAMENES].Hide();
                        flPanelEntregas[1, (int)Entregas.EXAMENES].Hide();
                        break;
                    case 3:
                        flPanelEntregas[0, (int)Entregas.CALIFICACIONES].Hide();
                        flPanelEntregas[1, (int)Entregas.CALIFICACIONES].Hide();
                        break;
                }
            }
        }

        /// <summary>Recibe de FormAgregarEntrega la información de la entrega que se acaba de registrar en la base de datos</summary>
        internal void recibirIdEntregaNueva(string nombre, int idEntrega, int tipo)
        {
            if( grpBxModulo.Text == "Tareas" )
            {
                Tarea tarea = new Tarea(nombre, idEntrega);
                tiltLabel nombreTarea = new tiltLabel(tarea.nombre);
                nombreTarea.Name = tarea.id.ToString();

                MenuItem[] menu = {
                        new MenuItem("Borrar", borrarEntrega_Click)
                    };
                menu[0].Name = tarea.id.ToString();

                nombreTarea.ContextMenu = new ContextMenu(menu);
                //Se van agregando los títulos de las entregas al contenedor de titulos de tareas
                flPanelEntregas[1, (int)Entregas.TAREAS].Controls.Add(nombreTarea);

                System.Collections.IEnumerator alumnosPanels = flPanelEntregas[0, (int)Entregas.TAREAS].Controls.GetEnumerator();

                while( alumnosPanels.MoveNext() )
                {
                    ((FlowLayoutPanel)alumnosPanels.Current).Controls.Add(new TareaButton( tarea.id, true ) );
                    ((FlowLayoutPanel)alumnosPanels.Current).Size = ((FlowLayoutPanel)alumnosPanels.Current).PreferredSize;
                }
            }
            else if ( grpBxModulo.Text == "Proyectos")
            {
                Proyecto proyecto = new Proyecto(nombre, idEntrega);
                tiltLabel nombreProyecto = new tiltLabel(proyecto.nombre);
                nombreProyecto.Name = proyecto.id.ToString();

                MenuItem[] menu = {
                        new MenuItem("Borrar", borrarEntrega_Click)
                    };
                menu[0].Name = proyecto.id.ToString();

                nombreProyecto.ContextMenu = new ContextMenu(menu);
                //Se van agregando los títulos de las entregas al contenedor de titulos de tareas
                flPanelEntregas[1, (int)Entregas.PROYECTOS ].Controls.Add(nombreProyecto);

                System.Collections.IEnumerator alumnosPanels = flPanelEntregas[0, (int)Entregas.PROYECTOS].Controls.GetEnumerator();

                while (alumnosPanels.MoveNext())
                {
                    ((FlowLayoutPanel)alumnosPanels.Current).Controls.Add(new NumUpDownCalificacion( proyecto.id, (decimal)10 ));
                    ((FlowLayoutPanel)alumnosPanels.Current).Size = ((FlowLayoutPanel)alumnosPanels.Current).PreferredSize;
                }
            }
            else
            {
                Proyecto examen = new Proyecto(nombre, idEntrega);
                tiltLabel nombreExamen = new tiltLabel(examen.nombre);
                nombreExamen.Name = examen.id.ToString();

                MenuItem[] menu = {
                        new MenuItem("Borrar", borrarEntrega_Click)
                    };
                menu[0].Name = examen.id.ToString();

                nombreExamen.ContextMenu = new ContextMenu(menu);
                //Se van agregando los títulos de las entregas al contenedor de titulos de tareas
                flPanelEntregas[1, (int)Entregas.EXAMENES].Controls.Add(nombreExamen);

                System.Collections.IEnumerator alumnosPanels = flPanelEntregas[0, (int)Entregas.EXAMENES].Controls.GetEnumerator();

                while (alumnosPanels.MoveNext())
                {
                    ((FlowLayoutPanel)alumnosPanels.Current).Controls.Add(new NumUpDownCalificacion(examen.id, (decimal)10));
                    ((FlowLayoutPanel)alumnosPanels.Current).Size = ((FlowLayoutPanel)alumnosPanels.Current).PreferredSize;
                }
            }

            foreach( Alumno alumno in alumnos )
            {
                dbConection.agregarEntregas(alumno.getId(), tipo, idEntrega );
            }
        }

        #endregion

    }
}