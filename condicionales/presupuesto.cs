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
            int presupuesto;
            int precio;
            Console.WriteLine("cuanto es el presupuesto inicial ? ");
            presupuesto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cuantos sale hacer la obra ");
            precio = Convert.ToInt32(Console.ReadLine());
            int preciofinal = precio - presupuesto;
            if (presupuesto <= precio)
            {
                Console.Write("faltan " + preciofinal + " pesos");
            }
            else 
                Console.Write("el presupuesto alcanza para el proyecto");
        }
    }
}
