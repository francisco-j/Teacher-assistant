using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormListaG : Form
    {
        public FormListaG()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.LogOut(); // le dice a program que cierre secion
        }

        private void btnGrupA_Click(object sender, EventArgs e)
        {
            Program.ShowGroup(1);
        }

        private void btnGrupB_Click(object sender, EventArgs e)
        {
            Program.ShowGroup(2);
        }

        private void FormListaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // cierra la aplicacion completa
        }
        
    }
}
