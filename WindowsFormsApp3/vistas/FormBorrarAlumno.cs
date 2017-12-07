using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3.vistas
{
    public partial class FormBorrarAlumno : Form
    {
        private Alumno alumno;
        private bool borrar;

        public FormBorrarAlumno( Alumno alumno, bool borrar )
        {
            InitializeComponent();

            this.alumno = alumno;
            this.borrar = borrar;
            //Si on se va a borrar entonces se llamó al método para editar al alumno
            if (!borrar)
            {
                this.Text = "Editar alumno";
                lblInfo2.Text = "que deseas editar";
                btnCambio.Text = "Guardar cambios";

                txtNombre.Text = alumno.getNombres();
                txtPaterno.Text = alumno.getPaterno();
                txtMaterno.Text = alumno.getMaterno();

                btnCambio.Click += editar_Click;
                //btnCambio.DialogResult = DialogResult.OK;
            }

            txtNombre.Focus();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                txtNombre.Focus();
                txtNombre.BackColor = Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
            else if (txtPaterno.Text.Trim() == "")
            {
                txtPaterno.Focus();
                txtPaterno.BackColor = Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
            else if (txtMaterno.Text.Trim() == "")
            {
                txtNombre.Focus();
                txtNombre.BackColor = Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
            else
            {
                //Para que cambie la mayúsculas de los nombres 
                alumno = new Alumno(alumno.getId(), txtNombre.Text, txtPaterno.Text, txtMaterno.Text, alumno.getGupo());
                this.DialogResult = DialogResult.OK;

                dbConection.actualizarAlumno(alumno.getId(), alumno.getNombres(), alumno.getPaterno(), alumno.getMaterno() );
                this.Dispose();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                txtPaterno.Focus();
            }
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                txtMaterno.Focus();
            }
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnCambio.PerformClick();
            }
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.ToLower() != alumno.getNombres().ToLower())
            {
                txtNombre.Focus();
                System.Media.SystemSounds.Beep.Play();
                //txtNombre.BackColor = Color.LightSalmon;
                txtNombre.WithError = true;
            }
            else if (txtPaterno.Text.ToLower() != alumno.getPaterno().ToLower())
            {
                txtPaterno.Focus();
                System.Media.SystemSounds.Beep.Play();
                //txtPaterno.BackColor = Color.LightSalmon;
                txtPaterno.WithError = true;
            }
            else if (txtMaterno.Text.ToLower() != alumno.getMaterno().ToLower())
            {
                txtMaterno.Focus();
                System.Media.SystemSounds.Beep.Play();
                //txtMaterno.BackColor = Color.LightSalmon;
                txtMaterno.WithError = true;
            }
            else
            {
                dbConection.borrarAlumno(alumno.getId());
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }
    }
}
