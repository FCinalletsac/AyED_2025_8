using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int palabra;
            Console.Write(" ingresa un numero entero positivo ");
            palabra = int.Parse(Console.ReadLine());
            int pol;
            for (int i = 0; i < palabra; i++)
            {
                pol = palabra - i;
                Console.WriteLine(pol);
                
            }
            Console.ReadKey();
        }
    }
}
