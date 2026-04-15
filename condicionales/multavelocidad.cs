using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidad;
            Console.WriteLine("ingrese su velocidad");
            velocidad = Convert.ToInt32(Console.ReadLine());
            if (velocidad > 120)
            {
                Console.WriteLine("multa en camino: Exceso de velocidad ");
            }
            else
                Console.WriteLine("conduccion segura ");
        }
    }
}
