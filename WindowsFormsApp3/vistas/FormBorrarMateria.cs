﻿using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

namespace WindowsFormsApp3.vistas
{
    public partial class FormBorrarMateria : Form
    {
        Materia materia;

        public FormBorrarMateria(Materia materia)
        {
            InitializeComponent();

            this.materia = materia;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txbNombreMateria.Text == materia.getNombre())
            {
                Program.borrarMateria(materia.getId());
                this.Dispose();
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                txbNombreMateria.Focus();
                txbNombreMateria.BackColor = Color.LightSalmon;

            }
        }
    }
}