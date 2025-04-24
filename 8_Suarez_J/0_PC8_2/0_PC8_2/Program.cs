using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos Variables
            string nombre;
            int edad;

            //Instanciamos
            nombre = "Lautaro Suárez";
            edad = 16;

            //Imprimimos
            Console.WriteLine("Hola " + nombre + " 
                tu edad es " + edad);
            Console.ReadKey(); 
        }
    }
}
