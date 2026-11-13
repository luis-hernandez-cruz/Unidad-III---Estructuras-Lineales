using System.ComponentModel.Design;

namespace Proyecto4_Calculadora
{
    internal class Program
    {
        static int Prioridad(char operador)
        {
            if (operador == '+' || operador == '-')
            {
                return 1;
            }

            if (operador == '*' || operador == '/')
            {
                return 2;
            }

            if (operador == '^')
            {
                return 3;
            }

            return 0;
        }

        static string InfijaAPostfija (string expresion)
        {
            Pila pila = new Pila();
            string salida = "";

            foreach (char caracter in expresion)
            {
                if (char.IsDigit(caracter))
                {
                    salida += caracter;
                }
                else if (caracter == '(')
                {
                    pila.Apilar(caracter);
                }
                else if (caracter == ')')
                {
                    while (!pila.Vacia() && pila.Tope() != '(')
                    {
                        salida += pila.Desapilar();
                    }

                    pila.Desapilar();
                }
                else if ("+-*/^".Contains(caracter))
                {
                    while (!pila.Vacia() && Prioridad(pila.Tope()) >= Prioridad(caracter))
                    {
                        salida += pila.Desapilar();
                    }

                    pila.Apilar(caracter);
                }
            }

            while (!pila.Vacia())
            {
                salida += pila.Desapilar();
            }

            return salida;
        }
        static void Main()
        {
            Console.WriteLine("=== CALCULADORA ===");

            Console.Write("Expresión: ");
            string expresion = Console.ReadLine();

            string postfija = InfijaAPostfija(expresion);
            Console.WriteLine($"Postfija: {postfija}");

            Console.ReadKey();
        }
    }
}