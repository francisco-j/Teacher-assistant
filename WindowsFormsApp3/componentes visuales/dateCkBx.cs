using System;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WindowsFormsApp3.componentes_visuales
{
    /// <summary> para cada dia para cada alumno </summary>
    class dateCkBx: CheckBox
    {
        private DateTime dia;

        public dateCkBx(DateTime dia, bool asistencia)
        {
            this.dia = dia;
            this.Checked = asistencia;
            this.Size= new System.Drawing.Size(15, 14);

            this.CheckedChanged += ChkBox_CheckedChanged;
        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            int idAlumno = int.Parse(this.Parent.Name.Replace("asistencia", ""));

            Program.tomarAsistencia(idAlumno, this.dia, this.Checked);
        }

    }
}
