using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                {

                    {
                        int elementos;
                        int valorminimo;    
                        Console.WriteLine("Ingrese el número de elementos que desea analizar:");
                        elementos = int.Parse(Console.ReadLine());
                        int[] valor = new int[elementos];
                        Console.WriteLine("\nIngrese el valor minimo que deben tener los objetos:");
                        valorminimo=int.Parse(Console.ReadLine());
                        for (int i = 0; i < elementos; i++)
                        {
                            Console.WriteLine($"\nIngrese el valor de cada producto {i + 1}:");
                            valor[i] = int.Parse(Console.ReadLine());
                            if (valor[i] < valorminimo)
                            {
                                Console.WriteLine("El valor ingresado es menor al valor minimo, por favor ingrese un valor valido.");
                                i--; // Decrementamos i para repetir la iteración actual
                                continue; // Saltamos al inicio del bucle para pedir el valor nuevamente
                            }   
                        }
                       
                        for (int i = 0; i < elementos; i++)
                        {
                            for (int j = 0; j < elementos - 1; j++)
                            {
                                if (valor[j] < valor[j + 1])
                                {
                                    int temp = valor[j];
                                    valor[j] = valor[j + 1];
                                    valor[j + 1] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Los valores de mayor a menor son: ");

                        for (int i = 0; i < elementos; i++)
                        {

                            Console.WriteLine("el valor numero {0} es: {1} ", i + 1, valor[i]);

                        }

                        Console.ReadKey();
                    }
                }
            }
        }

    }
}
    

