using System;
using Proyecto1_Clinica;

namespace Proyecto1_Clinica
{
    internal class Program
    {
        static Cola pacientes = new Cola();

        static void Main()
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("===CLINICA===");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Atender paciente");
                Console.WriteLine("3. Mostrar paciente");
                Console.WriteLine("4. Salir");
                Console.Write("Opcion: ");

                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Seleccione entre las opciones.");
                }

                switch (opcion)
                {
                    case 1:
                        Registrar();
                        break;
                    case 2:
                        Atender();
                        break;
                    case 3:
                        pacientes.Mostrar();
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 4);
        }
        static void Registrar()
        {
            Console.Clear();

            Console.Write("Expediente: ");
            int expediente = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Prioridad: ");
            int prioridad = int.Parse(Console.ReadLine());

            Paciente paciente = new Paciente(expediente, nombre, edad, prioridad);
            pacientes.Encolar(paciente);

            Console.WriteLine("Paciente registrado.");
            Console.ReadKey();
        }

        static void Atender()
        {   
            Paciente paciente = pacientes.Desencolar();

            if (paciente == null)
            {
                Console.WriteLine("No hay pacientes.");
            }
            else
            {
                Console.WriteLine("Atendido.");
            }

            if (paciente != null)
            {
                Console.WriteLine(paciente);
            }
        }
    }
}