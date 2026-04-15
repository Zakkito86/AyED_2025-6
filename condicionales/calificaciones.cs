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
            int nota;
            Console.WriteLine("ingrese la temperatura actual ");
            nota = Convert.ToInt32(Console.ReadLine());
            if (nota < 4)
            {
                Console.WriteLine("desaprobado");
            }
            else if (nota >= 4 && nota <= 6)
            {
                Console.WriteLine("a finales");
            }
            else
                Console.WriteLine("fue promocionado");
        }
    }
}
