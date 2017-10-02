﻿using System;
using System.Windows.Forms;
using System.Drawing;
using WindowsFormsApp3.clases;
using WindowsFormsApp3.vistas;

namespace WindowsFormsApp3
{
    public partial class FormListaMaterias : Form
    {
        private int idGrupo;
        private Materia[] materias;
        private Alumno[ ] alumnosGrupo;

        // ****************************** constructor ***************************************

        /// <summary> ventana que muestra la lista de materias </summary>
        /// <param name="idGrupo"> id del grupo cuyas materias se mostraran </param>>
        public FormListaMaterias(int idGrupo)
        {
            InitializeComponent();

            this.idGrupo = idGrupo;
            this.Text = Program.getGrupo( idGrupo ).ToString();

            //Cargamos los botones de las materias
            cargarBotones();

            this.Show();

            //Cargamos la lista de alumnos
            cargarAlumnos();
        }


// ******************** boton evt *****************************************

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.returnToListaGrupos();
            this.Dispose();
        }

        private void btnAgregarMateria_Click(object sender, System.EventArgs e)
        {
            FormAgregarMateria nuevaMateria = new FormAgregarMateria(idGrupo);
            nuevaMateria.ShowDialog();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            new FormResultadoBusqueda(txbBusqueda.Text);
        }

//*********************************** metodos *****************************

        public int getIdGrupo()
        {
            return idGrupo;
        }

        /// <summary>
        /// Obtiene de BD todos los alumnos y los muestra en la lista de asistencia
        /// </summary>
        private void cargarAlumnos()
        {
            //Falta agregar los checkBox de asistencia, por el momento sólo muestra los nombres
            alumnosGrupo = Program.alumnosGrupo( idGrupo );
            panelAlumnos.Controls.Clear();

            foreach (Alumno alumno in alumnosGrupo)
            {
                Label nombre = new Label();
                nombre.AutoSize = true;
                nombre.Font = new Font( "Microsoft Sans Serif", 16 );
                nombre.Text = alumno.nombreCompletoPA();

                panelAlumnos.Controls.Add( nombre );
            }
        }

        ///<sumary> limpia el contenedor y carga todas las materias como botones nuevos </sumary>
        public void cargarBotones()
        {
            materias = Program.materiasDeGrupo(idGrupo);

            contenedorMaterias.Controls.Clear();
            int color = 0;

            foreach (Materia materia in materias)
            {
                Button boton = PersonalizacionComponentes.configurarBotonMateria(materia, color);
                contenedorMaterias.Controls.Add(boton);
                
                color++;
            }
        }

// ************************  closing  ***************************************************

        private void FormListaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            // cierra la aplicacion completa
            Application.Exit(); 
        }

        /// <summary>
        /// Muestra un ventana para agregar un alumno a la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FormAgregarAlumno alumnoNuevo = new FormAgregarAlumno( idGrupo );

            alumnoNuevo.ShowDialog();

            //Refresca la lista de alumnos
            cargarAlumnos();
        }
    }
}