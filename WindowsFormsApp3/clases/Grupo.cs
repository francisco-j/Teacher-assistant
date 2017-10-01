using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Grupo
    {
        private int id;
        private int grado;
        private Char grupo;
        private string escuela;

// ******************* constructor **************************

        public Grupo(int id, int grado, char grupo, string escuela) //constructor
        {
            this.id = id;
            this.grado = grado;
            this.grupo = grupo;
            this.escuela = escuela;
        }

// *********************** get ************************************

        public int getId()
        {
            return this.id;
        }

        /// <summary> nombre de la escuela /// </summary>
        public string getEscuela()
        {
            return escuela;
        }

        /// <summary> numero de grado </summary>
        public int getGrado()
        {
            return grado;
        }

        /// <summary> grupo del grupo  EJ: 1ºA -> "A"</summary>
        public string getGrupo()
        {
            return grupo.ToString();
        }

// ************************** set ************************************


// ******************* otros metodos ***************************************

        /// <summary> debuelbe grado + "º" + grupo </summary>
        override public String ToString()
        {
            return grado + "º" + grupo;
        }

        
    }
}
