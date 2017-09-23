using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;
namespace WindowsFormsApp3
{
    public partial class FormListaGrupos : Form
    {
        private int pixelUltimoBoton;
        private int pixelUltimaLabel;
        private int numeroBotones;
        private Button boton;

        public FormListaGrupos()
        {
            this.Name = "FormListaGrupos";
            InitializeComponent();

            pixelUltimoBoton = 30;
            pixelUltimaLabel = 30;
            numeroBotones = 0;

            for( int i = 0; i < 1; i++, numeroBotones++ )
            {
                boton = new Button();
                containerGrupos.Controls.Add( boton );

                configurarBoton( ref boton, "Grupo" + ( i + 1 ), "Grupo " + ( i + 1 ), 150, 115, 30, ref pixelUltimoBoton, "Microsoft Sans Serif", 20 );

                boton.Click += new System.EventHandler( boton_Click );
                pixelUltimoBoton += 150;
            }
        }

        private void boton_Click(object sender, System.EventArgs e)
        {
            Program.showListaMaterias( ( sender as Button ).Text );
            //Se oculta esta ventana para que cuando se regrese no se vuelva a cargar todo
            this.Hide();
        }

        private void configurarBoton(ref Button boton, string nombre, string text, int ancho, int alto, int x, ref int y, string fuente, int tamañoLetra)
        {
            boton.Name = nombre;
            boton.Text = text;

            System.Drawing.Size tamaño = new System.Drawing.Size();
            tamaño.Width = ancho;
            tamaño.Height = alto;
            boton.Size = tamaño;

            System.Drawing.Point coordenadas = new System.Drawing.Point();
            coordenadas.X = x;
            coordenadas.Y = y;
            boton.Location = coordenadas;

            System.Drawing.Font letra = new System.Drawing.Font( fuente, tamañoLetra );
            boton.Font = letra;
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, System.EventArgs e)
        {
            Program.LogOut( this );
        }

        private void btnAgregarGrupo_Click(object sender, System.EventArgs e)
        {
            numeroBotones++;
            Button botonNuevo = new Button();
            configurarBoton( ref botonNuevo, "Grupo" + numeroBotones, "Grupo " + numeroBotones, 150, 115, 30, ref pixelUltimoBoton, "Microsoft Sans Serif", 20 );
            containerGrupos.Controls.Add( botonNuevo );
            pixelUltimoBoton += 10;

            botonNuevo.Click += new System.EventHandler( boton_Click );
        }
    }
}
