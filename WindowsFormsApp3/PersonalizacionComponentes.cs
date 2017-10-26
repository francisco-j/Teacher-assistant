﻿using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.vistas;
using System.Collections.Generic;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.componentes_visuales;

/// <summary> clase encargada de guardar los métodos que usaremos para personalizar componentes como:
/// los botones, labels y demás componenetes que estaremos generando en tiempo de ejecución
/// todos los metodos son static por que la clase no se instancia </summary>
namespace WindowsFormsApp3
{
    abstract class PersonalizacionComponentes
    {
        private static Color[] coloresBotones = new Color[10] { Color.FromArgb( 114, 112, 202 ), Color.FromArgb(234, 136, 48), Color.FromArgb( 234, 66, 48 ), Color.FromArgb( 30, 145, 133 ), Color.FromArgb( 91, 211, 72 ), Color.FromArgb( 194, 40, 116 ), Color.FromArgb( 255, 235, 87 ), Color.FromArgb( 56, 175, 203 ), Color.FromArgb( 32, 126, 144 ), Color.FromArgb( 223, 46, 70 ) };
        private static Font miFuenteGrupo = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
        private static Font miFuenteMateria = new Font("Microsoft Sans Serif",12 , FontStyle.Bold );
        private static Font miFuenteInfo = new Font("Microsoft Sans Serif", 16);
        private static Font miFuentelblAlumno = new Font("Microsoft Sans Serif", 16);


// **************************************  metodos ********************************************

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
                    new MenuItem("Borar",borrarG_Click),
                    new MenuItem("Exportar",exportarG_Click)
                };
            mi[0].Name = "Editar" + grupo.getId().ToString();
            mi[1].Name = "Borar" + grupo.getId().ToString();
            mi[2].Name = "Exportar" + grupo.getId().ToString();

            boton.ContextMenu = new ContextMenu(mi);

            //eventos
            boton.Click += new EventHandler(grupo_Click);
            
            return contenedor;
        }

        /// <summary> crea un panel con los dateCheckBox de l alumno indicado </summary>
        internal static FlowLayoutPanel hacerPanelAsistencias(int idAlumno, DateTime[] diasClase)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Name = "asistencia"+idAlumno;
            panel.AutoSize = true;

            DateTime[] faltas = dbConection.getFaltas(idAlumno);

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
            
            //DateTime[] tareas = Program.getTareasClase(idGrupo);

            foreach (Alumno alumno in alumnos)
            {
                Label nombre = hacerLabelAlumno(alumno);
                panelAlumnos.Controls.Add(nombre);

                //FlowLayoutPanel panelTareas = PersonalizacionComponentes.hacerPanelAsistencias(alumno.getId(), diasClase);
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

// **************************  eventos para asignar *********************************
        
        // grupos

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
            FormAgregarGrupo modificarGrupo = new FormAgregarGrupo(dbConection.getGrupo(idGrupo));
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

        // materias
        
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
            modoficarMateria.ShowDialog();

            Program.listaMaterias.cargarBotones();
        }

        /// <summary> para menu contextual de grupo </summary>
        private static void borrarM_Click(object sender, System.EventArgs e)
        {
            int idMateria = int.Parse((sender as MenuItem).Name.Replace("Borar", ""));

            FormBorrarMateria borrarM = new FormBorrarMateria(dbConection.getMateria(idMateria));
            borrarM.ShowDialog();

            Program.listaMaterias.cargarBotones();
        }

    }
}
