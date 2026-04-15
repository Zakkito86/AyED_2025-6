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
            int temperatura;
            Console.WriteLine("ingrese la temperatura actual ");
            temperatura = Convert.ToInt32(Console.ReadLine());
            if (temperatura < 0)
            {
                Console.WriteLine("Peligro Clima gelido");
            }
            else if (temperatura >= 0 && temperatura <= 15)
            {
                Console.WriteLine("mucho frio");
            }
            else
                Console.WriteLine("La temperatura es agradable");
        }
    }
}
