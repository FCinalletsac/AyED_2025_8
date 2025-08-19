using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    using System.Threading.Tasks;

    namespace _3_PC8_1
    {
    using System;

    class Program
        {
            static string saludo(string nombre)
        {
            return "Hola " + nombre + " bienvenido a C#.";
        }
            
            static void Main(string[] args)
            {
                 
                   string mensaje = saludo ("Lautaro");
                    Console.WriteLine(mensaje);
                    Console.ReadKey();
                }
            }
        }
    
