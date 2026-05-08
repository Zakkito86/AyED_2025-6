using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("elija su estacion favorita del año");
            Console.WriteLine("1. primavera");
            Console.WriteLine("2. verano");
            Console.WriteLine("3. otoño");
            Console.WriteLine("4. invierno");

            switch (opcion)
            {
                case 1:
                    Console.WriteLine(" has elegido la primavera ");
                    break;

                case 2:
                    Console.WriteLine(" has elegido el verano ");
                    break;

                case 3:
                    Console.WriteLine(" has elegido el otoño ");
                    break;

                case 4:
                    Console.WriteLine(" has elegido el invierno ");
                    break;

                default:
                    Console.WriteLine(" elija una opcion valida por favor ");
                    break;
            }
        }
    }
}
