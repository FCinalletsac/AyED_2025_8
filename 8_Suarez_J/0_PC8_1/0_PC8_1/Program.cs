using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //caso 1
            string variable1; //declaramos variable
            variable1 = ("Hola mundo"); //instanciamos variable1
            Console.WriteLine(variable1); //imprimimos variable1
            Console.ReadKey();

            //caso 2
            string variable2 = ("Hola mundo!"); //Manera mas optimizada
            Console.WriteLine(variable2);
            Console.ReadKey();  
        }
    }
}
