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
            int cristalKyber;

            Console.WriteLine("1. Lo devuelves al templo.", "hola");
            Console.WriteLine("2. Lo vendes por créditos.");
            Console.WriteLine("3. Lo usas para construir un arma roja");
            Console.WriteLine("ingrese un valor entre 1, 2 y 3 ");
            cristalKyber = Convert.ToInt32(Console.ReadLine());

            if (cristalKyber == 1)
            {
                Console.WriteLine("1. el camino jedi sigue");
            }
            else if (cristalKyber == 2)
            {
                Console.WriteLine("2. un cazarrecompensas eres");
                    }
            else if (cristalKyber == 3)
            {
                Console.WriteLine("3. el lado oscuro se apodera de ti");
            }
        }
    }
}
