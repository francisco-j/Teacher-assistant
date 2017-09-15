using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Grupo
    {
        private ushort grado; //año escolar 1, 2, 3, 4, 5, o 6
        private Char grupo; //letra alfabetica
        private string escuela; //nombre de la escuela

        public String Nombre()
        {
            return grado + "º" + grupo;
        }

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

        public Grupo(ushort grado, char grupo, string escuela) //constructor
        {
            this.grado = grado;
            this.grupo = grupo;
            this.escuela = escuela;
        }
        
    }
}
