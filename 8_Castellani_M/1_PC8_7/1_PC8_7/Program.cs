using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.WriteLine(" ingresa una palabra ");
             palabra = Console.ReadLine();
            for (int i=0;i<10; i++)
            {
                Console.WriteLine(palabra);
            }
            Console.ReadKey();
        }
    }
}
