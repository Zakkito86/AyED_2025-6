using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elija el idioma para saludar ");
            Console.WriteLine("1. INGLES ");
            Console.WriteLine("2. FRANCES ");
            Console.WriteLine("3 ALEMAN ");

            string opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1":
                    Console.WriteLine(" HELLO ");
                    break;

                case "2":
                    Console.WriteLine(" SALUT ");
                    break;

                case "3":
                    Console.WriteLine(" HALLO ");
                    break;
            }
        }
    }
}
