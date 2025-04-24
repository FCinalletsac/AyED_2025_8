using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_3
{
    class Program
    {
        static void Main(string[] args)

        {
            int numerovich;
            Console.WriteLine(" Ingrese un numero entero");
            numerovich = int.Parse(Console.ReadLine());
            if (numerovich%2 ==0)
                {
                Console.WriteLine("este numero es par ");
            }
            else
            {
                Console.WriteLine(" el numero es impar ");
            }
            if (numerovich ==0)
                Console.WriteLine(" tu numero es 0 ");

            Console.ReadKey();

               
        }
    }
}
