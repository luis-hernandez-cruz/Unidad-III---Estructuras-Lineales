using System;
using System.Collections.Generic;
using System.Text;
using Proyecto6_tareas;
using Proyecto6_Tareas;

namespace Proyecto6_tareas
{
    class Program
    {
        static void Main()
        {
            ListaDoble lista = new ListaDoble();
            int opcion;

            do
                {
                Console.Clear();
                Console.WriteLine("===== ADMINISTRADOR DE TAREAS =====");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea");
                Console.WriteLine("3. Buscar tarea");
                Console.WriteLine("4. Mostrar todas las tareas");
                Console.WriteLine("5. Salir");
                
                Console.Write("Opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Opción no válida.");
                }
                
                switch (opcion)
                {
                    case 1: 
                        Console.Write("ID: ");
                        int id;
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Ingrese un ID válido.");
                        }
                        
                        Console.Write("Descripción: ");
                        string descripcion = Console.ReadLine();

                        lista.Insertar(new Tarea(id, descripcion));
                        Console.WriteLine("Tarea agregada correctamente.");
                        break;

                    case 2: 
                        Console.Write("ID de la tarea: ");
                        int idEliminar = int.Parse(Console.ReadLine());

                        if (lista.Eliminar(idEliminar))
                        {
                            Console.WriteLine("Tarea eliminada.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró la tarea.");
                        }
                        break;

                    case 3:
                        Console.Write("ID de la tarea: ");
                        int idBuscar = int.Parse(Console.ReadLine());

                        Tarea encontrada = lista.Buscar(idBuscar);
                        if (encontrada != null)
                        {
                            Console.WriteLine("Encontrada: " + encontrada);
                        }
                        else
                            Console.WriteLine("Tarea no encontrada.");
                        Console.ReadKey();
                        break;

                    case 4: 
                        Console.WriteLine("\n=== Lista de tareas ===");
                        lista.Mostrar();
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 5);
        }
    }
}