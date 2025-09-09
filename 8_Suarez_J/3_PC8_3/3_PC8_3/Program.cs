using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC8_3
{
    using System;

    class Program
    {
        static string[,] encargos = new string[25, 5];
        static int cantidadEncargos = 0;

        static void Main(string[] args)
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1: CrearEncargo(); break;
                        case 2: MostrarEncargos(); break;
                        case 3: AsignarCamion(); break;
                        case 4: MostrarEncargosAsignados(); break;
                        case 5: PromedioGananciaPorSede(); break;
                        case 6: EncargoMayorDistancia(); break;
                        case 7: FiltrarPorCamion(); break;
                        case 8:
                            continuar = false;
                            Console.WriteLine("Cerrando programa...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            }
        }

        
        static void MostrarMenu()
        {
            Console.WriteLine("\n--- Menú Principal ---");
            Console.WriteLine("1. Crear nuevo encargo");
            Console.WriteLine("2. Mostrar todos los encargos");
            Console.WriteLine("3. Asignar camión a encargo");
            Console.WriteLine("4. Mostrar todos los encargos asignados");
            Console.WriteLine("5. Promedio de ganancia por sede");
            Console.WriteLine("6. Mostrar el encargo con mayor distancia");
            Console.WriteLine("7. Filtrar encargos por código de camión");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");
        }

       
        static void CrearEncargo()
        {
            Console.Clear();
            if (cantidadEncargos < 25)
            {
                Console.Write("Ingrese el código del camión: ");
                encargos[cantidadEncargos, 0] = Console.ReadLine();

                Console.Write("\nIngrese la distancia en KM: ");
                encargos[cantidadEncargos, 1] = Console.ReadLine();

                if (int.Parse(encargos[cantidadEncargos, 1]) < 0)
                {
                    Console.WriteLine("La distancia no puede ser negativa.");
                    return;
                }

                Console.Write("\nIngrese la sede:\n1. Buenos Aires (BS.AS.).\n2. Bahía Blanca (BB). \n3. Mar del Plata (MDQ). ");
                encargos[cantidadEncargos, 2] = Console.ReadLine();

                Console.Write("\nIngrese la ganancia esperada: ");
                encargos[cantidadEncargos, 3] = Console.ReadLine();
                encargos[cantidadEncargos, 4] = "0";

                cantidadEncargos++;
                Console.WriteLine("\n¡Encargo registrado con éxito!");
            }
            else
            {
                Console.WriteLine("No hay más espacio disponible.");
            }
        }

        
        static void MostrarEncargos()
        {
            Console.Clear();
            Console.WriteLine("Encargos totales:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            for (int i = 0; i < cantidadEncargos; i++)
            {
                Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
            }
        }

        
        static void AsignarCamion()
        {
            Console.Clear();
            Console.WriteLine("Encargos no asignados:");
            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] == "0")
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t{encargos[i, 1]}\t{encargos[i, 2]}\t{encargos[i, 3]}");
                }
            }

            Console.Write("\nIngrese el N° de encargo a asignar: ");
            int nencargo = int.Parse(Console.ReadLine()) - 1;

            if (encargos[nencargo, 4] == "0")
            {
                Console.Write("Ingrese el código del camión: ");
                string codcamion = Console.ReadLine();
                encargos[nencargo, 4] = codcamion;

                Console.WriteLine("Encargo asignado con éxito.");
            }
            else
            {
                Console.WriteLine("El encargo ya está asignado.");
            }
        }

       
        static void MostrarEncargosAsignados()
        {
            Console.Clear();
            Console.WriteLine("Encargos asignados:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] != "0")
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t{encargos[i, 1]}\t{encargos[i, 2]}\t{encargos[i, 3]}\t{encargos[i, 4]}");
                }
            }
        }

       
        static void PromedioGananciaPorSede()
        {
            double totalBSAS = 0, totalBB = 0, totalMDQ = 0;
            int countBSAS = 0, countBB = 0, countMDQ = 0;

            for (int i = 0; i < cantidadEncargos; i++)
            {
                double ganancia;
                if (!double.TryParse(encargos[i, 3], out ganancia)) continue;

                switch (encargos[i, 2])
                {
                    case "1":
                    case "BS.AS.":
                        totalBSAS += ganancia; countBSAS++; break;
                    case "2":
                    case "BB":
                        totalBB += ganancia; countBB++; break;
                    case "3":
                    case "MDQ":
                        totalMDQ += ganancia; countMDQ++; break;
                }
            }

            Console.WriteLine("\nPromedio de ganancia:");
            Console.WriteLine($"BS.AS.: {(countBSAS > 0 ? (totalBSAS / countBSAS).ToString("0.00") : "Sin datos")}");
            Console.WriteLine($"Bahía Blanca: {(countBB > 0 ? (totalBB / countBB).ToString("0.00") : "Sin datos")}");
            Console.WriteLine($"Mar del Plata: {(countMDQ > 0 ? (totalMDQ / countMDQ).ToString("0.00") : "Sin datos")}");
        }

        
        static void EncargoMayorDistancia()
        {
            if (cantidadEncargos == 0)
            {
                Console.WriteLine("No hay encargos registrados.");
                return;
            }

            int maxDistancia = int.Parse(encargos[0, 1]);
            for (int i = 1; i < cantidadEncargos; i++)
            {
                int distanciaActual = int.Parse(encargos[i, 1]);
                if (distanciaActual > maxDistancia) maxDistancia = distanciaActual;
            }

            Console.WriteLine("Encargo(s) con mayor distancia:");
            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (int.Parse(encargos[i, 1]) == maxDistancia)
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t{encargos[i, 1]}\t{encargos[i, 2]}\t{encargos[i, 3]}\t{encargos[i, 4]}");
                }
            }
        }

       
        static void FiltrarPorCamion()
        {
            Console.Write("Ingrese el código de camión: ");
            string codigo = Console.ReadLine();

            bool encontrado = false;
            Console.WriteLine($"\nEncargos asignados al camión {codigo}:");

            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] == codigo)
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t{encargos[i, 1]}\t{encargos[i, 2]}\t{encargos[i, 3]}\t{encargos[i, 4]}");
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("No hay encargos asignados a este camión.");
        }
    }
}


