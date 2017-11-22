using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3.componentes_visuales
{
    /// <summary> para cada tarea para cada alumno </summary>
    class TareaButton : Button
    {
        private int idTarea;
        public bool entregada;
        private static Image[] imagesAsistencia = { Properties.Resources.icoCheckMark, Properties.Resources.icoXMark };

        public TareaButton(int idTarea, bool entregada)
        {
            this.idTarea = idTarea;
            this.entregada = entregada;
            this.BackgroundImage = entregada ? imagesAsistencia[0] : imagesAsistencia[1];

            this.Name = idTarea.ToString();
            this.Size = new Size(44, 26);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            this.FlatAppearance.BorderSize = 1;
            this.BackColor = Color.WhiteSmoke;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Margin = new Padding(0);

            this.Click += clickTareaButton;
            this.MouseEnter += mouseEnterButton;
            this.MouseLeave += mouseLeaveButton;
        }

        private void mouseLeaveButton(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaLeaveSelected(idAlumno, idTarea.ToString());
        }

        private void mouseEnterButton(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaSelected(idAlumno, idTarea.ToString());
        }

        private void clickTareaButton(object sender, EventArgs e)
        {
            //El contenedor padre debe de tener como nombre el id del alumno al que hace referencia
            int idAlumno = int.Parse(this.Parent.Name);

            if (!entregada)
            {
                dbConection.setTareaEntregada(idAlumno, idTarea);
                entregada = true;
                this.BackgroundImage = imagesAsistencia[0];
            }
            else
            {
                dbConection.quitarTareaEntregada(idAlumno, idTarea);
                entregada = false;
                this.BackgroundImage = imagesAsistencia[1];
            }
        }

    }
}
