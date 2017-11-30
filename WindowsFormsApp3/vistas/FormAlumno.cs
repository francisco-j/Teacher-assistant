using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using WindowsFormsApp3.clases_objeto;
using System.Collections.Generic;
using WindowsFormsApp3.componentes_visuales;

namespace WindowsFormsApp3.vistas
{
    public partial class FormAlumno : Form
    {
        Alumno alumno;

        public FormAlumno(Alumno alumno)
        {
            InitializeComponent();

            flPanelRubros.Controls.Clear();
            int idGrupo = alumno.getGupo();

            lblNombre.Text = alumno.nombreCompletoPA();
            lblGrupo.Text = dbConection.getGrupo(alumno.getGupo()).ToString();

            //Conseguir las materias
            List<Materia> materias = dbConection.materiasAsociadasCon(alumno.getGupo());

            //Panel de títulos: Tareas, Proyectos, Exámenes, Promedio
            PersonalizacionComponentes.llenarPanelMateriasBusqueda(ref flPanelMaterias, materias );
            tiltLabel[] titulos = new tiltLabel[4];

            titulos[0] = new tiltLabel("Tareas");
            titulos[1] = new tiltLabel("Poyectos");
            titulos[2] = new tiltLabel("Exámenes");
            titulos[3] = new tiltLabel("Promedio");

            titulos[0].Name = "Tareas";
            titulos[1].Name = "Proyectos";
            titulos[2].Name = "Examenes";
            titulos[3].Name = "Promedio";

            titulos[0].Margin = new Padding(0, 0, 50, 0);
            titulos[1].Margin = new Padding(0, 0, 50, 0);
            titulos[2].Margin = new Padding(0, 0, 50, 0);
            titulos[3].Margin = new Padding(0, 0, 50, 0);
            flPanelRubros.Controls.AddRange(titulos);
            
            tlPanel.Controls.Add(flPanelRubros, 1, 0 );

            //Promedio de cada materia
            decimal[,] calificaciones = new decimal[materias.Count, 4];
            decimal promedioTotal = 0;
            decimal[,] porcentajesCalificaciones = new decimal[materias.Count, 3];
            dbConection.llenarMatrizCalificaciones(alumno.getId(), alumno.getGupo(), materias, calificaciones, ref promedioTotal, porcentajesCalificaciones );

            FlowLayoutPanel panelCalificaciones = PersonalizacionComponentes.hacerContenedorEntregas("flPanelCalificaciones");
            PersonalizacionComponentes.llenarPanelCalificacionesBusqueda(ref panelCalificaciones, calificaciones, alumno.getId(), materias, porcentajesCalificaciones, this);
            tlPanel.Controls.Add(panelCalificaciones, 1, 1 );

            promedioTotal = Decimal.Round(promedioTotal, 2);

            lblPromedio.Text += " " + promedioTotal;
            int faltas = dbConection.getNumeroFaltas(alumno.getId());
            lblCantidadFaltas.Text = " " + faltas;
            lblCantidadFaltas.ForeColor = faltas >= 3 ? Color.Red : Color.FromArgb(11, 115, 115);
            //Promedio total
            
            this.Show();
        }
        

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>Cuando el mouse entra a alguno de los labels de calificaciones cambiará el fondo del nombre de la materia y el rubro que corresponden de la asistencia</summary>
        public void lblCalificacionEnter(object sender, EventArgs e)
        {
            (flPanelMaterias.Controls.Find((sender as Label).Parent.Name, false)[0] as Label).BackColor = Color.Silver;
            (flPanelRubros.Controls.Find((sender as Label).Name, false)[0] as Label).BackColor = Color.Silver;
        }

        /// <summary>Cuando el puntero salga de algún label regresará a su color ordinario el nombre de la materia y la tarea correspondiente</summary>
        public void lblCalificacionLeave(object sender, EventArgs e)
        {
            (flPanelMaterias.Controls.Find((sender as Label).Parent.Name, false)[0] as Label).BackColor = Color.WhiteSmoke;
            (flPanelRubros.Controls.Find((sender as Label).Name, false)[0] as Label).BackColor = Color.WhiteSmoke;
        }
    }
}
