using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    public partial class FormInicio : Form
    {

// ******************************** costructor *********************************
        public FormInicio()
        {
            InitializeComponent();
            this.Show();
        }

// ****************************** btn_event *******************************************
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new FormRegistrarse().ShowDialog();
            txbUsuario.Focus();
        }


// *****************************  eventos_enter ********************************************
        private void txbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbContrasena.Focus();
        }

        private void txbContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnIniciar.PerformClick();
        }

        private void FormInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}