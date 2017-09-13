using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Grupo
    {
        private Int16 grado;
        private Char grupo;
        private string escuela;

        public String Nombre()
        {
            return grado + "º" + grupo;
        }

        public void ChangeGrado(Int16 grado)
        {
            this.grado = grado;
        }

    }
}
