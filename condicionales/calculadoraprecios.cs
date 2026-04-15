using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            int precio;

            Console.WriteLine("ingrese la cantidad de robots a comprar: ");
            precio = Convert.ToInt32(Console.ReadLine());
            if (precio >= 5000)
            {
                double preciodescuento = precio * 0.15;
                double preciofinal = precio - preciodescuento;
                Console.WriteLine("el precio final con descuento es " + preciofinal );
            }
            else
                Console.WriteLine("el precio final no tiene descuento y es " + precio);
        }
    }
}
