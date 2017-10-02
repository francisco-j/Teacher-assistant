using System;
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
    public partial class FormAgregarMateria : Form
    {
        FormListaMaterias ventanaPadre;

        //para cuando se modifica la materia
        int idMateria;

// **************************** constructores *************************************
        /// <summary> ventana para agregar nuevas materias </summary>
        public FormAgregarMateria(FormListaMaterias ventanaPadre)
        {
            InitializeComponent();
            this.ventanaPadre = ventanaPadre;

            btnGuardar.Click += btnAgregar_Click;
        }

        /// <summary> ventana para modifica una materia existente </summary>
        public FormAgregarMateria(int idMateria)
        {
            InitializeComponent();
            this.idMateria = idMateria;

            //txbNombreMateria.Text = Program.getNombreMateria(idMateria);

            //btnGuardar.Click += btnGuardar_Click;

            //this.Show();
        }


//******************************  eventos a asignar ************************************
        
        /// <summary> para modificar una materia existente </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombreMateria.Text;
            
            if (nombre == string.Empty)
            {
                System.Media.SystemSounds.Beep.Play();
                txbNombreMateria.Focus();
                txbNombreMateria.BackColor = Color.LightSalmon;

            }
            else
            {
                //inicial con mayuscula y el reso minusculas
                nombre = nombre.First().ToString().ToUpper() + nombre.Substring(1).ToLower();

                Program.agregarMateria( nombre, idMateria );
                Program.listaMaterias.cargarBotones();
                this.Dispose();
            }
        }

        /// <summary> para crear una nueva materia </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombreMateria.Text;

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

                int salon = ventanaPadre.getIdGrupo();

                Program.agregarMateria(nombre, salon);
                ventanaPadre.cargarBotones();
                this.Dispose();
            }


        }
    }
}