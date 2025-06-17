using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bou = new int[4];
            
            for (int i = 0; i < bou.Length; i++)
                 {
                Console.WriteLine(" ingresa el tiempo de tu carrera n" + (i + 1));
                bou[i] = int.Parse(Console.ReadLine());
                 }
            int mejortiempo = bou[0];
            for (int i = 0; i < bou.Length; i++)
            {
                if (mejortiempo > bou[i])
                {
                    mejortiempo = bou[i];
                }
            }

            Console.WriteLine((bou[0] + bou[1] + bou[2] + bou[3])+ ": Este es el tiempo de toda la carrera ");
            Console.WriteLine(((bou[0] + bou[1] + bou[2] + bou[3])/4) + ": Este es el promedio x vuelta ");
            Console.WriteLine(mejortiempo + " es la vuelta mas rapida ");
            Console.ReadKey();
        }
    }
}
