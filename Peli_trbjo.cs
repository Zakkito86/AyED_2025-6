using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string movie;
            Console.WriteLine("hola usuario");
            Console.Write("¿cual es tu nombre?: ");
            name = Console.ReadLine();
            Console.Write("¿cual es tu pelicula favorita?: ");
            movie = Console.ReadLine();

            Console.WriteLine("hola querido usuario " + name +" "+ movie + " es una porqueria");

            
        }
    }
}
