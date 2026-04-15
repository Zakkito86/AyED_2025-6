using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.WriteLine("ingrese su edad ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese su nombre ");
            nombre = Console.ReadLine();
            if (edad >= 18)
            {
                Console.WriteLine("bienvenido al club de la pelea " + nombre);
            }
            else
                Console.WriteLine("vete de aqui todavia eres un polluelo " + nombre);

        }
    }
}
