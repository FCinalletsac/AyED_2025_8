using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string franyrobin;
            franyrobin = "franyrobin".ToUpper();
            


            Console.WriteLine("¿Cuál es la contraseña? ");
           

            if (franyrobin == Console.ReadLine().ToUpper())
            {
                Console.WriteLine("es correcta ");
            }
                
            else
                Console.WriteLine("contraseña incorrecta");

            Console.ReadKey();
        }
    }
}
