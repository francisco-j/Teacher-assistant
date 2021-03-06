﻿using System;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3.vistas
{
    public partial class FormResultadoBusqueda : Form
    {
        //almacenamos los alumnos para cuando queramos ver al info de cada uno
        Alumno[] alumnos;
        int idMaestro;

#region constructor

        /// <summary> ventana que muestra la busqueda indicada </summary>
        public FormResultadoBusqueda(string busqueda, int idMaestro)
        {
            InitializeComponent();

            this.idMaestro = idMaestro;

            txbBusqueda.Text = busqueda;
            mostrar(busqueda, idMaestro);

            this.Show();
        }

#endregion

#region metodos

        /// <summary> busca en la DB y agrega a la lista </summary>
        private void mostrar(string busqueda, int idMaestro)
        {
            lstBxNombres.Items.Clear();
            lstBxGrados.Items.Clear();
            lblSinResultados.Visible = false;

            alumnos =  dbConection.buscar(busqueda, idMaestro);

            if (alumnos.Length == 0)
            {
                lblSinResultados.Visible = true;
            }
            else
            {
                foreach (Alumno a in alumnos)
                {
                    lstBxNombres.Items.Add(a.nombreCompletoPN());

                    Grupo g = dbConection.getGrupo(a.getGupo());
                    lstBxGrados.Items.Add(g.ToString());
                }
                lstBxGrados.Height = lstBxGrados.PreferredHeight;
                lstBxNombres.Height = lstBxNombres.PreferredHeight;
            }
        }

#endregion

#region btn_click

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if( txbBusqueda.Text.Trim() != string.Empty )
                mostrar(txbBusqueda.Text, idMaestro);
            else
            {
                txbBusqueda.Focus();
                txbBusqueda.BackColor = System.Drawing.Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void lstBxNombres_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstBxNombres.SelectedIndex;
            new FormAlumno(alumnos[index]);
        }

        #endregion

        private void txbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnBuscar.PerformClick();
            }
        }
    }
}