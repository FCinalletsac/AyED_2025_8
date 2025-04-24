using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC8_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.WriteLine("Escribi 3 letras ");
            palabra = Console.ReadLine();

            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            String cadenainvertida = new string(caracteres);

            Console.Write(cadenainvertida);



 
            Console.ReadKey();
        }
    }
}
