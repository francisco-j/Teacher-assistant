using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormListaGrupos : Form
    {
        int pixelUltimoBoton;
        int pixelUltimaLabel;
        Button boton;

        public FormListaGrupos()
        {
            InitializeComponent();

            pixelUltimoBoton = 30;
            pixelUltimaLabel = 30;

            for( int i = 0; i < 5; i++ )
            {
                boton = new Button();
                containerGrupos.Controls.Add( boton );

                configurarBoton( ref boton, "Grupo" + ( i + 1 ), "Grupo " + ( i + 1 ), 150, 115, 30, pixelUltimoBoton, "Microsoft Sans Serif", 20 );

                pixelUltimoBoton += 150;

                boton.Click += new System.EventHandler( boton_Click );
            }
        }

        private void boton_Click(object sender, System.EventArgs e)
        {
            Program.showListaMaterias( boton.Text );
            this.Dispose();
        }

        private void configurarBoton(ref Button boton, string nombre, string text, int ancho, int alto, int x, int y, string fuente, int tamañoLetra)
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
    }
}
