using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            Program.LogOut();
        }

        private void btnGrupA_Click(object sender, EventArgs e)
        {
            Program.ShowGroup();
        }

        private void FormListaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
