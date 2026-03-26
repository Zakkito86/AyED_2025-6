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
            string name;
            string game;
            string console;
            Console.WriteLine("hola usuario");
            Console.Write("¿cual es tu nombre?: ");
            name = Console.ReadLine();
            Console.Write("¿cual es tu Juego favorito?: ");
            game = Console.ReadLine();
            Console.Write("en que consola Jugas?: ");
            console = Console.ReadLine();
            Console.WriteLine("hola " + name + " tu juego favorito es " + game + " y lo jugas en " + console);

        }
    }
}
