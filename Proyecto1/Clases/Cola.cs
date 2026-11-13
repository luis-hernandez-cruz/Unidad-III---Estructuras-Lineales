using System;

namespace Proyecto1_Clinica
{
    public class Cola
    {
        private Nodo frente;
        private Nodo final;

        public Cola()
        {
            frente = null;
            final = null;
        }

        public void Encolar(Paciente paciente)
        {
            Nodo nuevo = new Nodo(paciente);
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }
        }

        public Paciente Desencolar()
        {
            if (frente == null)
            {
                return null;
            }

            Paciente paciente = frente.Datos;
            frente = frente.Siguiente;

            if (frente == null)
            {
                final = null;
            }

            return paciente;
        }

        public void Mostrar()
        {
            if (frente == null)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }

            Nodo aux = frente;

            while (aux != null)
            {
                Console.WriteLine(aux.Datos.ToString());
                aux = aux.Siguiente;
            }
        }
    }
}