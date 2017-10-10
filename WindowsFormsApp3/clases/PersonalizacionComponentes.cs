using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using WindowsFormsApp3.vistas;
using System.Collections.Generic;

/// <summary> clase encargada de guardar los métodos que usaremos para personalizar componentes como:
/// los botones, labels y demás componenetes que estaremos generando en tiempo de ejecución
/// todos los metodos son static por que la clase no se instancia </summary>
namespace WindowsFormsApp3
{
    class PersonalizacionComponentes
    {
        private static Color[] botonGrupoColores = new Color[10] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };
        private static Color[] botonMateriaColores = new Color[10] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };
        private static Font miFuenteGrupo = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
        private static Font miFuenteMateria = new Font("Microsoft Sans Serif",12 , FontStyle.Bold);
        private static Font miFuenteInfo = new Font("Microsoft Sans Serif", 16);
        private static Font miFuentelblAlumno = new Font("Microsoft Sans Serif", 16);


//********************************** constructor **************************************

        //privado para que no lo instancien
        private PersonalizacionComponentes() { }


// **************************************  metodos ********************************************

        /// <summary> debuelbe el contenedor con la informacion del grupo indicado </summary>
        /// <param name="boton"> contenedor a decorar </param>
        /// <param name="grupo"> grupo del que se tomara la informacion </param>
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
            boton.BackColor = botonGrupoColores[color];

            //label (estilo, tamano e info)
            info.Font = miFuenteInfo;
            info.AutoSize = true;
            info.Text += grupo.getEscuela() + "\n";
            info.Text += Program.numeroAlumnosEn(grupo.getId()) + " alumnos";

            //contenedor (tamano)
            contenedor.AutoSize = true;

            //contenedor(llenar)
            contenedor.Controls.Add(boton);
            contenedor.Controls.Add(info);

            //menu contextual del boton(click derecho)
            MenuItem[] mi = {
                    new MenuItem("Editar",editarG_Click),
                    new MenuItem("Borar",borrarG_Click),
                    new MenuItem("Exportar",exportarG_Click)
                };
            mi[0].Name = "Editar" + grupo.getId().ToString();
            mi[1].Name = "Borar" + grupo.getId().ToString();
            mi[2].Name = "Exportar" + grupo.getId().ToString();

            boton.ContextMenu = new ContextMenu(mi);

            //eventos
            boton.Click += new EventHandler(grupo_Click);
            //click derecho;
            
            return contenedor;
        }

        /// <summary> crea un panel con los checkBox para asistencias necesarios </summary>
        internal static FlowLayoutPanel hacerPanelAsistencias(int idAlumno, DateTime[] diasClase)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Name = "asistencia"+idAlumno;
            panel.AutoSize = true;

            DateTime[] faltas = Program.getFaltas(idAlumno);

            foreach ( DateTime dia in diasClase)
            {
                if (faltas.Contains(dia))
                    panel.Controls.Add(new dateCkBx(dia,false));
                else
                    panel.Controls.Add(new dateCkBx(dia,true));
            }

            return panel;
        }

        /// <summary> va a ser para grupoMateria, pero le falta mucha mejora </summary>
        internal static void decorarPanelTareas(ref FlowLayoutPanel panel, Alumno[] alumnos, int idGrupo, int idMateria)
        {
            panel.Controls.Clear();
            
            FlowLayoutPanel panelAlumnos = new FlowLayoutPanel();
            FlowLayoutPanel panelTareas = new FlowLayoutPanel();
            
            DateTime[] tareas = Program.getTareassClase(idGrupo);

            foreach (Alumno alumno in alumnos)
            {
                Label nombre = hacerLabelAlumno(alumno);
                panelAlumnos.Controls.Add(nombre);

                FlowLayoutPanel panelTareas = PersonalizacionComponentes.hacerPanelAsistencias(alumno.getId(), diasClase);
                panelTareas.Controls.Add(panelTareas);
            }

            panelAlumnos.Size = panelAlumnos.PreferredSize;

        }

        /// <summary> debuelbe el label con el nombre del alumno indicado </summary>
        internal static Label hacerLabelAlumno(Alumno alumno)
        {
            Label nombre = new Label();

            nombre.AutoSize = true;
            nombre.Font = miFuentelblAlumno;
            nombre.Text = alumno.nombreCompletoPA();

            return nombre;
        }

        /// <summary> decora el botón con la información de la materia indicada </summary>
        public static Button hacerBotonMateria(Materia materia, int color)
        {
            //botón
            Button boton = new Button();

            boton.Font = miFuenteMateria;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = botonMateriaColores[color];

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

// **************************  eventos para asignar *********************************
        
                        // ** grupos ** //

        /// <summary> evento para los botonesGrupo  </summary>
        private static void grupo_Click(object sender, System.EventArgs e)
        {
            string grupo = (sender as Button).Name.Replace("btnGrupo", "");
            int idGrupo = int.Parse(grupo);

            Program.showListaMaterias(idGrupo);
            Program.listaGrupos.Hide();
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void editarG_Click(object sender, System.EventArgs e)
        {
            int idGrupo = int.Parse((sender as MenuItem).Name.Replace("Editar", ""));
            FormAgregarGrupo modificarGrupo = new FormAgregarGrupo(Program.getGrupo(idGrupo));
            modificarGrupo.ShowDialog();

            Program.listaGrupos.cargarBotones();

        }

        /// <summary> para menu contextual de grupo </summary>
        private static void borrarG_Click(object sender, System.EventArgs e)
        {
            int idGrupo = int.Parse((sender as MenuItem).Name.Replace("Borar", ""));
            FormBorrarGrupo borrarG = new FormBorrarGrupo(idGrupo);
            borrarG.ShowDialog(Program.listaGrupos);

            Program.listaGrupos.cargarBotones();

        }

        /// <summary> para menu contextual de grupo </summary>
        private static void exportarG_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
            //int idGrupo = int.Parse((sender as MenuItem).Name.Replace("Exportar", ""));
            //Program.listaGrupos.ShowDialog(new FormExportarGrupo(idGrupo));
        }

                        // ** materias ** //
        
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

            FormAgregarMateria modoficarMateria =new FormAgregarMateria(Program.getMateria(idMateria));
            modoficarMateria.ShowDialog();

            Program.listaMaterias.cargarBotones();
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void borrarM_Click(object sender, System.EventArgs e)
        {
            int idMateria = int.Parse((sender as MenuItem).Name.Replace("Borar", ""));

            FormBorrarMateria borrarM = new FormBorrarMateria(Program.getMateria(idMateria));
            borrarM.ShowDialog();

            Program.listaMaterias.cargarBotones();
        }

    }
}
