using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC8_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");
            // 1) Generar mano aleatoria
            string[] mano = GenerarManoAleatoria();
            // 2) Determinar tipo de mano
            string tipo = TipoDeMano(mano);
            // 3) Calcular puntaje base


            int basePts = PuntajeBase(mano);
            // 4) Obtener multiplicador
            double mult = Multiplicador(tipo);
            // 5) Calcular puntaje final
            double total = basePts * mult;
            // 6) Aplicar jokers
            bool jokerX2 = true;
            bool jokerMas10 = true;
            total = AplicarJokers(total, jokerX2, jokerMas10);
            // 7) Mostrar resumen final
            MostrarResumen(mano, tipo, basePts, mult, total);
            Console.ReadKey();
        }
       
        static string[] GenerarManoAleatoria()
        {
            Random rand = new Random();
            string[] palo = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] rango = { "H", "D", "C", "S" };

            string[] mano = new string[5];
            for (int i = 0; i < 5; i++)
            {
                mano[i] = palo[rand.Next(palo.Length)] + rango[rand.Next(rango.Length)];
            }
            return (mano);
        }
        static string TipoDeMano(string[] mano)
        {
            int poker = 0;
            int trio = 0;
            int pares = 0;

            for (int i = 0; i < mano.Length; i++)
            {
                int iguales = 0;
                for (int j = 0; j < mano.Length; j++)
                {
                    if (i != j && mano[i][0] == mano[j][0])
                    {
                        iguales++;
                    }
                }


                if (iguales == 3) poker++;
                else if (iguales == 2) trio++;
                else if (iguales == 1) pares++;
            }


            pares /= 2;

            if (poker > 0) return "Poker";
            if (trio > 0 && pares > 0) return "Full";
            if (trio > 0) return "Trio";
            if (pares > 0) return "Par";
            return "Nada";
        }

        static int PuntajeBase(string[] mano)
        {
            int sum = 0;
            for (int i = 0; i < mano.Length; i++)
            {
                char r = mano[i][0];
                if (r == 'A') sum += 14;
                else if (r == 'K') sum += 13;
                else if (r == 'Q') sum += 12;
                else if (r == 'J') sum += 11;
                else if (r == 'T') sum += 10;
                else sum += r - '0';
            }
            return sum;
        }

        static double Multiplicador(string tipo)
        {
            if (tipo == "Poker") return 4;
            if (tipo == "Full") return 3.5;
            if (tipo == "Trio") return 2.5;
            if (tipo == "Par") return 1.5;
            return 1;
        }

        static double AplicarJokers(double puntos, bool x2, bool mas10)
        {
            if (x2) puntos *= 2;
            if (mas10) puntos += 10;
            return puntos;
        }
        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.Write("Nano: ");
            for (int i = 0; i < mano.Length; i++)
            {
                Console.Write(mano[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Puntos base: " + basePts);
            Console.WriteLine("Multiplicador: " + mult);
            Console.WriteLine("Total (+ Jokers): " + total);
        }
    }
}
      
