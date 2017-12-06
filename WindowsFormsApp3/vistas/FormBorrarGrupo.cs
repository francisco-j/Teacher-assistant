using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3.vistas
{
    public partial class FormBorrarGrupo : Form
    {
        Grupo grupo;

        public FormBorrarGrupo(int idGrupo)
        {
            InitializeComponent();

            grupo = dbConection.getGrupo(idGrupo);
            this.Text += grupo.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ( numGrado.Value != grupo.getGrado() )
            {
                System.Media.SystemSounds.Beep.Play();
                numGrado.Focus();
            }
            else if( cbGrupo.Text.ToLower() != grupo.getGrupo().ToLower() )
            {
                System.Media.SystemSounds.Beep.Play();
                numGrado.Focus();
            }
            else if( txbEscuela.Text.ToLower() != grupo.getEscuela().ToLower() )
            {
                System.Media.SystemSounds.Beep.Play();
                txbEscuela.Focus();
                txbEscuela.BackColor = System.Drawing.Color.LightSalmon;
            }
            else
            {
                dbConection.borrarGrupo(grupo.getId());

                (this.Owner as FormListaGrupos).eliminarGrupo(grupo.getId());
                this.Dispose();
            }
        }

        private void txbEscuela_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnBorrar.PerformClick();
            }
        }

        private void cbGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                txbEscuela.Focus();
            }
        }

        private void numGrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cbGrupo.Focus();
        }
    }
}
