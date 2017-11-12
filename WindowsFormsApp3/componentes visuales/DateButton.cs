using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3.componentes_visuales
{
    class DateButton : Button
    {
        private DiaClase dia;
        public bool asistencia;
        

        public DateButton(DiaClase dia, bool asistencia, Image fondo)
        {
            this.dia = dia;
            this.asistencia = asistencia;

            this.Size = new Size(38, 14);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            this.FlatAppearance.BorderSize = 1;
            this.BackColor = Color.WhiteSmoke;
            this.BackgroundImage = fondo;
            this.BackgroundImageLayout = ImageLayout.Zoom;

            this.Click += clickDateButton;
        }

        private void clickDateButton(object sender, EventArgs e)
        {
            int idAlumno = int.Parse(this.Parent.Name.Replace("asistencia", ""));

            if (!asistencia)
            {
                dbConection.quitarFalta(idAlumno, dia.dia);
                asistencia = true;
                this.BackgroundImage = Properties.Resources.icoCheckMark24;
            }
            else
            {
                dbConection.ponerFalta(idAlumno, dia.dia);
                asistencia = false;
                this.BackgroundImage = Properties.Resources.icoXMark24;
            }
        }

    }
}
