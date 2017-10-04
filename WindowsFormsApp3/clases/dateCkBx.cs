using System;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WindowsFormsApp3.clases
{
    /// <summary> para cada dia para cada alumno </summary>
    class dateCkBx: CheckBox
    {
        private DateTime dia;

        public dateCkBx(DateTime dia, bool asistencia)
        {
            this.dia = dia;
            this.Checked = asistencia;
        }
    }
}
