using System;
namespace Proyecto3_Llamadas
{
    internal class Program
    {
        static Pila llamadas = new Pila();

        static void Main()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== SIMULADOR DE LLAMADAS ===");
                Console.WriteLine("1. Registrar llamada");
                Console.WriteLine("2. Borrar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("0. Salir\n");

                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        llamadas.Apilar(Console.ReadLine());
                        break;
                    case 2:
                        string llamada = llamadas.Desapilar();

                        Console.WriteLine(llamada == null ? "No existen llamadas." : $"Borrando a {llamada}");
                        Console.ReadKey();
                        break;
                    case 3:
                        llamadas.Mostrar();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("Ingrese el nombre a buscar: ");
                        string nombre = Console.ReadLine();
                        llamadas.BuscarLlamada(nombre);
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 0);
        }
    }
}