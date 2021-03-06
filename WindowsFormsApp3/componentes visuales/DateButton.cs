﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3.componentes_visuales
{
    class DateButton : Button
    {
        private DiaClase dia;
        public bool asistencia;
        private static Image[] imagesAsistencia = { Properties.Resources.icoCheckMark, Properties.Resources.icoXMark };
        

        public DateButton(DiaClase dia, bool asistencia)
        {
            this.dia = dia;
            this.asistencia = asistencia;
            this.BackgroundImage = asistencia ? imagesAsistencia[0]: imagesAsistencia[1];

            this.Name = dia.dia.ToString("dd'/'MM'/'yy");
            this.Size = new Size(44, 26);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0);
            this.FlatAppearance.BorderSize = 1;
            this.BackColor = Color.WhiteSmoke;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.Margin = new Padding(0);

            this.Click += clickDateButton;
            this.MouseEnter += mouseEnterButton;
            this.MouseLeave += mouseLeaveButton;
        }

        private void mouseLeaveButton(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as frmMaterias).asistenciaLeaveSelected(idAlumno, dia.dia.ToString("dd'/'MM'/'yy"));
        }

        private void mouseEnterButton(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as frmMaterias).asistenciaSelected(idAlumno, dia.dia.ToString("dd'/'MM'/'yy"));
        }

        private void clickDateButton(object sender, EventArgs e)
        {
            int idAlumno = int.Parse(this.Parent.Name.Replace("asistencia", ""));

            if (!asistencia)
            {
                dbConection.quitarFalta(idAlumno, dia.dia);
                asistencia = true;
                this.BackgroundImage = imagesAsistencia[0];
            }
            else
            {
                dbConection.ponerFalta(idAlumno, dia.dia);
                asistencia = false;
                this.BackgroundImage = imagesAsistencia[1];
            }
        }

    }
}
