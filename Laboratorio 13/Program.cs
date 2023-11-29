using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_13
{
    class Program
    {
        static void Main()
        {
            Encuesta encuestas = new Encuesta();

            do
            {
                Console.Clear();
                Console.Write("===============================\n" +
                "Encuestas de Calidad\n" +
                "===============================\n" +
                "1: Realizar Encuesta\n2: Ver datos registrados\n3: Eliminar un dato\n4: Ordenar datos de menor a mayor\n5: Salir\n" +
                "===============================\n" +
                "Ingrese una opción: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        encuestas.quiz();
                        break;
                    case 2:
                        encuestas.Data();
                        break;
                    case 3:
                        encuestas.Eliminacion();
                        break;
                    case 4:
                        encuestas.Ordenar();
                        break;
                    case 5:
                        break;
                }
            } while (option != 5);
        }
    }
}
