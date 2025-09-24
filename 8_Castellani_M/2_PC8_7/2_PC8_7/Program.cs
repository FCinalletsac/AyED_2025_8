using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int n;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            int[] numero = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                numero[i] = random.Next(1, 10);
            }
             
            do
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Imprimir todos los elementos");
                Console.WriteLine("2. Buscar un número en el vector");
                Console.WriteLine("3. Ordenar el vector ascendente ");
                Console.WriteLine("4. Ordenar el vector descendente ");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elementos del vector:");
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(numero[i]);
                        }
                        break;
                    case 2:

                        Console.Write("Ingrese el número a buscar: ");
                        int buscar = int.Parse(Console.ReadLine());
                        bool encontrado = false;
                        for (int i = 0; i < numero.Length; i++)
                        {
                            if (numero[i] == buscar)
                            {
                                Console.WriteLine($"Número {buscar} encontrado en la posición {i}.");
                                encontrado = true;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine($"Número {buscar} no encontrado.");
                        }

                        break;

                    case 3:

                        int temp;
                        for (int i = 0; i < numero.Length - 1; i++)
                        {
                            for (int j = 0; j < numero.Length - i - 1; j++)
                            {
                                if (numero[j] > numero[j + 1])
                                {
                                    temp = numero[j];
                                    numero[j] = numero[j + 1];
                                    numero[j + 1] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Vector ordenado en orden ascendente.");
                      
                        for (int i = 0; i < numero.Length; i++)
                        {
                            Console.WriteLine(numero[i]);
                        }


                        break;
                    case 4:
                        for (int i = 0; i < n - 1; i++)
                        {
                            for (int j = 0; j < n - i - 1; j++)
                            {
                                if (numero[j] < numero[j + 1])
                                {
                                    int temp2 = numero[j];
                                    numero[j] = numero[j + 1];
                                    numero[j + 1] = temp2;
                                }
                            }
                        }
                        Console.WriteLine("Vector ordenado en orden descendente.");
                        for (int i = 0; i < numero.Length; i++)
                        {
                            Console.WriteLine(numero[i]);
                        }
                        break;
                    case 5:
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;


                }


            } while (!salir);
            Console.ReadKey();  

        }
    }
}

        

    

