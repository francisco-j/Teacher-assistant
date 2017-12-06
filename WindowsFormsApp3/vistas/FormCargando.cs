using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.vistas
{
    public partial class FormCargando : Form
    {
        Form cargado;
        public FormCargando( Form cargado )
        {
            InitializeComponent();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
        }
    }
}
