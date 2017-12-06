using System;
using System.Drawing;
using System.Linq;
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
            //Validaciones de campos vacíos
            if ( txbNombre.Text.Trim() == "" )
            {
                System.Media.SystemSounds.Beep.Play();
                txbNombre.Focus();
                txbNombre.BackColor = Color.LightSalmon;
            }
            else if( txbPaterno.Text.Trim() == "" )
            {
                System.Media.SystemSounds.Beep.Play();
                txbPaterno.Focus();
                txbPaterno.BackColor = Color.LightSalmon;
            }
            else if( txbMaterno.Text.Trim() == "" )
            {
                System.Media.SystemSounds.Beep.Play();
                txbMaterno.Focus();
                txbMaterno.BackColor = Color.LightSalmon;
            }
            else
            {
                //Este método también agregará todos los registros de las tareas, exámenes y proyectos de todas las materias del grupo al que pertenece
                Alumno alumno = dbConection.agregarAlumno(idGrupo, nombre, paterno, materno);

                    FormListaMaterias flm = (FormListaMaterias)this.Owner;
                    flm.recibirAlumno(alumno);

                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Ya existe un alumno con esos nombres, intenta con otro", "Alumno ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    txbNombre.Focus();
                }
            }
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                txbPaterno.Focus();
            }
        }

        private void txbPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                txbMaterno.Focus();
            }
        }

        private void txbMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnGuardar.PerformClick();
            }
        }

#endregion

    }
}
