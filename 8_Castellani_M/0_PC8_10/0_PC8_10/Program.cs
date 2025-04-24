using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC8_10
{
    class Program
    {
        static void Main(string[] args)
        {

             double grados;
             double farheint;
             double kelvin;

            Console.WriteLine(" Ingresa Los Grados centigrados");
            grados = int.Parse(Console.ReadLine());
            farheint = grados * 1.8 + 32;
            Console.WriteLine(" Tu numero en Fahrenheit es: "+ farheint);
            kelvin = grados + 273.15;
            Console.WriteLine(" Tu numero en kelvin es  "+ kelvin);
            Console.ReadKey();
        }
    }
}
