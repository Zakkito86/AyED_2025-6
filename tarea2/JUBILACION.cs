using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("ingrese su edad : ");
            edad = Convert.ToInt32(Console.ReadLine());
            string genero;
            Console.WriteLine("ingrese su genero (M o F) : ");
            genero = Console.ReadLine();
            if (genero == "F" && edad >= 60 || genero == "M" && edad >= 65)
            {
                Console.WriteLine("usted se puede jubilar : ");

            }
            else
                Console.WriteLine("usted no puede jubilarse ");
        }
    }
}
