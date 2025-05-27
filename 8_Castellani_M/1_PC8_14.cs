using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string nombre = "BOU";
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            bool tieneEspada = false;
            do
            {
                Console.WriteLine("\n===== SIMULADOR GAMER =====");
                Console.WriteLine("1 Mostrar estado del jugador");
                Console.WriteLine("2 Encontrar espada mágica");
                Console.WriteLine("3 Pelear contra un enemigo ");
                Console.WriteLine("4 Comprar poción de vida (vale 20 monedas)");
                Console.WriteLine("5 Salir");
                Console.Write("Elegí una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine( "salud " + salud);
                        Console.WriteLine("Monedas " + monedas);
                        Console.WriteLine("Enemigos derrotados "+enemigosDerrotados);
                        Console.WriteLine("Espada "+tieneEspada);
                        Console.WriteLine("Nombre "+nombre);

                        break;
                    case "2":
                        if (tieneEspada == true)
                        {
                            Console.WriteLine("¡Ya tienes la espada!");
                        }
                        else
                        {
                            tieneEspada = true;
                            Console.WriteLine("Encontraste la espada ");
                        }
                        break;
                    case "3":
                        if (tieneEspada == true)
                        {
                            salud -= 10;
                            enemigosDerrotados++;
                            Console.WriteLine("¡Ganaste la batalla! Salud -10");
                        }
                        else
                        {
                            salud -= 30;
                            enemigosDerrotados++;
                            Console.WriteLine("¡Fue una pelea dura sin espada! Salud -30");

                        }
                        break;
                    case "4":
                        if (monedas >= 20)
                        {
                            monedas -= 20;
                            salud += 20;
                            Console.WriteLine("Usaste una poción +20 de salud");
                        }
                        break;
                    case "5":
                        salir = true;
                        break;


                }
            } while (!salir);
        }    
    }
}
