using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3.vistas
{
    public partial class FormBorrarGrupo : Form
    {
        Grupo grupo;

        public FormBorrarGrupo(int idGrupo)
        {
            InitializeComponent();

            grupo = Program.getGrupo(idGrupo);
            this.Text += grupo.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ( numGrado.Value == grupo.getGrado() &&
                cbGrupo.Text == grupo.getGrupo() && 
                txbEscuela.Text == grupo.getEscuela() )
            {
                Program.borrarGrupo(grupo.getId());
                this.Dispose();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                txbEscuela.Focus();
                txbEscuela.BackColor = Color.LightSalmon;
            }
        }

        private void FormBorrarGrupo_Load(object sender, EventArgs e)
        {

        }
    }
}
