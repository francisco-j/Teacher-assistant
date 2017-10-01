using System;
using System.Windows.Forms;
using WindowsFormsApp3.clases;
using WindowsFormsApp3.vistas;

namespace WindowsFormsApp3
{
    public partial class FormListaMaterias : Form
    {
        private int idGrupo;
        private Materia[] materias;

        // ****************************** constructor ***************************************

        /// <summary> ventana que muestra la lista de materias </summary>
        /// <param name="idGrupo"> id del grupo cuyas materias se mostraran </param>>
        public FormListaMaterias(int idGrupo)
        {
            InitializeComponent();

            this.idGrupo = idGrupo;
            this.Text = Program.getGrupo(idGrupo).ToString();

            cargarBotones();

            this.Show();

        }

        internal int getIdGrupo()
        {
            return idGrupo;
        }


        // ******************** boton evt *****************************************

        /// <summary> evento para los botonesMateria </summary>
        private void boton_Click(object sender, System.EventArgs e)
        {
            string materia = (sender as Button).Name.Replace("btnMateria", "");
            int idMateria = int.Parse(materia);

            Program.showGrupoMateria(idMateria, idGrupo);
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.returnToListaGrupos();
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            Program.busqueda(txbBusqueda.Text);
        }

        private void btnAgregarMateria_Click(object sender, System.EventArgs e)
        {
            FormAgregarMateria nuevaMateria = new FormAgregarMateria(this);
            nuevaMateria.ShowDialog(this);
        }

        //*********************************** metodos *****************************

        ///<sumary> limpia el contenedor y carga todas las materias como botones nuevos </sumary>
        public void cargarBotones()
        {

            materias = Program.materiasDeGrupo(idGrupo);

            contenedorGrupos.Controls.Clear();
            int color = 0;

            Button boton;

            foreach (Materia materia in materias)
            {
                boton = new Button();
                boton.Click += new EventHandler(boton_Click);

                PersonalizacionComponentes.configurarBotonMateria(ref boton, materia, color);
                color++;

                //Se agrega el botón al contenedor
                contenedorGrupos.Controls.Add(boton);

            }
        }

        // ************************  closing  ***************************************************

        private void FormListaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // cierra la aplicacion completa
        }
    }
}