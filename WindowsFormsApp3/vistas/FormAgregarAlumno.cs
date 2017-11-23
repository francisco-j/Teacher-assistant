using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3.vistas
{
    public partial class FormAgregarAlumno : Form
    {

#region constructor
        private int idGrupo;
        public FormAgregarAlumno( int idGrupo )
        {
            InitializeComponent();

            this.idGrupo = idGrupo;
        }

#endregion

#region btn_event

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text.Trim();
            string paterno = txbPaterno.Text.Trim();
            string materno = txbMaterno.Text.Trim();

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
                Alumno alumno = dbConection.agregarAlumno(idGrupo, nombre, paterno, materno);
                
                ((FormListaMaterias)this.Owner).recibirAlumno(alumno);

                this.Dispose();
            }
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbPaterno.Focus();
        }

        private void txbPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbMaterno.Focus();
        }

        private void txbMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnGuardar.PerformClick();
        }

#endregion

    }
}
