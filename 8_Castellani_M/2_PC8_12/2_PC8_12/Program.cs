using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n;
            Console.WriteLine("Ingrese el tamaño de la matriz cuadrada:");
            n=int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            int[] diagonal = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                     matriz[i,j]= random.Next(1,50); 


                }
            }
            Console.WriteLine("\nEsta es la matriz :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                diagonal[i] = matriz[i, i];
            }
            Console.WriteLine("Esta es la diagonal :");
            for (int i = 0; i < n; i++)
            {
                Console.Write(diagonal[i] + "\t");
            }
            Console.WriteLine();
            
            Console.ReadKey();  

        }
    }
}
