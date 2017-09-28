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

// ************************** set ************************************

        public void SetGrado(ushort grado) //cambiar el grado
        {
            this.grado = grado;
        }

        public void SetGrupo(char grupo) //cambiar el grupo
        {
            this.grupo = grupo;
        }

        public void SetEscuela(String escuela) //cambiar la escuela
        {
            this.escuela = escuela;
        }

// ******************* otros metodos ***************************************

        override public String ToString()
        {
            return grado + "º" + grupo;
        }

        
    }
}
