using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, ingresos;
            Console.WriteLine(" ingresa tu edad ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa tus ingresos mensuales ");
            ingresos = int.Parse(Console.ReadLine());
            if (edad == 19 && ingresos <= 50000) 
            {
               Console.WriteLine(" Podes cobrar la beca ");
               }
            else if (edad > 19 && ingresos <= 100000) 
            {
                Console.WriteLine(" Podes cobrar la beca ");
            }
             else if (edad < 19 && ingresos == 0) 
            {
                Console.WriteLine(" Podes cobrar la beca ");
            }
            else
            {
                Console.WriteLine(" No podes cobrar la beca ");
            }
            Console.ReadKey();




        }
    }
}
