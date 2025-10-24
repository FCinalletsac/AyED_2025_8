using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC8_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string[,] pochidex = new string[75,6];
            String nombre;
            String tipo;
            String investigador;
            string nivel;
            string investigado;
            int contador = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1.Registrar Pochimon");
                Console.WriteLine("2.Asignar Investigador a Pochimon");
                Console.WriteLine("3.Actualizar Nivel de Pochimon");
                Console.WriteLine("4.Marcar Pochimon como Investigado");
                Console.WriteLine("5.Mostrar Información de Pochimons");
                Console.WriteLine("6.Buscar Pochimons por Tipo");
                Console.WriteLine("7.Mostrar Pochimons por Investigador");
                Console.WriteLine("8.Mostrar Pochimons Picados");
                Console.WriteLine("9.Salir");
                int opcion;
                Console.Write("Seleccione una opción: ");
                opcion=int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Registrar Pochimon");
                     
                            Console.Write("Ingrese el nombre del Pochimon: ");
                            nombre = Console.ReadLine();
                            Console.Write("Ingrese el tipo del Pochimon Agua, Fuego, Planta: ");
                            tipo = Console.ReadLine();
                            Console.Write("Ingrese el nivel del pochimon: ");
                            nivel = Console.ReadLine();
                            pochidex[contador, 0] = (contador+1).ToString();
                            pochidex[contador, 1] = nombre;  
                            pochidex[contador, 2] = tipo;
                            pochidex[contador, 3] = nivel;
                            pochidex[contador, 4] = "0";
                            pochidex[contador,5 ] = "0";
                            contador++;
                            Console.WriteLine("Pochimon registrado exitosamente.");
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Asignar Investigador a Pochimon");
                        Console.Write("Ingrese el ID del Pochimon: ");
                        int idAsignar = int.Parse(Console.ReadLine());
                        if (idAsignar > 0 && idAsignar <= contador)
                        {
                            Console.Write("Ingrese el nombre del investigador: ");
                            investigador = Console.ReadLine();
                            pochidex[idAsignar - 1, 4] = investigador;
                            Console.WriteLine("Investigador asignado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("ID de Pochimon no válido.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                        case 3:
                        Console.Clear();
                        Console.WriteLine("Actualizar Nivel de Pochimon");
                        Console.Write("Ingrese el ID del Pochimon: ");
                        int idNivel = int.Parse(Console.ReadLine());
                        if (idNivel > 0 && idNivel <= contador)
                        {
                            Console.Write("Ingrese el nuevo nivel del Pochimon: ");
                            nivel = Console.ReadLine();
                            pochidex[idNivel - 1, 3] = nivel;
                            Console.WriteLine("Nivel actualizado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("ID de Pochimon no válido.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                        case 4:
                        Console.Clear();
                        Console.WriteLine("Marcar Pochimon como Investigado");
                        Console.Write("Ingrese el ID del Pochimon: ");
                        int idInvestigado = int.Parse(Console.ReadLine());
                        if (idInvestigado > 0 && idInvestigado <= contador)
                        {
                            pochidex[idInvestigado - 1, 5] = "1";
                            Console.WriteLine("Pochimon marcado como investigado.");
                        }
                        else
                        {
                            Console.WriteLine("ID de Pochimon no válido.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                        case 5:
                        Console.Clear();
                        Console.WriteLine("Mostrar Información de Pochimons");
                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"ID: {pochidex[i, 0]}, Nombre: {pochidex[i, 1]}, Tipo: {pochidex[i, 2]}, Nivel: {pochidex[i, 3]}, Investigador: {pochidex[i, 4]}, Investigado: {(pochidex[i, 5] == "1" ? "Sí" : "No")}");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                        case 6:
                        Console.Clear();
                        Console.WriteLine("Buscar Pochimons por Tipo");
                        Console.Write("Ingrese el tipo de Pochimon a buscar (Agua, Fuego, Planta): ");
                        string tipoBuscar = Console.ReadLine();
                        bool encontrado = false;
                        for (int i = 0; i < contador; i++)
                        {
                            if (pochidex[i, 2].Equals(tipoBuscar, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"ID: {pochidex[i, 0]}, Nombre: {pochidex[i, 1]}, Tipo: {pochidex[i, 2]}, Nivel: {pochidex[i, 3]}, Investigador: {pochidex[i, 4]}, Investigado: {(pochidex[i, 5] == "1" ? "Sí" : "No")}");
                                encontrado = true;
                            }
                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("No se encontraron Pochimons de ese tipo.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                        case 7:
                        Console.Clear();
                        Console.WriteLine("Mostrar Pochimons por Investigador");
                        Console.Write("Ingrese el nombre del investigador: ");
                        string investigadorBuscar = Console.ReadLine();
                        bool encontradoInv = false;
                        for (int i = 0; i < contador; i++)
                        {
                            if (pochidex[i, 4].Equals(investigadorBuscar, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"ID: {pochidex[i, 0]}, Nombre: {pochidex[i, 1]}, Tipo: {pochidex[i, 2]}, Nivel: {pochidex[i, 3]}, Investigador: {pochidex[i, 4]}, Investigado: {(pochidex[i, 5] == "1" ? "Sí" : "No")}");
                                encontradoInv = true;
                            }
                        }
                        if (!encontradoInv)
                        {
                            Console.WriteLine("No se encontraron Pochimons asignados a ese investigador.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                        case 8:
                        Console.Clear();
                        Console.WriteLine("Mostrar Pochimons Picados");
                        bool encontradoPicado = false;
                        for (int i = 0; i < contador; i++)
                        {
                            if (pochidex[i, 5] == "1")
                            {
                                Console.WriteLine($"ID: {pochidex[i, 0]}, Nombre: {pochidex[i, 1]}, Tipo: {pochidex[i, 2]}, Nivel: {pochidex[i, 3]}, Investigador: {pochidex[i, 4]}, Investigado: Sí");
                                encontradoPicado = true;
                            }
                        }
                        if (!encontradoPicado)
                        {
                            Console.WriteLine("No hay Pochimons picados.");
                        }
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                         case 9:
                        salir = true;
                        break;
                        default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;




                }
                    

            } while (!salir);
        }
    }
}
