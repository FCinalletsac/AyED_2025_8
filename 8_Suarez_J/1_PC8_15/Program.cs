using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            Random rand = new Random();
            bool salir = false;


            do
            {
                Console.WriteLine("Día 1 ¿Qué queres hacer? ");
                Console.WriteLine("1: Buscar comida ");
                Console.WriteLine("2: Dormir ");
                Console.WriteLine("3: Explorar la isla ");
                Console.WriteLine("4: Ver estado del personaje ");
                Console.WriteLine("5: Salir del juego ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {

                    case "1":
                        Console.WriteLine("Comiste, +20 hambre -15 energia");
                        hambre += 20;
                        energia -= 15;
                        int probabilidad = rand.Next(1, 101);
                        if (probabilidad <= 30)
                        {
                            Console.WriteLine("comiste algo en mal estado.Salud -15 ");
                            salud -= 15;
                        }

                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                            sigueVivo = false;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Dormiste, +30 energia -10 hambre");
                        energia += 30;
                        hambre -= 10;
                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                            sigueVivo = false;
                        }

                        break;

                    case "3":
                        Console.WriteLine("exploraste la isla, -20 energia - 15 hambre");
                        energia -= 20;
                        hambre -= 15;
                        probabilidad = rand.Next(1, 101);
                        if (probabilidad <= 50)
                        {
                            Console.WriteLine("¡Encontraste una planta curativa! Salud +10.");
                            salud += 10;
                        }
                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                            sigueVivo = false;
                        }

                        break;

                    case "4":
                        Console.WriteLine("salud " + salud);
                        Console.WriteLine("hambre " + hambre);
                        Console.WriteLine("energia " + energia);
                        Console.WriteLine("dia " + dia);
                        Console.WriteLine("¿Sigue vivo? " + sigueVivo);

                        break;

                    case "5":
                        Console.WriteLine("juego terminado ");
                        salir = true;

                    
                        break;

                }

            } while (!salir);
        }
    }
}