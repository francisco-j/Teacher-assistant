using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3.componentes_visuales
{
    /// <summary> para cada tarea para cada alumno </summary>
    class TareaButton : Button
    {
        public bool entregada;

        public TareaButton(int idTarea, bool entregada)
        {
            this.entregada = entregada;
            this.BackgroundImage = entregada ? Properties.Resources.icoCheckMark : Properties.Resources.icoXMark;

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
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).tareaLeaveSelected(idAlumno, this.Name);
        }

        private void mouseEnterButton(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).tareaSelected(idAlumno, this.Name );
        }

        private void clickTareaButton(object sender, EventArgs e)
        {
            //El contenedor padre debe de tener como nombre el id del alumno al que hace referencia
            int idAlumno = int.Parse(this.Parent.Name);

            entregada = !entregada;

            if (entregada)
            {
                dbConection.setTareaEntregada(idAlumno, Convert.ToInt32( this.Name ) );
                this.BackgroundImage = Properties.Resources.icoCheckMark;
            }
            else
            {
                dbConection.quitarTareaEntregada(idAlumno, Convert.ToInt32( this.Name ) );
                this.BackgroundImage = Properties.Resources.icoXMark;
            }
    }

}
}
