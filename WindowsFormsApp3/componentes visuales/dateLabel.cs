﻿using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace WindowsFormsApp3.componentes_visuales
{
    class dateLabel: Label
    {

//**************** Propiedades *************************************
        private DateTime fecha;
        private double rotationAngle;
        private string text;

        [Description("Fecha a mostrar"), Category("Appearance")]
        public DateTime Fecha
        {
            get { return fecha; }
            set
            {
                fecha = value;
                this.Invalidate();
            }
        }

        [Description("Rotation Angle"), Category("Appearance")]
        public double RotationAngle
        {
            get { return rotationAngle; }
            set
            {
                rotationAngle = value;
                this.Invalidate();
            }
        }

        [Description("Display Text"), Category("Appearance")]
        public override string Text
        {
            get { return text; }
            set
            {
                text = value;
                this.Invalidate();
            }
        }

//******************************** constructor **********************************
        public dateLabel(){
			//Setting the initial condition.
			rotationAngle = 0d;
			this.Size = new Size(105,12);
        }

    //****************************** metodo **************************************
    protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.Trimming = StringTrimming.None;

            Brush textBrush = new SolidBrush(this.ForeColor);

            //Getting the width and height of the text, which we are going to write
            float width = graphics.MeasureString(text, this.Font).Width;
            float height = graphics.MeasureString(text, this.Font).Height;

            //For rotation, who about rotation?
            double angle = (rotationAngle / 180) * Math.PI;
            graphics.TranslateTransform(
                (ClientRectangle.Width + (float)(height * Math.Sin(angle)) - (float)(width * Math.Cos(angle))) / 2,
                (ClientRectangle.Height - (float)(height * Math.Cos(angle)) - (float)(width * Math.Sin(angle))) / 2);
            graphics.RotateTransform((float)rotationAngle);
            graphics.DrawString(text, this.Font, textBrush, 0, 0);
            graphics.ResetTransform();
        }

    }
}