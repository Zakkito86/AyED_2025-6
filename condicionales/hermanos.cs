using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hermano1;
            int hermano2;
            Console.WriteLine("cuanto añost tiene el hermano1 ? ");
            hermano1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cuantos años tiene el hermano2 ? ");
            hermano2 = Convert.ToInt32(Console.ReadLine());
            if (hermano1 > hermano2)
            {
                Console.WriteLine("el primer hermano es el mayor");
            }
            else
                Console.WriteLine("el segundo hermano es el mayor");

        }
    }
}
