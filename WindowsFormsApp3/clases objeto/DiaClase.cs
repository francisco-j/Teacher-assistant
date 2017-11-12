using System;

namespace WindowsFormsApp3.clases_objeto
{
    class DiaClase
    {
        public DateTime dia { get; set; }
        public int idGrupo { get; set; }

        public DiaClase(DateTime fecha, int id)
        {
            dia = fecha;
            idGrupo = id;
        }
    }
}
