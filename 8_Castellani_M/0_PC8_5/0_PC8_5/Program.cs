using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;

            Console.WriteLine(" Ingresa un numero ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingresa otro numero ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 - numero2;
            Console.WriteLine(" El resultado de la Resta es: " + resultado);
            Console.ReadKey();
        }
    }
}
