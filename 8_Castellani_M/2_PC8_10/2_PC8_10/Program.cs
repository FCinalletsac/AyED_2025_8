using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_10
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
            int[,] matriz2 = new int[filas, columnas];
            int[,] matrizsuma = new int[filas, columnas];
            Random random = new Random();

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz2[i, j] = random.Next(1, 50); 
                    matriz[i, j] = random.Next(1, 50);
                }
            }
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizsuma[i, j] = matriz[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Matriz 1:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matriz 2:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matriz Suma:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matrizsuma[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
