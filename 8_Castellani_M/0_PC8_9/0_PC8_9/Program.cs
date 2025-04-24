using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            double volumen;
            double Superficie;

            Console.WriteLine(" Ingresa el Radio ");
            numero1 = int.Parse(Console.ReadLine()); 
            volumen = 1.33* 3.14 * numero1*numero1*numero1;
            Superficie = 4 * 3.14 * numero1*numero1;
            Console.WriteLine(" El Volumen es: " + volumen);
            Console.WriteLine(" La Superficie es: " + Superficie);
            Console.ReadKey();
        }
    }
}
