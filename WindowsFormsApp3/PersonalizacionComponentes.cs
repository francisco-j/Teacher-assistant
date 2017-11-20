using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.vistas;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.componentes_visuales;

/// <summary>
/// clase encargada de guardar los métodos que usaremos para personalizar componentes como:
/// los botones, labels y demás componenetes que estaremos generando en tiempo de ejecución
/// todos los metodos son static por que la clase no se instancia
/// </summary>
namespace WindowsFormsApp3
{
    abstract class PersonalizacionComponentes
    {
        private static Color[] coloresBotones = new Color[10] { Color.FromArgb( 114, 112, 202 ), Color.FromArgb(234, 136, 48), Color.FromArgb( 234, 66, 48 ), Color.FromArgb( 30, 145, 133 ), Color.FromArgb( 91, 211, 72 ), Color.FromArgb( 194, 40, 116 ), Color.FromArgb( 255, 235, 87 ), Color.FromArgb( 56, 175, 203 ), Color.FromArgb( 32, 126, 144 ), Color.FromArgb( 223, 46, 70 ) };
        private static Font miFuenteGrupo = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
        private static Font miFuenteMateria = new Font("Microsoft Sans Serif",12 , FontStyle.Bold );
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

            foreach ( DiaClase dia in diasClase)
            {
                bool asistencia = !faltas.Contains(dia.dia);
                panel.Controls.Add(new DateButton(dia, asistencia));
            }

            //Importante dejar esta línea
            panel.Size = panel.PreferredSize;
            return panel;
        }

        /// <summary> panel con checkbox por cada tarea del alulmno indicado </summary>
        internal static FlowLayoutPanel hacerPanelTareas(int idAlumno, Tarea[] listTareas)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0);

            int[] entregas = dbConection.getEntregasTareas(idAlumno);

            foreach (Tarea tarea in listTareas)
            {
                bool entregada = entregas.Contains(tarea.id);
                panel.Controls.Add(new tareaCkBx(tarea.id, idAlumno, true));

            }
            panel.Size = panel.PreferredSize;

            return panel;
        }

        /// <summary> panel con numUpDn por cada examen del alumno idicado </summary>
        internal static FlowLayoutPanel hacerPanelExamenes(int idAlumno, Examen[] listExamenes)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0);

            int[] calificaciones = dbConection.getCalifExam(idAlumno, listExamenes);

            foreach (int calif in calificaciones)
            {
                NumericUpDown nud = new NumericUpDown();
                nud.Size = new Size(34, 20);
                nud.Font = miFuenteUpDnCalif;
                nud.Value = calif;
                panel.Controls.Add(nud);
            }
            panel.Size = panel.PreferredSize;
            
            return panel;
        }

        /// <summary> panel con numUpDn por cada proyecto del alumno idicado </summary>
        internal static FlowLayoutPanel hacerPanelProyectos(int idAlumno, Proyecto[] listProyectos)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0);

            int[] calificaciones = dbConection.getCalifProy(idAlumno, listProyectos);

            foreach (int calif in calificaciones)
            {
                NumericUpDown nud = new NumericUpDown();
                nud.Size = new Size(34, 20);
                nud.Font = miFuenteUpDnCalif;
                nud.Value = calif;
                panel.Controls.Add(nud);
            }
            panel.Size = panel.PreferredSize;

            return panel;
        }


        #endregion


        #region metodos

        /// <summary> debuelbe el contenedor con la informacion del grupo indicado </summary>
        public static FlowLayoutPanel hacerConternedorGrupo(Grupo grupo, int color)
        {
            //componentes (declarar todo)
            Label info = new Label();
            Button boton = new Button();
            FlowLayoutPanel contenedor = new FlowLayoutPanel();

            //boton (informacion y estilo)
            boton.Text = grupo.ToString();
            boton.Name = "btnGrupo" + grupo.getId();

            boton.Font = miFuenteGrupo;
            boton.Size = new Size(150, 115);
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = coloresBotones[ color];

            //label (estilo, tamano e info)
            info.Font = miFuenteInfo;
            info.Name = grupo.getId() + "";
            info.Size = new Size(231, 52);

            string nameGroup = grupo.getEscuela();
            if (nameGroup.Length > 18)
            {
                ToolTip message = new ToolTip();
                message.SetToolTip(info, nameGroup);

                nameGroup = nameGroup.Substring(0, 16) + "...";
            }
            info.Text = nameGroup + "\n"+  dbConection.numeroAlumnosEn(grupo.getId()) + " alumnos";

            //contenedor (tamano)
            contenedor.Size = new Size(393, 121);
            contenedor.Margin = new Padding(0,0,0,30 );

            //contenedor(llenar)
            contenedor.Controls.Add(boton);
            contenedor.Controls.Add( info );

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

        /// <summary> crea un panel con los DateButtons de l alumno indicado </summary>
        internal static void llenarPanelAlunos(FlowLayoutPanel panel, Alumno[] alumnos)
        {
            panel.Controls.Clear();

            foreach (Alumno alumno in alumnos)
            {
                Label nombre = new Label();

                nombre.AutoSize = true;
                nombre.Font = miFuentelblAlumno;

                //Si el nombre es mayor a 25 caracteres lo recorta y le pone el tooltip
                string nameAlumno = alumno.nombreCompletoPA();
                if (nameAlumno.Length > 25)
                {
                    ToolTip message = new ToolTip();
                    message.SetToolTip(nombre, alumno.nombreCompletoPA());
                    nameAlumno = nameAlumno.Substring(0, 23) + "...";
                }

                nombre.Text = nameAlumno;
                nombre.Name = alumno.getId().ToString();

                nombre.DoubleClick += labelAlumno_Click;
                //El evento para el click derecho de las etiquetas se debe programar donde se manda llamar este método para poder
                //vincular el panel con los cambios y no tener que refrescar la pantalla

                panel.Controls.Add(nombre);
            }
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

            boton.Text = materia.toString();
            boton.Size = new Size(172, 48);
            boton.Name = "btnMateria" + materia.getId();

            //evento
            boton.Click += new EventHandler(materia_Click);

            //menu contextual del boton(click derecho)
            MenuItem[] mi = {
                    new MenuItem("Editar",editarM_Click),
                    new MenuItem("Borar",borrarM_Click),
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
            string grupo = (sender as Button).Name.Replace("btnGrupo", "");
            int idGrupo = int.Parse(grupo);

            int idMaestro = dbConection.getIdMaestro(idGrupo);
            Program.showListaMaterias(idGrupo, idMaestro);
            Program.listaGrupos.Hide();
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void editarG_Click(object sender, System.EventArgs e)
        {
            int idGrupo = int.Parse((sender as MenuItem).Name);
            FormAgregarGrupo modificarGrupo = new FormAgregarGrupo(dbConection.getGrupo(idGrupo));
            if( modificarGrupo.ShowDialog() == DialogResult.OK)
                Program.listaGrupos.cargarBotones();

        }

        /// <summary> para menu contextual de grupo </summary>
        private static void borrarG_Click(object sender, System.EventArgs e)
        {
            int idGrupo = int.Parse((sender as MenuItem).Name);
            FormBorrarGrupo borrarG = new FormBorrarGrupo(idGrupo);
            borrarG.ShowDialog(Program.listaGrupos);

            Program.listaGrupos.cargarBotones();
            Program.listaGrupos.mostrarLblInfo();
        }


#endregion

#region eventos para asignar a materia

        /// <summary> evento para los botonesMateria </summary>
        private static void materia_Click(object sender, System.EventArgs e)
        {
            string materia = (sender as Button).Name.Replace("btnMateria", "");
            int idMateria = int.Parse(materia);

            Program.showGrupoMateria(idMateria, ((FormListaMaterias)Program.listaMaterias).getIdGrupo());
            Program.listaMaterias.Hide();
        }
        
        /// <summary> para menu contextual de grupo </summary>
        private static void editarM_Click(object sender, System.EventArgs e)
        {
            int idMateria = int.Parse((sender as MenuItem).Name.Replace("Editar", ""));

            FormAgregarMateria modoficarMateria =new FormAgregarMateria(dbConection.getMateria(idMateria));
            if( modoficarMateria.ShowDialog() == DialogResult.OK)
                Program.listaMaterias.cargarMaterias();
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void borrarM_Click(object sender, System.EventArgs e)
        {
            int idMateria = int.Parse((sender as MenuItem).Name.Replace("Borar", ""));

            FormBorrarMateria borrarM = new FormBorrarMateria(dbConection.getMateria(idMateria));
            borrarM.ShowDialog();

            Program.listaMaterias.cargarMaterias();
        }

        #endregion

        /// <summary>Muestra un nuevo Form con la información del alumno presionado</summary>
        public static void labelAlumno_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Label).Name);
            Alumno infoAlumno = dbConection.getAlumno(id);

            new FormAlumno(infoAlumno);
        }
    }
}
