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


// ******************** boton evt *****************************************

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.returnToListaGrupos();
            this.Dispose();
        }

        private void btnAgregarMateria_Click(object sender, System.EventArgs e)
        {
            FormAgregarMateria nuevaMateria = new FormAgregarMateria(this);
            nuevaMateria.ShowDialog(this);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            new FormResultadoBusqueda(txbBusqueda.Text);
        }

//*********************************** metodos *****************************

        public int getIdGrupo()
        {
            return idGrupo;
        }

        ///<sumary> limpia el contenedor y carga todas las materias como botones nuevos </sumary>
        public void cargarBotones()
        {

            materias = Program.materiasDeGrupo(idGrupo);

            contenedorGrupos.Controls.Clear();
            int color = 0;

            foreach (Materia materia in materias)
            {
                Button boton = PersonalizacionComponentes.configurarBotonMateria(materia, color);
                contenedorGrupos.Controls.Add(boton);
                
                color++;
            }
        }

// ************************  closing  ***************************************************

        private void FormListaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            // cierra la aplicacion completa
            Application.Exit(); 
        }

    }
}