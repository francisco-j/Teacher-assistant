using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Alumno
    {
        private int id;
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private int grupo;

//***********************************  constructor **********************************************
        public Alumno(int id, string nombre, string apellidoP, string apellidoM, int grupo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.grupo = grupo;
        }
        public Alumno(int grupo, string nombre, string apellidoP, string apellidoM)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.grupo = grupo;
        }

        //************************************* metodos ****************************************************

        /// <summary> debuelbe el nombre del alumno por nombre </summary>
        public string nombreCompletoPN()
        {
            return nombre + " " + apellidoP + " " + apellidoM;
        }

        /// <summary> debuelbe el nombre del alumno por apellidos </summary>
        public string nombreCompletoPA()
        {
            return apellidoP + " " + apellidoM + " " + nombre;

        }

        public int getGupo()
        {
            return grupo;
        }

        public int getId()
        {
            return id;
        }

        public string getNombres()
        {
            return nombre;
        }

        public string getPaterno()
        {
            return apellidoP;
        }

        public string getMaterno()
        {
            return apellidoM;
        }
    }
}
