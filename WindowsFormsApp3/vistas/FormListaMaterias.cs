using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormListaMaterias : Form
    {
        private int pixelUltimoBoton;

        public FormListaMaterias( string nombreGrupo )
        {
            InitializeComponent();

            this.Text = nombreGrupo;
            //Esta varible nos ayudará a saber dónde está posicionado en la pantalla el botón del último grupo
            pixelUltimoBoton = 30;

            /*El ciclo durará dependiendo de la cantidad de grupos que tenga el maestro, pero eso lo sacaremos de la base de datos,
            por el momento pongo 4 para que siempre cargue esos cuatro grupos como prueba*/
            for (int i = 0; i < 4; i++)
            {
                //BOTÓN
                //Se crea un nuevo botón
                Button botonGrupo = new Button();
                //definir el tamaño del botón en pixeles
                botonGrupo.Size = new System.Drawing.Size(150, 115);;

                //Se le establece un nombre al botón generado
                botonGrupo.Text = "Materia " + ( i + 1 );
                //Se le cambia la fuente a las letras del botón
                System.Drawing.Font fuente = new System.Drawing.Font( "Microsoft Sans Serif", 20 );
                botonGrupo.Font = fuente;
                //Se agrega el botón al contenedor que mostrará todos los grupos del maestro
                containerGrupos.Controls.Add( botonGrupo );
                //Se necesita el siguiente objeto para definir las coordenadas del botón en relación al contenedor al que lo agregamos
                System.Drawing.Point coordenadas = new System.Drawing.Point();
                //La coordenada de x siempre será la misma, sólo agregaremos los botones más abajo con una separación de 30 pixeles entre cada uno
                coordenadas.X = 50;
                coordenadas.Y = pixelUltimoBoton;
                botonGrupo.Location = coordenadas;
                //Se aumenta la posición del último botón en 150, la separación ya la tiene por defecto de 30 pixeles entre cada uno
                pixelUltimoBoton += 150;


                //LABEL
                Label lblNombreGrupo = new Label();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.returnToListaGrupos( );
            this.Dispose();
        }

        private void btnGrupA_Click(object sender, EventArgs e)
        {
            Program.ShowGroup(1);
        }

        private void btnGrupB_Click(object sender, EventArgs e)
        {
            Program.ShowGroup(2);
        }

        private void FormListaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // cierra la aplicacion completa
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {

        }

        private void FormListaG_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarDia_Click(object sender, EventArgs e)
        {

        }
    }
}
