using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.clases
{
    class Materia
    {
        private int id;
        private string nombre;
        private int salon;

// ******************************* constructor ************************
        public Materia(int id, string nombre, int salon)
        {
            this.id = id;
            this.nombre = nombre;
            this.salon = salon;
        }

// ********************************** geters *******************************
        internal int getId()
        {
            return id;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string toString()
        {
            return nombre;
        }
    }
}
