using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    {

                        {
                            int candidatos;
                            int multiplo;
                            Console.WriteLine("Ingrese la cantidad de candidatos que hicieron el examen:");
                            candidatos = int.Parse(Console.ReadLine());
                            int[] valor = new int[candidatos];
                           
                            for (int i = 0; i < candidatos; i++)
                            {
                                Console.WriteLine($"\nIngrese el puntaje del candidato N {i + 1}:");
                                valor[i] = int.Parse(Console.ReadLine());
                              
                            }

                            for (int i = 0; i < candidatos; i++)
                            {
                                for (int j = 0; j < candidatos - 1; j++)
                                {
                                    if (valor[j] < valor[j + 1])
                                    {
                                        int temp = valor[j];
                                        valor[j] = valor[j + 1];
                                        valor[j + 1] = temp;
                                    }
                                }
                            }
                            Console.WriteLine("Los valores de mayor a menor son: ");

                            for (int i = 0; i < candidatos; i++)
                            {

                                Console.WriteLine("el valor numero {0} es: {1} ", i + 1, valor[i]);

                            }
                            Console.WriteLine("\nIngrese un numero entero:");
                            multiplo= int.Parse(Console.ReadLine());   
                            for(int i = 0; i < candidatos; i++)
                            {
                                if (valor[i] % multiplo == 0)
                                {
                                    Console.WriteLine("El valor {0} es multiplo de {1}", valor[i], multiplo);
                                }
                                else
                                {
                                    Console.WriteLine("El valor {0} no es multiplo de {1}", valor[i], multiplo);
                                }
                            }

                            Console.ReadKey();
                        }
                    }
                }
            }

        }
    }
}
    

