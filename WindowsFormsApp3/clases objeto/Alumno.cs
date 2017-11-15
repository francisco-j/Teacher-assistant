using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WindowsFormsApp3.clases_objeto
{
    public class Alumno
    {
        private int id;
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private int grupo;

//***********************************  constructor **********************************************
    
        /// <summary> para lecturas </summary>
        public Alumno(int id, string nombre, string apellidoP, string apellidoM, int grupo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.grupo = grupo;
        }

        /// <summary> para cuando recien se crea un alumno y se va a agregar a la DB </summary>
        public Alumno(int grupo, string nombre, string apellidoP, string apellidoM)
        {
            string[] nombres = nombre.Split(' ');
            nombre = "";
            foreach (string name in nombres)
                nombre += ' ' + name.First().ToString().ToUpper() + name.Substring(1);

            this.nombre = nombre.Trim();
            this.apellidoP = apellidoP.First().ToString().ToUpper() + apellidoP.Substring(1);
            this.apellidoM = apellidoM.First().ToString().ToUpper() + apellidoM.Substring(1);
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

// ******************************* geters *********************************************************

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
