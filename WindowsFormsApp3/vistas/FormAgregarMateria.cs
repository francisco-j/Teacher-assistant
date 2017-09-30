using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.vistas
{
    public partial class FormAgregarMateria : Form
    {
        FormListaMaterias ventanaPadre;

        /// <summary> ventana para agregar nuevas materias </summary>
        /// <param name="ventanaPadre"> FormListaMaterias padre </param>
        public FormAgregarMateria(FormListaMaterias ventanaPadre)
        {
            InitializeComponent();

            this.ventanaPadre = ventanaPadre;
        }

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
                nombre = nombre.First().ToString().ToUpper() + nombre.Substring(1);

                int salon = ventanaPadre.getIdGrupo();

                Program.agregarMateria(nombre, salon);
                ventanaPadre.cargarBotones();
                this.Dispose();
            }


        }
    }
}