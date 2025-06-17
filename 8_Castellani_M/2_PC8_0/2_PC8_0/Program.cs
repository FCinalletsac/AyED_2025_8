using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_0
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("¿Cuántos invitados acuden?");
                int numero = int.Parse(Console.ReadLine());
                int[] invitados = new int[numero];
                int totalComida = 0;

                for (int i = 0; i < numero; i++)
                {
                    bool condicion = false;

                    // Aquí se captura la cantidad de comida para cada invitado.
                    while (!condicion)
                    {
                        Console.WriteLine("¿Cuánto come cada invitado entre 1 y 100?");
                        int comida = int.Parse(Console.ReadLine());
                        if (comida >= 1 && comida <= 100)
                        {
                            invitados[i] = comida;
                            totalComida += comida; // Acumulamos la cantidad de comida
                            condicion = true; // Salimos del bucle while
                        }
                        else
                        {
                            Console.WriteLine("Por favor ingrese un valor válido entre 1 y 100.");
                        }
                    }
                }

                // Calculamos el promedio de comida por invitado
                double promedio = (double)totalComida / numero;
                Console.WriteLine("El promedio por invitado es: " + promedio);
                Console.ReadKey();
            }
        }
    }
  }

