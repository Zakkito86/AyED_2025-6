using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elija su calificacion ");
            Console.WriteLine(" A ");
            Console.WriteLine(" B ");
            Console.WriteLine(" C ");
            Console.WriteLine(" D ");
            Console.WriteLine(" F ");


            String opcion = Console.ReadLine();

            switch (opcion)
            {
                case "A":
                    Console.WriteLine(" has sacado un exelente ");
                    break;

                case "B":
                    Console.WriteLine(" has sacado una buena nota ");
                    break;

                case "C":
                    Console.WriteLine(" has sacado un regular ");
                    break;

                case "D":
                    Console.WriteLine(" has sacado un suficiente ");
                    break;

                case "F":
                    Console.WriteLine(" has sacado un reprobado ");
                    break;

                default:
                    Console.WriteLine(" elija una opcion valida por favor ");
                    break;
            }
        }
    }
}
