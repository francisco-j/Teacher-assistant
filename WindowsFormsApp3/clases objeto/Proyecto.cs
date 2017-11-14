using System;

namespace WindowsFormsApp3.clases_objeto
{
    class Proyecto
    {
        public String nombre { get; set; }
        public int id { get; set; }

        public Proyecto(String nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }
    }
}