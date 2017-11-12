using System;

namespace WindowsFormsApp3.clases_objeto
{
    class Tarea
    {
        public String nombre { get; set; }
        public int id { get; set; }

        public Tarea(String nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }
    }
}
