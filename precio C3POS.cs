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
            int preciorobots = 2000;
            int robots;

            Console.WriteLine("ingrese la cantidad de robots a comprar: ");
            robots = Convert.ToInt32(Console.ReadLine());

            double precio = robots * preciorobots;
            if (robots >= 3)
            {
                double preciototal = precio * 0.2;
                double preciofinal = precio - preciototal;
                Console.WriteLine("el precio final con descuento es " + preciofinal + " sin descuento es " + precio);
            }
            else
                Console.WriteLine("el precio final no tiene descuento y es " + precio );


        }
    }
}
