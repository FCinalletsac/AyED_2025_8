using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string refugio,comida,bate;
           
            Console.WriteLine(" Tenes comida ");
            comida= Console.ReadLine().ToUpper();
            Console.WriteLine(" Tenes refugio ");
            refugio= Console.ReadLine().ToUpper();
            Console.WriteLine(" Tenes un bate ");
            bate = Console.ReadLine().ToUpper();
            if (comida == "si".ToUpper() && refugio == "si".ToUpper() && bate == "si".ToUpper())
            {
             
            Console.WriteLine(" sobrevivis");

            }
            else
            {
                Console.WriteLine(" No sobrevivis");

            }
            Console.ReadKey();
        


        }

    }
}
