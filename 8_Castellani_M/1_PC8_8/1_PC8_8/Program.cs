using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int palabra;
            Console.WriteLine(" ingresa tu edad ");
            palabra = int.Parse(Console.ReadLine());
            for (int i = 1; i < palabra; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
