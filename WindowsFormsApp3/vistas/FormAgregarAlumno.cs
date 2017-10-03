using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.clases;

namespace WindowsFormsApp3.vistas
{
    public partial class FormAgregarAlumno : Form
    {

//********************************* constructor *****************************************
        private int idGrupo;
        public FormAgregarAlumno( int idGrupo )
        {
            InitializeComponent();

            this.idGrupo = idGrupo;
        }


//********************************************* btn_event *****************************************

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string paterno = txbPaterno.Text;
            string materno = txbMaterno.Text;

            //Validaciones de campos vacíos
            if( nombre == "" )
            {
                System.Media.SystemSounds.Beep.Play();
                txbNombre.Focus();
                txbNombre.BackColor = Color.LightSalmon;
            }
            else if( paterno == "" )
            {
                System.Media.SystemSounds.Beep.Play();
                txbPaterno.Focus();
                txbPaterno.BackColor = Color.LightSalmon;
            }
            else if( materno == "" )
            {
                System.Media.SystemSounds.Beep.Play();
                txbMaterno.Focus();
                txbMaterno.BackColor = Color.LightSalmon;
            }
            else
            {
                Alumno alumno = new Alumno( idGrupo, nombre, paterno, materno );

                //Le dice a la BD que agregue ése alumno
                Program.agregarAlumno( alumno );

                this.Dispose();
            }
        }
    }
}
