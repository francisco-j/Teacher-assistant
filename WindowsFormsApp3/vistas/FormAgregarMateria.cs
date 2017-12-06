using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using WindowsFormsApp3.clases_objeto;

namespace WindowsFormsApp3.vistas
{
    public partial class FormAgregarMateria : Form
    {
        int idGrupo;
        string nombreAnterior;

        //para cuando se modifica la materia
        int idMateria;

// **************************** constructores *************************************
        /// <summary> ventana para agregar nuevas materias </summary>
        public FormAgregarMateria(int idGrupo)
        {
            InitializeComponent();
            this.idGrupo = idGrupo;

            btnGuardar.Click += btnAgregar_Click;
        }

        /// <summary> ventana para modifica una materia existente </summary>
        public FormAgregarMateria(Materia materia)
        {
            InitializeComponent();
            this.idMateria = materia.getId();
            txbNombreMateria.Text = materia.getNombre();

            nombreAnterior = materia.getNombre();

            btnGuardar.Click += btnGuardar_Click;
        }


//******************************  eventos a asignar ************************************

        /// <summary> para modificar una materia existente </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombreMateria.Text.Trim();

            if (nombre == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbNombreMateria.Focus();
                txbNombreMateria.BackColor = Color.LightSalmon;
            }
            else
            {
                //inicial con mayuscula y el reso minusculas
                nombre = nombre.First().ToString().ToUpper() + nombre.Substring(1);

                Console.WriteLine("Partner: " + this.Owner.Name + " Editar: " + nombreAnterior);
                (this.Owner as frmMaterias).modificacionMateria( nombre, idMateria, nombreAnterior);
                dbConection.modificarMateria(idMateria, nombre );
                this.Dispose();
            }
        }

        /// <summary> para crear una nueva materia </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombreMateria.Text.Trim();

            if (nombre == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbNombreMateria.Focus();
                txbNombreMateria.BackColor = Color.LightSalmon;

            }
            else
            {
                //inicial con mayuscula y el reso normal
                nombre = nombre.First().ToString().ToUpper() + nombre.Substring(1);

                (this.Owner as frmMaterias).recibirMateria( new Materia( dbConection.agregarMateria(nombre, idGrupo), nombre, idGrupo ) );

                this.Dispose();
            }
        }

        private void txbNombreMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnGuardar.PerformClick();
            }
        }
    }
}