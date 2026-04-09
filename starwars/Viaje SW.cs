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
            int añosluz;
            int litrosnave;

            Console.WriteLine("introduzca la cantidad de años de viaje: ");
            añosluz = Convert.ToInt32(Console.ReadLine());

            int litrosluz = añosluz * 12;

            Console.WriteLine("introduzca la cantidad de litros para el viaje: ");
            litrosnave = Convert.ToInt32(Console.ReadLine());

            if (litrosnave >= litrosluz)
            {
                Console.WriteLine("pueden llegar al destino");
            }

            else
            {
                int restantelitros = litrosluz - litrosnave;
                Console.WriteLine("faltan " + restantelitros + " litros para llegar al destino");
            }


        }
    }
}
