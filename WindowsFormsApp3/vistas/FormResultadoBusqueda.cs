using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

namespace WindowsFormsApp3.vistas
{
    public partial class FormResultadoBusqueda : Form
    {
        Alumno[] alumnos;


        public FormResultadoBusqueda(string busqueda)
        {
            InitializeComponent();

            mostrar(busqueda);

            this.Show();
        }

        private void mostrar(string busqueda)
        {
            lstBxNombres.Items.Clear();
            lstBxGrados.Items.Clear();

            alumnos =  Program.busqueda(busqueda);

            foreach (Alumno a in alumnos)
            {
                lstBxNombres.Items.Add(a.nombreCompletoPN());
                Grupo g = Program.getGrupo(a.getGupo());
                lstBxGrados.Items.Add(g.ToString());
            }
        }
    }
}
