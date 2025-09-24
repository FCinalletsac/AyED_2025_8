using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ingresa la cantidad de alumnos : ");
            n=int.Parse(Console.ReadLine());
            string[,] matriz = new string[n, 3];
           
            for (int i = 0; i < n; i++)
            {
                Console.Write("ingresa el nombre del alumno " + (i + 1) + ": ");
                matriz[i, 0] = Console.ReadLine();
                Console.Write("ingresa la nota del alumno " + (i + 1) + ": ");
                matriz[i, 1] = Console.ReadLine();
                Console.Write("ingresa la edad del alumno " + (i + 1) + ": ");
                matriz[i, 2] = Console.ReadLine();
                
                
            }
            Console.WriteLine();    
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Alumno " + (i + 1) + ":");
                Console.WriteLine("Nombre: " + matriz[i, 0]);
                Console.WriteLine("Nota: " + matriz[i, 1]);
                Console.WriteLine("Edad: " + matriz[i, 2]);
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
