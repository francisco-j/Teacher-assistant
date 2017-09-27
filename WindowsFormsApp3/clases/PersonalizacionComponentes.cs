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
        //constructor privaro para que no lo instancien
        private PersonalizacionComponentes() { }

        //Vector que almacena colores que asignará a los botones que vayan siendo agregados, máximo habrá 10 botones de grupo por lo que se cubren todos los casos
        private static Color[] botonGrupoColores = new Color[10] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };

        public static void configurarBotonGrupo(ref Button boton, Grupo grupo, int color)
        {
            //boton, g.ToString(), g.ToString(), , , int color
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Name = "Grupo " + grupo.ToString();
            boton.Text = "Grupo " + grupo.ToString();
            boton.Size = new Size(150, 115);
            boton.Font = new Font("Microsoft Sans Serif", 20);
            boton.BackColor = botonGrupoColores[color];
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
