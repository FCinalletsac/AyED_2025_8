using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;
            Console.WriteLine("Ingresa un valor ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un valor ");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es " + Bou(valor1, valor2));
            Console.ReadKey();

        }
        static int Bou(int valor1, int valor2)
        {
            int resultado;
            resultado = valor1 + valor2;





            return resultado;
        }

    }
}
