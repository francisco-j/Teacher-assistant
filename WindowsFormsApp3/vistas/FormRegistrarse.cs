using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormRegistrarse : Form
    {
        public FormRegistrarse()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //txbUsuario.BackColor = Color.White;
            //txbContrasena.BackColor = Color.White;
            //txbConfirmacion.BackColor = Color.White;

            txbUsuario.WithError = false;
            txbConfirmacion.WithError = false;
            txbContrasena.WithError = false;

            string usuario = txbUsuario.Text.Trim();
            string contraseña = txbContrasena.Text;
            string confirmacion = txbConfirmacion.Text;

            if (usuario == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbUsuario.Focus();
                //txbUsuario.BackColor = Color.LightSalmon;
                txbUsuario.WithError = true;
            }
            else if (contraseña == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbContrasena.Focus();
                //txbContrasena.BackColor = Color.LightSalmon;
                txbContrasena.WithError = true;
            }
            else if (confirmacion == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbConfirmacion.Focus();
                //txbConfirmacion.BackColor = Color.LightSalmon;
                txbConfirmacion.WithError = true;
            }
            else if (confirmacion != contraseña)
            {
                MessageBox.Show("La contraseña y la confirmación no coinciden");
                txbContrasena.Focus();
            }
            else
            {
                try
                {
                    dbConection.registrarUsuario(usuario, contraseña);
                    MessageBox.Show("El maestro " + usuario + " se ha guardado exitosamente");
                    this.Dispose();

                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                txbContrasena.Focus();
            }
        }

        private void txbContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                txbConfirmacion.Focus();
            }
        }

        private void txbConfirmacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnRegistrar.PerformClick();
            }
        }
    }
}