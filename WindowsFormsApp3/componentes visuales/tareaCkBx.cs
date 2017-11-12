using System;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WindowsFormsApp3.componentes_visuales
{
    /// <summary> para cada tarea para cada alumno </summary>
    class tareaCkBx : CheckBox
    {
        private int idTarea;
        private int idAlumno;

        public tareaCkBx(int idTarea, int idAlumno, bool entregada)
        {
            this.idTarea = idTarea;
            this.idAlumno = idAlumno;
            this.Checked = entregada;
            this.Size = new System.Drawing.Size(38, 14);

            this.CheckedChanged += ChkBox_CheckedChanged;
        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            /*
            if (this.Checked)
                dbConection.tareaEntregada(idAlumno, idTarea);
            else
                dbConection.tareaFaltante(idAlumno, idTarea);
            */
        }

    }
}
