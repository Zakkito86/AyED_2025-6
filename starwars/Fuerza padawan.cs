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
            int midiclorianos;
            Console.WriteLine("cuantos midiclorianos tenes ");
            midiclorianos = Convert.ToInt32(Console.ReadLine());
            if (midiclorianos >= 15000 )
            {
                Console.WriteLine("posible Maestro Jedi, avisar al consejo");
            }
            else if (midiclorianos >= 5000 && midiclorianos < 15000)
            {
                Console.WriteLine("aceptable para entrenar de padawan");
            }
            else
                    {
                Console.WriteLine("no posee sensibilidad de la fuerza");
                    };


        }
    }
}
