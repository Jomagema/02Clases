using System;
using System.Globalization;

namespace _02Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            int opt2 = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("***Ejercicio 02 de Clases***");
                Console.WriteLine("1. Manejar Fechas");
                Console.WriteLine("2. Clase Película");
                Console.WriteLine("3. Alquiler Puerto");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elija una opción");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("1. Dia Semana");
                        Console.WriteLine("2. Incrementar Fecha");
                        Console.WriteLine("3. Diferencia Fechas");
                        Console.WriteLine("4. Compara Fechas");
                        opt2 = int.Parse(Console.ReadLine());
                        switch (opt2)
                        {
                            case 1:
                                Console.WriteLine(DateTime.Now.DayOfWeek.ToString("dddd", new CultureInfo("es-ES")));
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("No es una opción valida");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("No es una opción valida");
                        break;
                }

            } while (opt != 4);
        }
    }
}
