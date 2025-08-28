using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC8_0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Decime tu nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine(Bou(nombre));


            Console.ReadKey();
        }

        static string Bou(string nombre)
        {

            string kevin = "Hola " + nombre;

            return kevin;
        }

    }
}
