using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3.componentes_visuales
{
    class NumUpDownCalificacion : NumericUpDown
    {
        private int idEntrega { get; set; }
        private decimal calificacion { get; set; }

        public NumUpDownCalificacion( int idEntrega, decimal calificacion )
        {
            this.calificacion = calificacion;
            this.idEntrega = idEntrega;

            this.Name = idEntrega.ToString();
            this.Font = new Font("Microsoft Sans Serif", 9);
            this.Size = new Size(40, 22);

            this.DecimalPlaces = 1;
            this.Increment = (decimal)0.1;
            this.Maximum = 10;
            this.Minimum = 5;

            this.Value = calificacion;
            this.ForeColor = calificacion >= 8 ? Color.Black : Color.Red;

            this.Margin = new Padding(0, 0, 8, 3 );

            this.ValueChanged += valueChangedNum;
            this.MouseEnter += mouseEnterNum;
            this.MouseLeave += mouseLeaveNum;
        }

        private void valueChangedNum(object sender, EventArgs e)
        {
            int idAlumno = Convert.ToInt32( this.Parent.Name );
            calificacion = this.Value;

            this.ForeColor = calificacion >= 8 ? Color.Black : Color.Red;

            //Quitar como comentario cuando se implemente el método
            //dbConection.actualizarCalificacionEntrega(idAlumno, calificacion);
        }

        private void mouseLeaveNum(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaLeaveSelected(idAlumno, idEntrega.ToString());
        }

        private void mouseEnterNum(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaSelected(idAlumno, idEntrega.ToString());
        }
    }
}
