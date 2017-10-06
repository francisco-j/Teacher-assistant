﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormGrupoMateria : Form
    {
        GroupBox groupVisible;
        int idMateria, idGrupo;


//*************************** constructor ******************************************

        /// <summary> muestra informacion y funciones del grupo indicado </summary>
        public FormGrupoMateria(int idMateria, int idGrupo)
        {
            InitializeComponent();

            this.idMateria = idMateria;
            this.idGrupo = idGrupo;

            personalizarVentana(idMateria, idGrupo);
            groupVisible = grpBxTareas;

        }


// ******************************** btn Eventos ***************************************************

        /// <summary> muestra la ventana tareas </summary>
        private void btnTareas_Click(object sender, EventArgs e)
        {
            show(grpBxTareas);
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            show(grpBxProyectos);
        }

        private void btnExamenes_Click(object sender, EventArgs e)
        {
            show(grpBxExamenes);
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            show(grpBxCalificaciones);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.showListaMaterias(idGrupo);
        }

// ************************************** metodos *****************************************************

        /// <summary> muestra el groupBox indicado y oculta el visible anteriormente </summary>
        private void show(GroupBox newVisible)
        {
            groupVisible.Visible = false;
            newVisible.Visible = true;
            groupVisible = newVisible;
        }


        // **************************************** privados **************************************************

        private void personalizarVentana(int idMateria,int idGrupo)
        {
            string grupo, materia, numeroAlumnos, escuela;

            Program.getIfo(idMateria, idGrupo, out grupo, out materia, out numeroAlumnos, out escuela);

            lblGrupo.Text = grupo;
            lblMateria.Text = materia;
            lblDatosGrupo.Text = numeroAlumnos + lblDatosGrupo.Text + escuela;

            this.Text = grupo + " " + materia;
        }
    }
}
