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

namespace WindowsFormsApp3.vistas
{
    public partial class FormAlumno : Form
    {

        int idAlumno;

        public FormAlumno(Alumno alumno)
        {
            InitializeComponent();

            this.idAlumno = alumno.getId();
            int idGrupo = alumno.getGupo();

            lblNombre.Text = alumno.nombreCompletoPA();
            lblGrupo.Text = alumno.getGupo().ToString();

            /*
            dbConection.getPorcenAsistencias(idAlumno);

            dbConection.getCantTareasEntregadas(idAlumno);
            dbConection.getCantTareasTotal(idGrupo);
            dbConection.getCantProyectosEntregados(idAlumno);
            dbConection.getCantProyectosTotal(idGrupo);

            dbConection.getValorAsistencias(idGrupo);
            dbConection.getValorTareas(idGrupo);
            dbConection.getValorProyectos(idGrupo);
            */

            this.Show();
        }
        

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
