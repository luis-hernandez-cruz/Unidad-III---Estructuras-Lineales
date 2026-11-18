using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto6_Tareas
{
    public class ListaDoble
    {
        private Nodo inicio;

        public class Nodo
        {
            public Tarea Datos;
            public Nodo Anterior;
            public Nodo Siguiente;

            public Nodo(Tarea tarea)
            {
                Datos = tarea;
            }
        }

        public void Insertar(Tarea tarea)
        {
            Nodo nuevo = new Nodo(tarea);

            if (inicio == null)
            {
                inicio = nuevo;
                return;
            }

            Nodo actual = inicio;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = nuevo;
            nuevo.Anterior = actual;
        }

        public Tarea Buscar(int id)
        {
            Nodo actual = inicio;

            while (actual != null)
            {
                if (actual.Datos.ID == id)
                    return actual.Datos;

                actual = actual.Siguiente;
            }

            return null;
        }

        public bool Eliminar(int id)
        {
            Nodo actual = inicio;

            while (actual != null)
            {
                if (actual.Datos.ID == id)
                {
                    if (actual.Anterior == null)
                    {
                        inicio = actual.Siguiente;
                        if (inicio != null)
                            inicio.Anterior = null;
                    }
                    else
                    {
                        actual.Anterior.Siguiente = actual.Siguiente;
                        if (actual.Siguiente != null)
                            actual.Siguiente.Anterior = actual.Anterior;
                    }

                    return true;
                }

                actual = actual.Siguiente;
            }

            return false;
        }

        public void Mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo actual = inicio;
            while (actual != null)
            {
                Console.WriteLine(actual.Datos);
                actual = actual.Siguiente;
            }
        }
    }
}