using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double grados;
            Console.WriteLine(" cuantos grados tiene");
            grados = double.Parse(Console.ReadLine());
            if (grados >= 100)
            {
                Console.WriteLine(" Esta hirviendo ");
            }
            else if (grados <= 0)
            {
                Console.WriteLine(" Esta congelado ");

            }
            else 
            {
                Console.WriteLine(" Esta en estado liquido ");
            }
            Console.ReadKey();
    }
    }
}
