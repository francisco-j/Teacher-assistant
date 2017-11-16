using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.vistas;
using System.Collections.Generic;
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
            info.AutoSize = true;
            info.Text += grupo.getEscuela() + "\n";
            info.Text += dbConection.numeroAlumnosEn(grupo.getId()) + " alumnos";

            //contenedor (tamano)
            contenedor.AutoSize = true;
            contenedor.Margin = new Padding( 3, 3, 100, 3 );

            //contenedor(llenar)
            contenedor.Controls.Add(boton);
            contenedor.Controls.Add( info );

            //menu contextual del boton(click derecho)
            MenuItem[] mi = {
                    new MenuItem("Editar",editarG_Click),
                    new MenuItem("Borrar",borrarG_Click),
                };
            mi[0].Name = "Editar" + grupo.getId().ToString();
            mi[1].Name = "Borrar" + grupo.getId().ToString();

            boton.ContextMenu = new ContextMenu(mi);

            //eventos
            boton.Click += new EventHandler(grupo_Click);
            
            return contenedor;
        }

        /// <summary> crea un panel con los dateCheckBox de l alumno indicado </summary>
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
            panel.Size = panel.PreferredSize;
            return panel;
        }

        /// <summary> va a ser para grupoMateria, pero le falta mucha mejora </summary>
        internal static FlowLayoutPanel hacerPanelTareas(int idAlumno, Tarea[] listTareas)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Margin = new Padding(0);

            int[] entregas = dbConection.getEntregas(idAlumno);

            foreach (Tarea tarea in listTareas)
            {
                bool entregada = entregas.Contains(tarea.id);
                panel.Controls.Add(new tareaCkBx(tarea.id, idAlumno, true));

            }
            panel.Size = panel.PreferredSize;

            return panel;
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
                nombre.Text = alumno.nombreCompletoPA();
                nombre.Name = alumno.getId().ToString();

                //El evento para el click derecho de las etiquetas se debe programar donde se manda llamar este método para poder
                //vincular el panel con los cambios y no tener que refrescar la pantalla

                panel.Controls.Add(nombre);
            }

            panel.AutoSize = true;
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
            int idGrupo = int.Parse((sender as MenuItem).Name.Replace("Editar", ""));
            FormAgregarGrupo modificarGrupo = new FormAgregarGrupo(dbConection.getGrupo(idGrupo));
            if( modificarGrupo.ShowDialog() == DialogResult.OK)
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

    }
}
