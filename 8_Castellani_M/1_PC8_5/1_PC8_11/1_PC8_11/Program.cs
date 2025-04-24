using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.WriteLine(" Ingresa un numero entero");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
               if ((i %2)==0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadKey();
        }
    }
}
