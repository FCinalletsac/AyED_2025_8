using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8__9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserte tamaño de fila ");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("inserte tamaño de columna ");
            int columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            Random random = new Random();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = random.Next(1,50);
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
