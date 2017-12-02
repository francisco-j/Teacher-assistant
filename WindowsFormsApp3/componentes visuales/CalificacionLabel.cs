using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.componentes_visuales
{
    class CalificacionLabel : Label
    {
        private decimal calificacion;
        public decimal Calificacion
        {
            get { return calificacion; }
            set { calificacion = value / (decimal)10; }
        }

        public CalificacionLabel( int idEntregable, decimal calificacion )
        {
            this.Font = new Font("Microsoft Sans Serif", 16);
            this.Name = idEntregable.ToString();
            this.Size = new Size(44, 26);
            this.FlatStyle = FlatStyle.Flat;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.WhiteSmoke;
            this.Margin = new Padding(0);
            this.Calificacion = calificacion;
            this.Text = calificacion.ToString();

            this.ForeColor = this.calificacion >= 8 ? Color.Black : Color.Red;

            this.MouseClick += clickCalificacionLabel;
            this.MouseEnter += mouseEnterLabel;
            this.MouseLeave += mouseLeaveLabel;
            this.DoubleClick += doubleClickLabel;
        }

        private void doubleClickLabel(object sender, EventArgs e)
        {
            TextBox txtTemp = new TextBox();
            txtTemp.Name = "txtTemp";
            txtTemp.MaxLength = 3;
            txtTemp.KeyPress += txtKeyPress;
            this.Controls.Add(txtTemp);
            txtTemp.Focus();
            txtTemp.LostFocus += txtLostFocus;
        }

        private void txtLostFocus(object sender, EventArgs e)
        {
            this.Controls.RemoveByKey("txtTemp");
        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == 13 || Char.IsDigit(e.KeyChar) || e.KeyChar == 46 || e.KeyChar == 8 )
            {
                if( e.KeyChar == 13 )
                {
                    calificacion = Convert.ToDecimal((sender as TextBox).Text) * 10;//Porque la propiedad lo divide
                    if( calificacion/10 >= 5 && calificacion/10 <=10 )
                    {
                        this.Text = calificacion.ToString();
                        this.Controls.RemoveByKey("txtTemp");

                        int idAlumno = Convert.ToInt32(this.Parent.Name);

                        this.Text = calificacion.ToString();
                        this.ForeColor = this.calificacion >= 8 ? Color.Black : Color.Red;

                        dbConection.actualizarCalificacionEntrega(idAlumno, Convert.ToInt32(this.Name), calificacion);
                    }
                    else
                    {
                        (sender as TextBox).Text = "";
                    }
                }
                else if( e.KeyChar == 46 )
                {
                    if ((this.Controls[0] as TextBox).Text.Contains('.'))
                        e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void clickCalificacionLabel(object sender, MouseEventArgs e)
        {
            if( e.Button == MouseButtons.Right )
            {
                if ( calificacion - (decimal)0.1 < 5)
                    return;
                else
                calificacion -= (decimal)0.1;
            }
            else//( e.Button == MouseButtons.Right )
            {
                if (calificacion + (decimal)0.1 > 10)
                    return;
                else
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
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaLeaveSelected(idAlumno, this.Name);
        }

        private void mouseEnterLabel(object sender, EventArgs e)
        {
            string idAlumno = this.Parent.Name;
            (this.Parent.Parent.Parent.Parent.Parent as FormGrupoMateria).entregaSelected(idAlumno, this.Name);
        }
    }
}
