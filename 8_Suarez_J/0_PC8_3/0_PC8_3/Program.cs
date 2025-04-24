using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            //UI - user interface (Interfaz de Usuario)
            Console.WriteLine("¿Cual es tu nombre? ");

            //instancia el usuario
            nombre = Console.ReadLine(); //tomo el valor por consola y lo igualo en el nombre


            Console.Write("¿Cual es tu edad?: ");

            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Hola " + nombre + ", tu edad es " + edad);
            Console.ReadKey();
        }

    }
}
