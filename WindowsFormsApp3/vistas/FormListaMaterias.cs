using System;
using System.Windows.Forms;
using WindowsFormsApp3.clases;

namespace WindowsFormsApp3
{
    public partial class FormListaMaterias : Form
    {
        //grupo del que se estna mostrnado las materias
        private int idGrupo;
        private Materia[] materias;

// ****************************** constructor ***************************************

        /// <summary> ventana que muestra la lista de materias </summary>
        public FormListaMaterias( int idGrupo )
        {
            InitializeComponent();

            this.idGrupo = idGrupo;
            this.Text = Program.getGrupo(idGrupo).ToString();

            cargarBotones();

        }


// ******************** boton evt *****************************************

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.returnToListaGrupos( );
            this.Dispose();
        }

        /*
        private void boton_Click(object sender, System.EventArgs e)
        {
            string materia = (sender as Button).Name.Replace("btnMateria", ""); 
            int idMateria = int.Parse(materia);

            Program.showListaMaterias(idGrupo);
            //Se oculta esta ventana para que cuando se regrese no se vuelva a cargar todo
            this.Hide();
        }
        */

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            Program.busqueda(txbBusqueda.Text);
        }

        private void btnAgregarMateria_Click(object sender, System.EventArgs e)
        {
            throw new ApplicationException();

            //FormAgregarMateria nuevaMateria = new FormAgregarMateria(this);
            //nuevaMateria.ShowDialog(this);
        }
        //*********************************** metodos *****************************

        ///<sumary> limpia el contenedor y carga todas las materias como botones nuevos </sumary>
        public void cargarBotones()
        {

            materias = Program.materiasDeGrupo(idGrupo);

            contenedorGrupos.Controls.Clear();
            int color = 0;

            foreach (Materia materia in materias)
            {
                Button botonMateria = new Button();

                PersonalizacionComponentes.configurarBotonMateria(ref botonMateria, materia, color);
                color++;

                //Se agrega el botón al contenedor
                contenedorGrupos.Controls.Add(botonMateria);
                
            }
        }

// ************************  closing  ***************************************************

        private void FormListaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // cierra la aplicacion completa
        }
    }
}
