﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3.componentes_visuales
{
    class NumUpDownCalificacion : NumericUpDown
    {

        public NumUpDownCalificacion( int idEntrega, int calificacion )
        {
            this.Name = idEntrega.ToString();
            this.Font = new Font("Microsoft Sans Serif", 9);
            this.Size = new Size(40, 22);

            this.DecimalPlaces = 1;
            this.Increment = (decimal)0.1;
            this.Maximum = 10;
            this.Minimum = 5;

            decimal calif = (decimal)calificacion / 10;
            Console.WriteLine("calificacion: " + calificacion);
            Console.WriteLine("calif: " + calif);
            this.Value = calif;
            this.ForeColor = calif >= 8 ? Color.Black : Color.Red;

            this.Margin = new Padding(0, 0, 8, 3 );

            this.ValueChanged += valueChangedNum;
            this.MouseEnter += mouseEnterNum;
            this.MouseLeave += mouseLeaveNum;
        }

        private void valueChangedNum(object sender, EventArgs e)
        {
            int idAlumno = Convert.ToInt32( this.Parent.Name );

            this.ForeColor = this.Value >= 8 ? Color.Black : Color.Red;
            
            dbConection.actualizarCalificacionEntrega(idAlumno, Convert.ToInt32(this.Name), this.Value);
        }

        private void mouseLeaveNum(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaLeaveSelected(idAlumno, this.Name);
        }

        private void mouseEnterNum(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaSelected(idAlumno, this.Name);
        }
    }
}
