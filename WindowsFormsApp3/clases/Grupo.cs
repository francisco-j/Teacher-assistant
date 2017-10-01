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

        public string getEscuela()
        {
            return escuela;
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
