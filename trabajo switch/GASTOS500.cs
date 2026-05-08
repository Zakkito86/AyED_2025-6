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
            int contador = 0;
            int precio = 0;
            for (int i = 1; i <= 5; i++)
            {
                int numero = 0;

                Console.Write("ingrese el gasto ");
                numero = int.Parse(Console.ReadLine());
                precio = precio + numero;

                if (numero > 500)
                {
                    contador++;
                }
                Console.WriteLine("hizo " + contador + " veces gastos mayores a 500 en el dia ");
                Console.WriteLine("el gasto total fue de " + precio);
            }
        }
    }
}
