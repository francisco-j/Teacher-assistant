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

        /// <summary> ventana que muestra la lista de materias del grupo indicado </summary>
        public FormListaMaterias(int idGrupo)
        {
            InitializeComponent();

            this.idGrupo = idGrupo;
            this.Text = Program.getGrupo( idGrupo ).ToString();
            lblGrupo.Text += this.Text;

            //Cargamos los botones de las materias
            cargarBotones();

            //Cargamos la lista de alumnos
            cargarAlumnos();

            this.Show();
        }


// ******************** boton evt *****************************************

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.returnToListaGrupos();
            this.Dispose();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            FormAgregarMateria nuevaMateria = new FormAgregarMateria(idGrupo);
            nuevaMateria.ShowDialog(this);

            cargarBotones();
        }


        /// <summary> Muestra un ventana para agregar un alumno a la BD </summary>
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FormAgregarAlumno alumnoNuevo = new FormAgregarAlumno(idGrupo);

            alumnoNuevo.ShowDialog();

            //Refresca la lista de alumnos
            cargarAlumnos();
        }

        /// <summary> Muestra un ventana busqueda indicada </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            new FormResultadoBusqueda(txbBusqueda.Text);
        }


//*********************************** metodos *****************************

        public int getIdGrupo()
        {
            return idGrupo;
        }

        /// <summary> Obtiene de BD todos los alumnos y los muestra en la lista de asistencia </summary>
        private void cargarAlumnos()
        {
            panelAlumnos.Controls.Clear();
            panelAsistencias.Controls.Clear();

            alumnosGrupo = Program.alumnosGrupo( idGrupo );
            DateTime[] diasClase = Program.getDiasClase(idGrupo);

            foreach (Alumno alumno in alumnosGrupo)
            {
                Label nombre = PersonalizacionComponentes.hacerLabelAlumno(alumno);
                panelAlumnos.Controls.Add( nombre );

                FlowLayoutPanel asistencias = PersonalizacionComponentes.hacerPanelAsistencias(alumno.getId(), diasClase);
                panelAsistencias.Controls.Add(asistencias);
            }

            panelAlumnos.Size = panelAlumnos.PreferredSize;
        }

        ///<sumary> limpia el contenedor y carga todas las materias como botones nuevos </sumary>
        public void cargarBotones()
        {
            materias = Program.materiasDeGrupo(idGrupo);

            contenedorMaterias.Controls.Clear();
            int color = 0;

            foreach (Materia materia in materias)
            {
                Button boton = PersonalizacionComponentes.hacerBotonMateria(materia, color);
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

        private void txbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnBuscar.PerformClick();
        }

        
    }
}