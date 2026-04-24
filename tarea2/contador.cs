using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantsec;
            Console.WriteLine("ingrese la cantidad de segundos : ");
            cantsec = Convert.ToInt32(Console.ReadLine());
            int min = cantsec / 60;
            int segundos;
            segundos = cantsec % 60;
            if (min != 0)
            {
                Console.WriteLine("hay " + min + " minutos y " + segundos + " segundos " );
            }
            else
                Console.WriteLine(" hay " + segundos + " segundos " );


        }
    }
}
