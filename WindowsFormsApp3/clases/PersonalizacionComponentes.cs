using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

/*Esta clase será la encargada de guardar los métodos que usaremos para personalizar los botones, labels y demás componenetes
 que estaremos generando en tiempo de ejecución, cabe aclarar que todos serán static para que 
 no sea necesario instanciarlos*/
namespace WindowsFormsApp3
{
    class PersonalizacionComponentes
    {
        /*
        private Color[ ] coloresBotones = new Color[ 10 ] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };

        public enum Colores : int { Aqua = 0, Beige, Rojo, Rosa, Amarillo, Blanco, Nieve, Plateado, Salmon, AzulRoyal };
        */

        public static void configurarBoton(ref Button boton, string nombre, string text, Size tamanio, Font fuente, Color color)
        {
            boton.Name = nombre;
            boton.Text = text;
            boton.Size = tamanio;
            boton.Font = fuente;
            boton.BackColor = color;
        }

        public static void configurarLabelGrupos( ref Label etiqueta, string texto, Font fuente )
        {
            etiqueta.AutoSize = true;
            etiqueta.Text = texto;
            etiqueta.Font = fuente;
            etiqueta.ForeColor = Color.Black;
        }
    }
}
