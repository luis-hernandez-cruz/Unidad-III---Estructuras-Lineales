using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto6_Tareas
{
    public class Tarea
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Tarea (int id, string descripcion)
        {
            ID = id;
            Descripcion = descripcion;
            Estado = "Pendiente";
        }

        public override string ToString()
        {
            return $"{ID} -- {Descripcion} -- {Estado}";
        }
    }
}