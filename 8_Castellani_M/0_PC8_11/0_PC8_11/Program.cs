using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double ancho;
            double perimetro;
            double area;
            double diagonal;

            Console.WriteLine(" Ingresa la altura ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingresa el ancho ");
            ancho = int.Parse(Console.ReadLine());
            perimetro = altura * 2 + ancho * 2;
            area = altura * ancho;
            diagonal = Math.Sqrt(Math.Pow(altura, 2)+Math.Pow(ancho, 2));
            Console.WriteLine(" El perimetro es: "+ perimetro);
            Console.WriteLine(" El area es: " + area);
            Console.WriteLine(" La diagonal es: " + diagonal);
            Console.ReadKey();
        }
    }
}
