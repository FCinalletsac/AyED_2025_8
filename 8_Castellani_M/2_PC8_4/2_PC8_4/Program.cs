using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
               
                {
                    int producto;

                    Console.WriteLine("Ingrese el número de productos vendidos:");
                    producto = int.Parse(Console.ReadLine());
                    int[] valor = new int[producto];
                    for (int i = 0; i < producto; i++)
                    {
                        Console.WriteLine($"Ingrese el valor de cada producto {i + 1}:");
                        valor[i] = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < producto; i++)
                    {
                        for (int j = 0; j < producto - 1; j++)
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

                    for (int i = 0; i < producto; i++)
                    {

                        Console.WriteLine("el valor numero {0} es: {1} ", i + 1, valor[i]);

                    }

                    Console.ReadKey();
                }
            }
        }
    }
    
}
