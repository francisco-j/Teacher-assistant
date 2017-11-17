using System;

namespace WindowsFormsApp3.clases_objeto
{
    class Examen
    {
        public String nombre { get; set; }
        public int id { get; set; }

        public Examen(String nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }
    }
}
