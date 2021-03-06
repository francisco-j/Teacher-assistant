﻿using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.vistas;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.componentes_visuales;
using System.Collections.Generic;

/// <summary>
/// clase encargada de guardar los métodos que usaremos para personalizar componentes como:
/// los botones, labels y demás componenetes que estaremos generando en tiempo de ejecución
/// todos los metodos son static por que la clase no se instancia
/// </summary>
namespace WindowsFormsApp3
{
    abstract class PersonalizacionComponentes
    {
        private static Color[] coloresBotones = new Color[10] { Color.FromArgb(114, 112, 202), Color.FromArgb(234, 136, 48), Color.FromArgb(234, 66, 48), Color.FromArgb(30, 145, 133), Color.FromArgb(91, 211, 72), Color.FromArgb(194, 40, 116), Color.FromArgb(255, 235, 87), Color.FromArgb(56, 175, 203), Color.FromArgb(32, 126, 144), Color.FromArgb(223, 46, 70) };
        private static Font miFuenteGrupo = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
        private static Font miFuenteMateria = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
        private static Font miFuenteInfo = new Font("Microsoft Sans Serif", 16);
        private static Font miFuentelblAlumno = new Font("Microsoft Sans Serif", 16);
        private static Font miFuenteUpDnCalif = new Font("Microsoft Sans Serif", 9);


#region llenado de paneneles de entregas/calif/asist


        /// <summary> panel con dateCheckBox por cada di, del alumno indicado </summary>
        internal static FlowLayoutPanel hacerPanelAsistencias(int idAlumno, DiaClase[] diasClase)
        {
            //Las fechas se llenan antes de llamar este método

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Name = idAlumno.ToString();
            panel.Margin = new Padding(0);

            DateTime[] faltas = dbConection.getFaltas(idAlumno);

            foreach (DiaClase dia in diasClase)
            {
                bool asistencia = !faltas.Contains(dia.dia);
                panel.Controls.Add(new DateButton(dia, asistencia));
            }

            //Importante dejar esta línea
            panel.Size = panel.PreferredSize;
            return panel;
        }

        /// <summary> panel con checkbox por cada tarea del alulmno indicado </summary>
        internal static FlowLayoutPanel hacerPanelTareas(int idAlumno, Tarea[] listTareas, int materia)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0);
            panel.Name = idAlumno.ToString();

            int[] entregas = dbConection.getEntregasTareas(idAlumno, materia);

            foreach (Tarea tarea in listTareas)
            {
                bool entregada = entregas.Contains(tarea.id);
                if( entregada )
                    panel.Controls.Add(new TareaButton(tarea.id, true));
                else
                    panel.Controls.Add(new TareaButton(tarea.id, false));
            }
            panel.Size = panel.PreferredSize;

            return panel;
        }

        /// <summary> panel con numUpDn por cada examen del alumno idicado </summary>
        internal static FlowLayoutPanel hacerPanelExamenes(int idAlumno, Examen[] listExamenes)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0);
            panel.Name = idAlumno.ToString();
            int[] calificaciones = dbConection.getCalifExam(idAlumno, listExamenes);
            int indiceCalif = 0;
            foreach (Examen examActual in listExamenes)
            {
                //Console.WriteLine("Calificación alumno examen: " + calificaciones[indiceCalif] + "  Examen id: " + listExamenes[indiceCalif].id );
                CalificacionLabel labelCalificacion = new CalificacionLabel(examActual.id, calificaciones[indiceCalif], 2);
                panel.Controls.Add(labelCalificacion);

                indiceCalif++;
            }
            panel.Size = panel.PreferredSize;

            return panel;
        }

        /// <summary> panel con numUpDn por cada proyecto del alumno idicado </summary>
        internal static FlowLayoutPanel hacerPanelProyectos(int idAlumno, Proyecto[] listProyectos)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0);
            panel.Name = idAlumno.ToString();

            int[] calificaciones = dbConection.getCalifProy(idAlumno, listProyectos);
            int indiceCalif = 0;
            foreach (Proyecto proyActual in listProyectos)
            {
                Console.WriteLine("Calificaciones: "+calificaciones[indiceCalif]);
                CalificacionLabel lblCalificacion = new CalificacionLabel(proyActual.id, calificaciones[indiceCalif], 1);
                panel.Controls.Add(lblCalificacion);

                indiceCalif++;
            }
            panel.Size = panel.PreferredSize;

            return panel;
        }

        //Ya hay otro método que lo hace
        // <summary> llena las calificaciones de los lumnos por rubro </summary>
        /*internal static void hacerPanelCalif(int idAlumno, int[] tiposTareas)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0);

            int[] calificaciones = dbConection.getCalifRubro( idAlumno, tiposTareas);

            foreach (int calif in calificaciones)
            {
                Label lab = new Label();
                lab.Text = calif.ToString();
                panel.Controls.Add(lab);
            }
            panel.Size = panel.PreferredSize;   
        }*/


        #endregion


        #region metodos

        /// <summary> debuelbe el contenedor con la informacion del grupo indicado </summary>
        public static FlowLayoutPanel hacerConternedorGrupo(Grupo grupo, int color)
        {
            //componentes (declarar todo)
            Label info = new Label();
            Button boton = new Button();
            FlowLayoutPanel contenedor = new FlowLayoutPanel();
            contenedor.Name = grupo.getId().ToString();

            //boton (informacion y estilo)
            boton.Text = grupo.ToString();
            boton.Name = grupo.getId() + "";

            boton.Font = miFuenteGrupo;
            boton.Size = new Size(150, 115);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = coloresBotones[color];

            //label (estilo, tamano e info)
            info.Font = miFuenteInfo;
            info.Name = "Label" + grupo.getId();
            info.Size = new Size(231, 52);

            string nameGroup = grupo.getEscuela();
            if (nameGroup.Length > 18)
            {
                ToolTip message = new ToolTip();
                message.SetToolTip(info, nameGroup);

                nameGroup = nameGroup.Substring(0, 16) + "...";
            }
            info.Text = nameGroup + "\n" + dbConection.numeroAlumnosEn(grupo.getId()) + " alumnos";

            //contenedor (tamano)
            contenedor.Size = new Size(393, 121);
            contenedor.Margin = new Padding(0, 0, 0, 30);

            //contenedor(llenar)
            contenedor.Controls.Add(boton);
            contenedor.Controls.Add(info);

            //menu contextual del boton(click derecho)
            MenuItem[] mi = {
                    new MenuItem("Editar",editarG_Click),
                    new MenuItem("Borrar",borrarG_Click),
                };
            mi[0].Name = grupo.getId().ToString();
            mi[1].Name = grupo.getId().ToString();

            boton.ContextMenu = new ContextMenu(mi);

            //eventos
            boton.Click += new EventHandler(grupo_Click);

            return contenedor;
        }

        public static FlowLayoutPanel hacerContenedorEntregas(string name)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Name = name;
            panel.AutoScroll = true;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.Size = new Size(470, 336);
            panel.BackColor = Color.WhiteSmoke;
            panel.TabIndex = 1;
            panel.WrapContents = false;

            return panel;
        }

        public static FlowLayoutPanel hacerContenedorTitulosEntregas(string name)
        {
            FlowLayoutPanel flPanelTitulos = new FlowLayoutPanel();
            flPanelTitulos.AutoScroll = true;
            flPanelTitulos.Location = new Point(336, 3);
            flPanelTitulos.Name = name;
            flPanelTitulos.Size = new Size(455, 71);
            flPanelTitulos.TabIndex = 0;
            flPanelTitulos.WrapContents = false;

            return flPanelTitulos;
        }

        internal static void decorarPanelesCalificaciones(List<Alumno> alumnos, int idMateria, decimal valorTareas, decimal valorProyectos, decimal valorExa, ref FlowLayoutPanel panelCalificaciones, FormGrupoMateria padre)
        {
            int tareasTotales = dbConection.getNumeroEntregablesTotales(idMateria, 1);
            //Si no se tiene ninguna tarea no podemos dividir entre 0
            if (tareasTotales == 0)
                tareasTotales++;
            //Columas: Tareas, proyectos, exámenes y promedio
            //Filas: Una por cada alumno del grupo
            decimal[,] matrizCalif = new decimal[alumnos.Count, 4];

            int fila = 0;
            foreach( Alumno alumno in alumnos )
            {
                matrizCalif[fila, 0] = (dbConection.getNumeroTareas(alumno.getId(), idMateria) * valorTareas ) / tareasTotales;
                matrizCalif[fila, 1] = (dbConection.getPromCalifProyectosOExam(alumno.getId(), idMateria, 3) * valorProyectos);
                matrizCalif[fila, 2] = (dbConection.getPromCalifProyectosOExam(alumno.getId(), idMateria, 2) * valorExa);
                matrizCalif[fila, 3] = matrizCalif[fila, 0] + matrizCalif[fila, 1] + matrizCalif[fila, 2];
                /*Control, para verificar que está bien
                 * Console.WriteLine("Promedio: " + matrizCalif[fila, 3]);
                Console.WriteLine("tareas: " + matrizCalif[fila, 0]);
                Console.WriteLine("proyectos: " + matrizCalif[fila, 1]);
                Console.WriteLine("exámenes: " + matrizCalif[fila, 2]);*/

                FlowLayoutPanel panelCalifAlum = new FlowLayoutPanel();
                panelCalifAlum.Margin = new Padding(0);
                panelCalifAlum.Name = alumno.getId().ToString();
                
                panelCalifAlum.Controls.Add( getLabelCalificacion(matrizCalif[fila, 0], "Tareas", padre ) );

                panelCalifAlum.Controls.Add(getLabelCalificacion(matrizCalif[fila, 1], "Proyectos", padre));

                panelCalifAlum.Controls.Add(getLabelCalificacion(matrizCalif[fila, 2], "Exámenes", padre));

                Label lblPromedio = getLabelCalificacion(matrizCalif[fila, 3], "Promedio", padre);
                if (matrizCalif[fila, 3] < 8)
                    lblPromedio.ForeColor = Color.Red;
                panelCalifAlum.Controls.Add( lblPromedio );

                panelCalifAlum.Size = panelCalifAlum.PreferredSize;

                panelCalificaciones.Controls.Add( panelCalifAlum );

                fila++;
            }
        }

        public static void llenarPanelCalificacionesBusqueda( ref FlowLayoutPanel panel, decimal[,] matrizCalif, int idAlumno, List<Materia> materias, decimal[,] porcentajeCalificaciones, FormAlumno padre )
        {
            int fila = 0;
            foreach( Materia materia in materias )
            {
                FlowLayoutPanel panelCalifAlum = new FlowLayoutPanel();
                panelCalifAlum.Margin = new Padding(0);
                panelCalifAlum.Name = materia.getId().ToString();
                
                panelCalifAlum.Controls.Add(getLabelCalificacion(matrizCalif[fila, 0], idAlumno,"Tareas" ,padre, porcentajeCalificaciones[fila, 0]));

                panelCalifAlum.Controls.Add(getLabelCalificacion(matrizCalif[fila, 1], idAlumno, "Proyectos", padre, porcentajeCalificaciones[fila, 1]));

                panelCalifAlum.Controls.Add(getLabelCalificacion(matrizCalif[fila, 2], idAlumno, "Examenes", padre, porcentajeCalificaciones[fila, 2]));

                Label lblPromedio = getLabelCalificacion(matrizCalif[fila, 3], idAlumno, "Promedio", padre, 0, true);
                if (matrizCalif[fila, 3] < 8)
                    lblPromedio.ForeColor = Color.Red;
                panelCalifAlum.Controls.Add(lblPromedio);

                panelCalifAlum.Size = panelCalifAlum.PreferredSize;

                panel.Controls.Add(panelCalifAlum);

                fila++;
            }
        }

        //Labels de calificación para las ventanas de resumen académico al presionar doble click en un alumno
        public static Label getLabelCalificacion( decimal calificacion, int idAlumno, string nombre = "", Form padre = null, decimal porcentaje = 0, bool promedio = false)
        {
            Label lblCalif = new Label();
            lblCalif.AutoSize = false;
            lblCalif.Font = miFuentelblAlumno;
            lblCalif.Text = Decimal.Round(calificacion, 2).ToString();
            lblCalif.ForeColor = Color.FromArgb(11, 115, 115);
            lblCalif.Name = nombre;
            lblCalif.TextAlign = ContentAlignment.TopCenter;
            lblCalif.BorderStyle = BorderStyle.FixedSingle;

            if (!promedio)
            {
                ToolTip message = new ToolTip();
                message.SetToolTip(lblCalif, "Valor asignado: " + porcentaje);
            }


            lblCalif.Size = new Size(88, 27);
            lblCalif.Margin = new Padding(0);

            if( padre != null )
            {
                lblCalif.MouseEnter += (padre as FormAlumno).lblCalificacionEnter;
                lblCalif.MouseLeave += (padre as FormAlumno).lblCalificacionLeave;
            }

            return lblCalif;
        }

        //Labels de calificacion para la ventana Grupo Materia-Calificaciones
        public static Label getLabelCalificacion( decimal calificacion, string nombre, FormGrupoMateria padre )
        {
            Label lblCalif = new Label();
            lblCalif.AutoSize = false;
            lblCalif.Font = miFuentelblAlumno;
            lblCalif.Text = Decimal.Round(calificacion, 2).ToString();
            lblCalif.ForeColor = Color.FromArgb(11, 115, 115);
            lblCalif.Name = nombre;
            lblCalif.TextAlign = ContentAlignment.TopCenter;
            lblCalif.BorderStyle = BorderStyle.FixedSingle;
            
            lblCalif.Size = new Size(88, 26);
            lblCalif.Margin = new Padding(0);

            lblCalif.MouseEnter += padre.lblCalificacionEnter;
            lblCalif.MouseLeave += padre.lblCalificacionLeave;

            return lblCalif;
        }

        /// <summary> crea un panel con los DateButtons de l alumno indicado </summary>
        public static void llenarPanelAlunos(FlowLayoutPanel panel, List<Alumno> alumnos)
        {
            panel.Controls.Clear();

            foreach (Alumno alumno in alumnos.ToArray() )
            {
                Label nombre = hacerLabelAlumno(alumno);
                //El evento para el click derecho de las etiquetas se debe programar donde se manda llamar este método para poder
                //vincular el panel con los cambios y no tener que refrescar la pantalla
                panel.Controls.Add(nombre);
            }
        }

        public static Label hacerLabelAlumno(Alumno alumno)
        {
            Label nombre = new Label();
            nombre.AutoSize = true;
            nombre.Font = miFuentelblAlumno;
            nombre.Name = alumno.getId().ToString();

            string nameAlumno = alumno.nombreCompletoPA();
            if (nameAlumno.Length > 25)
            {
                ToolTip message = new ToolTip();
                message.SetToolTip(nombre, alumno.nombreCompletoPA());
                nameAlumno = nameAlumno.Substring(0, 23) + "...";
            }
            nombre.Text = nameAlumno;
            nombre.DoubleClick += labelAlumno_Click;

            return nombre;
        }

        public static void llenarPanelMateriasBusqueda(ref FlowLayoutPanel panel, List<Materia> materias)
        {
            panel.Controls.Clear();

            foreach (Materia materia in materias )
            {
                Label nombre = hacerLabelMateria(materia);
                nombre.TextAlign = ContentAlignment.TopLeft;
                nombre.Name = materia.getId().ToString();
                panel.Controls.Add(nombre);
                //nombre.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        public static Label hacerLabelMateria(Materia materia)
        {
            Label nombre = new Label();
            nombre.AutoSize = true;
            nombre.Font = miFuentelblAlumno;
            nombre.Name = materia.getId().ToString();

            string nameMateria = materia.getNombre();
            if (nameMateria.Length > 25)
            {
                ToolTip message = new ToolTip();
                message.SetToolTip(nombre, materia.getNombre());
                nameMateria = nameMateria.Substring(0, 23) + "...";
            }
            nombre.Text = nameMateria;

            return nombre;
        }

        /// <summary> decora el botón con la información de la materia indicada </summary>
        public static Button hacerBotonMateria(Materia materia, int color)
        {
            //botón
            Button boton = new Button();

            boton.Font = miFuenteMateria;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = coloresBotones[ color];

            boton.Text = materia.getNombre();
            boton.Size = new Size(172, 48);
            boton.Name = materia.getId().ToString();

            //evento
            boton.Click += new EventHandler(materia_Click);

            //menu contextual del boton(click derecho)
            MenuItem[] mi = {
                    new MenuItem("Editar",editarM_Click),
                    new MenuItem("Borrar",borrarM_Click),
                };
            mi[0].Name = "Editar" + materia.getId().ToString();
            mi[1].Name = "Borar" + materia.getId().ToString();
            
            boton.ContextMenu = new ContextMenu(mi);

            boton.Visible = true;
            return boton;
        }

#endregion

#region eventos para asignar a grupo

        /// <summary> evento para los botonesGrupo  </summary>
        private static void grupo_Click(object sender, System.EventArgs e)
        {
            int idGrupo = int.Parse((sender as Button).Name);

            int idMaestro = dbConection.getIdMaestro(idGrupo);
            Program.showListaMaterias(idGrupo, idMaestro);
            Program.listaGrupos.Hide();
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void editarG_Click(object sender, System.EventArgs e)
        {
            int idGrupo = int.Parse((sender as MenuItem).Name);
            FormAgregarGrupo modificarGrupo = new FormAgregarGrupo(dbConection.getGrupo(idGrupo));
            modificarGrupo.ShowDialog(Program.listaGrupos);

        }

        /// <summary> para menu contextual de grupo </summary>
        private static void borrarG_Click(object sender, System.EventArgs e)
        {
            int idGrupo = int.Parse((sender as MenuItem).Name);
            FormBorrarGrupo borrarG = new FormBorrarGrupo(idGrupo);
            borrarG.ShowDialog(Program.listaGrupos);
            Program.listaGrupos.mostrarLblInfo();
        }

        #endregion

        #region eventos para asignar a materia

        /// <summary> evento para los botonesMateria </summary>
        private static void materia_Click(object sender, EventArgs e)
        {
            int idMateria = int.Parse((sender as Button).Name);

            Program.showGrupoMateria(idMateria, ((frmMaterias)Program.listaMaterias).idGrupo);
            Program.listaMaterias.Hide();
        }
        
        /// <summary> para menu contextual de grupo </summary>
        private static void editarM_Click(object sender, EventArgs e)
        {
            int idMateria = int.Parse((sender as MenuItem).Name.Replace("Editar", ""));

            FormAgregarMateria modoficarMateria =new FormAgregarMateria(dbConection.getMateria(idMateria));
            modoficarMateria.ShowDialog(Program.listaMaterias);
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void borrarM_Click(object sender, EventArgs e)
        {
            int idMateria = int.Parse((sender as MenuItem).Name.Replace("Borar", ""));

            FormBorrarMateria borrarM = new FormBorrarMateria(dbConection.getMateria(idMateria));
            borrarM.ShowDialog( Program.listaMaterias );
        }

#endregion

#region eventos para asignar a lblAlumno

        /// <summary>Muestra un nuevo Form con la información del alumno presionado</summary>
        public static void labelAlumno_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Label).Name);
            Alumno infoAlumno = dbConection.getAlumno(id);

            new FormAlumno(infoAlumno);
        }

#endregion
    }
}
