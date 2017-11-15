using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3.vistas
{
    public partial class FormBorrarAlumno : Form
    {
        private Alumno alumno;
        private bool borrar;

        public FormBorrarAlumno()
        {
            InitializeComponent();
        }

        public FormBorrarAlumno( Alumno alumno, bool borrar )
        {
            InitializeComponent();

            this.alumno = alumno;
            this.borrar = borrar;

            //Si on se va a borrar entonces se llamó al método para editar al alumno
            if( !borrar)
            {
                this.Text = "Editar alumno";
                lblInfo2.Text = "que deseas editar";
                btnCambio.Text = "Guardar cambios";

                btnCambio.DialogResult = DialogResult.OK;
                btnCambio.Click += editar_Click;
            }

            txtNombre.Focus();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if( txtNombre.Text.ToLower() != alumno.getNombres().ToLower() )
            {
                txtNombre.Focus();
                txtNombre.BackColor = Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
            else if (txtPaterno.Text.ToLower() != alumno.getPaterno().ToLower())
            {
                txtPaterno.Focus();
                txtPaterno.BackColor = Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
            else if (txtMaterno.Text.ToLower() != alumno.getMaterno().ToLower())
            {
                txtMaterno.Focus();
                txtMaterno.BackColor = Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
            else
            {
                dbConection.borrarAlumno(alumno.getId());
                this.Dispose();
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                txtNombre.BackColor = Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
            else if (txtPaterno.Text == "")
            {
                txtPaterno.Focus();
                txtPaterno.BackColor = Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
            else if (txtMaterno.Text == "")
            {
                txtNombre.Focus();
                txtNombre.BackColor = Color.LightSalmon;
                System.Media.SystemSounds.Beep.Play();
            }
            else
            {
                //Para que cambie la mayúsculas de los nombres 
                alumno = new Alumno(alumno.getId(), txtNombre.Text, txtPaterno.Text, txtMaterno.Text, alumno.getGupo());

                dbConection.actualizarAlumno(alumno.getId(), alumno.getNombres(), alumno.getPaterno(), alumno.getMaterno() );
                this.Dispose();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPaterno.Focus();
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtMaterno.Focus();
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnCambio.PerformClick();
        }
    }
}
