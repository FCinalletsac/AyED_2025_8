using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_11
{
    internal class Program
    {
        static void Main(string[] args)
         {
            
             Console.WriteLine("inserte tamaño de la matriz ");
             int m = int.Parse(Console.ReadLine());
             int[,] matriz = new int[m, m];
             int[,] rotada = new int[m, m];
             
            Random random = new Random();

            Console.WriteLine("\nmatriz original");
            for (int i = 0; i < m; i++)
             {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(1, 50);
                    Console.Write(matriz[i, j] + "\t");
                    
                }
                Console.WriteLine();
            }

           
            for (int i = 0; i < m; i++)
             { 
                for (int j = 0; j < m; j++)
                {
                    rotada[j, m - 1 - i] = matriz[i, j];
                    
                }
               
             }
              Console.ReadKey();
            Console.WriteLine("\nmatriz rotada 90 grados en sentido horario");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(rotada[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


    }
}
