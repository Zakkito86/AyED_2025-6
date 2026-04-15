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
            int multiplos;
            Console.WriteLine("ingrese un numero ");
            multiplos = Convert.ToInt32(Console.ReadLine());
            int resultado = multiplos % 5;
            if (resultado == 0)
            {
                Console.WriteLine("el resultado es multiplo de 5");
            }
            else
                Console.WriteLine("el numero no es multiplo de 5");
        }
    }
}
