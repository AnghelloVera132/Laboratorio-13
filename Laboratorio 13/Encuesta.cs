using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_13
{
    internal class Encuesta
    {
        private const int RptsMax = 100;
        private string[] Rpts = new string[RptsMax];
        private int[] Contador = new int[5];
        private int total = 0;

        public void quiz()
        {
            Console.Clear();
            Console.Write("===============================\n"+
            "Nivel de Satisfacción\n" +
            "===============================\n" +
            "¿Qué tan satisfecho está con la atención de nuestra tienda?\n" +
            "1: Nada satisfecho\n2: No muy satisfecho\n3: Tolerable\n4: Satisfecho\n5: Muy satisfecho" +
            "===============================\n" +
            "Ingrese una opción: ");
            int option = int.Parse(Console.ReadLine());

            if (option >= 1 && option <= 5)
            {
                Contador[option - 1]++;
                total++;
                Rpts[total - 1] = OptionTexto(option);

                Console.Clear();
                Console.Write("===============================\n"+
                "Nivel de Satisfacción\n" +
                "===============================\n" +
                "¡Gracias por participar!\n" +
                "===============================\n" +
                "Presione una tecla para regresar al menú ...");

                Console.ReadKey();
            }
        }

        public void Data()
        {
            Console.Clear();
            Console.Write("===============================\n" +
                "Ver datos registrados" +
                "===============================\n");
            Showdata();

            Console.Write("===============================\n"+
                "Presione una tecla para regresar ...");
            Console.ReadKey();
        }

        public void Eliminacion()
        {
            Console.Clear();
            Console.Write("===============================\n" +
                "Eliminar un dato"+
                "===============================\n");
            Showdata();
            Console.Write("Ingrese la posición a eliminar:");
            int position = int.Parse(Console.ReadLine());

            if (PositionValid(position))
            {
                int option = TextoOption(Rpts[position]);
                Contador[option - 1]--;
                total--;

                for (int i = position; i < total; i++)
                {
                    Rpts[i] = Rpts[i + 1];
                }

                Console.Clear();
                Console.Write("===============================\n"+
                    $"Posición {position} eliminada."+
                    "===============================\n");

                Console.Write("===============================\n"+
                    "Presione una tecla para regresar ...");
                Console.ReadKey();
            }
        }

        public void Ordenar()
        {
            Console.Clear();
            Console.Write("===============================\n"+
                "Ordenar datos"+
                "===============================\n");
            Array.Sort(Rpts, 0, total);
            Showdata();

            Console.WriteLine("\nPresione una tecla para regresar ...");
            Console.ReadKey();
        }

        private static string OptionTexto(int option)
        {
            switch (option)
            {
                case 1: return "Nada satisfecho";
                case 2: return "No muy satisfecho";
                case 3: return "Tolerable";
                case 4: return "Satisfecho";
                case 5: return "Muy satisfecho";
                default: return "";
            }
        }

        private static int TextoOption(string text)
        {
            switch (text)
            {
                case "Nada satisfecho": return 1;
                case "No muy satisfecho": return 2;
                case "Tolerable": return 3;
                case "Satisfecho": return 4;
                case "Muy satisfecho": return 5;
                default: return -1;
            }
        }

        private bool PositionValid(int position)
        {
            return position >= 0 && position < total;
        }

        private void Showdata()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Datos registrados");
            Console.WriteLine("===============================");

            for (int i = 0; i < total; i++)
            {
                Console.Write($"[{Rpts[i]}] ");
                if ((i + 1) % 5 == 0)
                    Console.WriteLine();
            }
            MostrarResumen();
        }

        private void MostrarResumen()
        {
            Console.WriteLine("\nResumen:");
            for (int i = 0; i < Contador.Length; i++)
            {
                Console.WriteLine($"{Contador[i]:D2} personas: {Rpts[i]}");
            }
        }

    }
}
