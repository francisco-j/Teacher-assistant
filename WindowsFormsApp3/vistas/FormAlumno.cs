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
    public partial class FormAlumno : Form
    {

        int idAlumno;
//
        public FormAlumno(int idAlumno)
        {
            InitializeComponent();
            this.idAlumno = idAlumno;

            //Program.getAlumno(idAlumno);
        }

        public FormAlumno(Alumno alumno)
        {
            InitializeComponent();

            lblId.Text = alumno.getId().ToString();
            lblNombre.Text = alumno.getNombres();
            lblAP.Text = alumno.getPaterno();
            lblAM.Text = alumno.getMaterno();
            lblGrupo.Text = alumno.getGupo().ToString();

            this.Show();
        }
    }
}
