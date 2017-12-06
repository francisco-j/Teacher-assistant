using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using WindowsFormsApp3.clases_objeto;
using System.Collections.Generic;

namespace WindowsFormsApp3.vistas
{
    public partial class FormBorrarMateria : Form
    {
        Materia materia;

        public FormBorrarMateria(Materia materia)
        {
            InitializeComponent();

            this.materia = materia;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txbNombreMateria.Text.ToLower() == materia.getNombre().ToLower())
            {
                dbConection.borrarMateria(materia.getId());

                (this.Owner as FormListaMaterias).eliminarMateria(materia.getId());
                this.Dispose();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                txbNombreMateria.Focus();
                txbNombreMateria.BackColor = Color.LightSalmon;
            }
        }

        private void txbNombreMateria_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbNombreMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnBorrar.PerformClick();
        }
    }
}
