using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            
            if (numero >= 18)

            {
                Console.WriteLine("es mayor de edad ");
            }

            

            else
            {
                    Console.WriteLine("es menor de edad ");
            }
            Console.ReadKey();
        }
    }
}
