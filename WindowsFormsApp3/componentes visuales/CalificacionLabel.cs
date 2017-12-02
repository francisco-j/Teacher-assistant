using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3.componentes_visuales
{
    class CalificacionLabel : Label
    {
        public decimal calificacion { get; set; }
        //Proyecto 1, examen 2
        public int tipo { get; set; }

        public CalificacionLabel( int idEntregable, decimal calificacion, int tipo )
        {
            this.tipo = tipo;
            this.Font = new Font("Microsoft Sans Serif", 16);
            this.Name = idEntregable.ToString();
            this.Size = new Size(44, 26);
            this.FlatStyle = FlatStyle.Flat;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.WhiteSmoke;
            this.Margin = new Padding(0);
            this.calificacion = calificacion / 10;
            this.Text = this.calificacion.ToString();

            this.ForeColor = this.calificacion >= 8 ? Color.Black : Color.Red;

            this.MouseClick += clickCalificacionLabel;
            this.MouseEnter += mouseEnterLabel;
            this.MouseLeave += mouseLeaveLabel;
            this.DoubleClick += doubleClickLabel;
        }

#region Eventos Label

        private void doubleClickLabel(object sender, EventArgs e)
        {
            TextBox txtTemp = new TextBox();
            txtTemp.Name = "txtTemp";
            txtTemp.MaxLength = 3;
            txtTemp.KeyPress += txtKeyPress;
            txtTemp.LostFocus += txtLostFocus;
            this.Controls.Add(txtTemp);
            txtTemp.Focus();
        }

        /// <summary>Cuando label calificacion recibe un clic suma 0.1 a su valor, si recibe un clic derecho le resta 0.1</summary>
        private void clickCalificacionLabel(object sender, MouseEventArgs e)
        {
            if( e.Button == MouseButtons.Right )
            {
                if ( calificacion - (decimal)0.1 < 5)
                    return;

                calificacion -= (decimal)0.1;
            }
            else//( e.Button == MouseButtons.Right )
            {
                if (calificacion + (decimal)0.1 > 10)
                    return;

                calificacion += (decimal)0.1;
            }

            int idAlumno = Convert.ToInt32(this.Parent.Name);

            this.Text = calificacion.ToString();
            this.ForeColor = this.calificacion >= 8 ? Color.Black : Color.Red;

            dbConection.actualizarCalificacionEntrega(idAlumno, Convert.ToInt32(this.Name), calificacion);
        }

        private void mouseLeaveLabel(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaLeaveSelected(idAlumno, this.Name, tipo);
        }

        private void mouseEnterLabel(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaSelected(idAlumno, this.Name, tipo);
        }

#endregion

#region Eventos txtTemp

        /// <summary>Si se presionó doble click sobre label calificación aparecerá una caja de texto que tendrá el foco, si lo pierde se destruirá</summary>
        private void txtLostFocus(object sender, EventArgs e)
        {
            this.Controls.RemoveByKey("txtTemp");
        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            char pressed = e.KeyChar;
            if( Char.IsDigit( pressed ) )
            {
                e.Handled = false;
            }
            else if (pressed == 46) //Punto, además valida que sólo haya uno
            {
                if ((this.Controls[0] as TextBox).Text.Contains('.'))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else if( pressed == 13) //Enter
            {
                //Si sólo tiene un punto (no puede tener más) o on tiene nada, no pasa nada, se sale
                if ((sender as TextBox).Text == "" || (sender as TextBox).Text == ".")
                    return;

                decimal grade = Convert.ToDecimal((sender as TextBox).Text);
                if (grade >= 5 && grade <= 10)
                {
                    this.calificacion = grade;
                    this.Text = this.calificacion.ToString();
                    this.ForeColor = this.calificacion >= 8 ? Color.Black : Color.Red;

                    this.Controls.RemoveByKey("txtTemp");

                    int idAlumno = Convert.ToInt32(this.Parent.Name);
                   
                    dbConection.actualizarCalificacionEntrega(idAlumno, Convert.ToInt32(this.Name), calificacion);
                }
                else //Calificación fuera del rango
                {
                    (sender as TextBox).Text = "";
                }
            }
            else if( pressed == 8 ) //Borrar
            {
                e.Handled = false;
            }
            else //Cualqiuier otro caracter no lo aceptará
            {
                e.Handled = true;
            }
        }
#endregion
    }
}
