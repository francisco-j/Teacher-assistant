using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsApp3.clases;
using System.Collections.Generic;

/// <summary> clase encargada de guardar los métodos que usaremos para personalizar componentes como:
/// los botones, labels y demás componenetes que estaremos generando en tiempo de ejecución
/// todos los metodos son static por que la clase no se instancia </summary>
namespace WindowsFormsApp3
{
    class PersonalizacionComponentes
    {

        /// <summary> colores que se asignan a los botones de grupos, máximo habrá 10 botones de grupos </summary>
        private static Color[] botonGrupoColores = new Color[10] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };
        /// <summary> colores que se asignan a los botones de materias, máximo habrá 10 botones de materias </summary>
        private static Color[] botonMateriaColores = new Color[10] { Color.Aqua, Color.Beige, Color.Red, Color.Pink, Color.Yellow, Color.White, Color.Snow, Color.Silver, Color.Salmon, Color.RoyalBlue };
        private static Font miFuente = new Font("Microsoft Sans Serif", 20);

        //********************************** constructor **************************************

        //privado para que no lo instancien
        private PersonalizacionComponentes() { }


        // **************************************  metodos ********************************************

        /// <summary> debuelbe el contenedor con la informacion del grupo indicado </summary>
        /// <param name="boton"> contenedor a decorar </param>
        /// <param name="grupo"> grupo del que se tomara la informacion </param>
        public static FlowLayoutPanel hacerConternedorGrupo(ref Button boton, Grupo grupo)
        {
            FlowLayoutPanel contenedor = new FlowLayoutPanel();

            contenedor.AutoSize = true;
            contenedor.Controls.Add(boton);


            Label escuela = new Label();
            escuela.Text += "Primaria " + grupo.getEscuela();
            escuela.Text += "\n";
            escuela.Text += Program.numeroAlumnosEn(grupo.getId()) + " alumnos";
            contenedor.Controls.Add(escuela);

            return contenedor;
        }

        /// <summary> debuelbe el boton con la informacion del grupo indicado </summary>
        /// <param name="grupo"> grupo del que se tomara la informacion </param>
        /// <param name="color"> color del boton </param>
        public static Button hacerBotonGrupo(Grupo grupo, int color)
        {
            Button boton = new Button();
            boton.Font = miFuente;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = botonGrupoColores[color];

            boton.Text = grupo.ToString();
            boton.Size = new Size(150, 115);
            boton.Name = "btnGrupo" + grupo.getId();
            return boton;
        }

        /// <summary> decora el boton con la informacion de la materia indicada </summary>
        /// <param name="boton"> boton a decorar </param>
        /// <param name="materia"> materia de la que se tomara la informacion </param>
        /// <param name="color"> color del boton </param>
        public static void configurarBotonMateria(ref Button boton, Materia materia, int color)
        {
            boton.Font = miFuente;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = botonMateriaColores[color];

            boton.Text = materia.toString();
            boton.Size = new Size(180, 70);
            boton.Name = "btnMateria" + materia.getId();
        }
        
    }
}
