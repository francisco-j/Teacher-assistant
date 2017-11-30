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
            
            int idGrupo = alumno.getGupo();

            lblNombre.Text = alumno.nombreCompletoPA();
            lblGrupo.Text = dbConection.getGrupo(alumno.getGupo()).ToString();

            //Conseguir las materias
            List<Materia> materias = dbConection.materiasAsociadasCon(alumno.getGupo());

            //Panel de títulos: Tareas, Proyectos, Exámenes, Promedio
            PersonalizacionComponentes.llenarPanelMateriasBusqueda(ref flPanelMaterias, materias );
            FlowLayoutPanel panelTitulos = PersonalizacionComponentes.hacerContenedorTitulosEntregas("flPanelRubros");
            tiltLabel[] titulos = new tiltLabel[4];

            titulos[0] = new tiltLabel("Tareas");
            titulos[1] = new tiltLabel("Poyectos");
            titulos[2] = new tiltLabel("Exámenes");
            titulos[3] = new tiltLabel("Promedio");

            titulos[0].Margin = new Padding(0, 0, 50, 0);
            titulos[1].Margin = new Padding(0, 0, 50, 0);
            titulos[2].Margin = new Padding(0, 0, 50, 0);
            titulos[3].Margin = new Padding(0, 0, 50, 0);
            panelTitulos.Controls.AddRange(titulos);
            
            tlPanel.Controls.Add(panelTitulos, 1, 0 );

            //Promedio de cada materia
            decimal[,] calificaciones = new decimal[materias.Count, 4];
            decimal promedioTotal = 0;
            decimal[,] porcentajesCalificaciones = new decimal[materias.Count, 3];
            dbConection.llenarMatrizCalificaciones(alumno.getId(), alumno.getGupo(), materias, calificaciones, ref promedioTotal, porcentajesCalificaciones );

            FlowLayoutPanel panelCalificaciones = PersonalizacionComponentes.hacerContenedorEntregas("flPanelCalificaciones");
            PersonalizacionComponentes.llenarPanelCalificacionesBusqueda(ref panelCalificaciones, calificaciones, alumno.getId(), materias, porcentajesCalificaciones);

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
    }
}
