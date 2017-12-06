using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.vistas;

namespace WindowsFormsApp3
{
    public partial class FormInicio : Form
    {

#region costructor

        public FormInicio()
        {
            InitializeComponent();
            //txbUsuario.KeyDown += Program.txbUsuario_KeyDown;
            //txbContrasena.KeyDown += Program.txbUsuario_KeyDown;

            this.Show();
        }

        #endregion

#region btn_event

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txbUsuario.BackColor = Color.White;
            txbContrasena.BackColor = Color.White;

            string contrasena = txbContrasena.Text;
            string usuario = txbUsuario.Text.Trim();
            
            if (usuario == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbUsuario.Focus();
                txbUsuario.BackColor = Color.LightSalmon;
            }
            else if (contrasena == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbContrasena.Focus();
                txbContrasena.BackColor = Color.LightSalmon;
            }
            else
            {
                try
                {
                    Program.Login(usuario, contrasena);
                    this.Dispose();
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(this, ex.Message);
                }

            }
        }

        #endregion
#region eventos_enter

        private void txbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetterOrDigit(e.KeyChar) && !( e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13 ) )
            {
                e.Handled = true;
            }
            else if( e.KeyChar == 13 )
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
                btnIniciar.PerformClick();
            }
        }

        private void FormInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormRegistrarse().ShowDialog();
            txbUsuario.Focus();
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            FormCargando carga = new FormCargando(this);
            carga.ShowDialog(this);
        }
    }

#endregion

}