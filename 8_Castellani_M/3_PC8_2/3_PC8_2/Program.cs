using System;

namespace _3_PC8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int valor1 = 0, valor2 = 0;
            bool salir = false;
            Console.Clear();
            Console.WriteLine("\t--------------Calculadora--------------");
            Console.WriteLine(" 1-Ingresa los numeros");
            Console.WriteLine(" 2-Suma");
            Console.WriteLine(" 3-Resta");
            Console.WriteLine(" 4-Multiplicación");
            Console.WriteLine(" 5-División");
            Console.WriteLine(" 6-Salir");
            opcion = int.Parse(Console.ReadLine());
            
            while (!salir)
            {
                switch (opcion)
                {

                    case 1:
                        Console.WriteLine("Ingrese un valor ");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro valor ");
                        valor2 = int.Parse(Console.ReadLine());

                        break;

                    case 2:
                       
                        Console.WriteLine(Suma(valor1, valor2));
                        break;

                    case 3:
                        Console.WriteLine(Resta(valor1, valor2));
                        break;

                    case 4:
                        Console.WriteLine(Multiplicacion(valor1, valor2));
                        break;

                    case 5:
                        Console.WriteLine(Division(valor1, valor2));
                        break;

                    case 6:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida, por favor intente nuevamente.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nElija una opción:");
                    Console.WriteLine("1-Ingresa los números");
                    Console.WriteLine("2-Suma");
                    Console.WriteLine("3-Resta");
                    Console.WriteLine("4-Multiplicación");
                    Console.WriteLine("5-División");
                    Console.WriteLine("6-Salir");
                    opcion = int.Parse(Console.ReadLine());
                }
            }
        }

        static int Suma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        static int Resta(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        static int Multiplicacion(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        static int Division(int valor1, int valor2)
        {
            if (valor2 == 0)
            {
                Console.WriteLine("Error: División por cero no permitida.");
                return 0; // Se devuelve 0 para evitar la excepción
            }
            return valor1 / valor2;
        }
    }
}