using System;

namespace Proyecto2_Restaurante
{
    public class Nodo
    {
        public Cliente Datos { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Cliente cliente)
        {
            Datos = cliente;
            Siguiente = null;
        }
    }
}
