using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int participantes;

            Console.WriteLine("Ingrese el número de participantes:");
            participantes = int.Parse(Console.ReadLine());
            int [] puntaje = new int[participantes];
            for(int i = 0; i < participantes; i++)
            {
                Console.WriteLine($"Ingrese el puntaje del participante {i + 1}:");
                puntaje[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < participantes; i++)
            {
                for(int j = 0; j < participantes- 1; j++)
                {
                    if (puntaje[j] < puntaje[j + 1])
                    {
                        int temp = puntaje[j];
                        puntaje[j] = puntaje[j + 1];
                        puntaje[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Los puntajes de mayor a menor son: ");

            for (int i = 0; i < participantes; i++)
            {

                Console.WriteLine("el puntaje numero {0} es: {1} ", i + 1, puntaje[i]);

            }

            Console.ReadKey();
        }
    }
}
