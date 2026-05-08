using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("elija la comida que desea pedir para conocer su precio");
            Console.WriteLine("(H)amburguesa ");
            Console.WriteLine("(P)izza ");
            Console.WriteLine("(S)andwich ");

            string opcion = Console.ReadLine();


            switch (opcion)
            {
                case "H":
                    Console.WriteLine(" La hamburguesa cuesta 3500 ");
                    break;

                case "P":
                    Console.WriteLine("La pizza cuesta 5000 ");
                    break;

                case "S":
                    Console.WriteLine("El sandwich cuesta 2500 ");
                    break;
                
                default:
                    Console.WriteLine(" producto no encontrado ");
                    break;
            }
        }
    }
}
