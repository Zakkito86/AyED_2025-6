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

            int contador = 0;
            int contadorno = 0;
            for (int i = 1; i <= 4; i++)
            {
                int numero = 0;

                Console.WriteLine("ingrese un numero cualquiera");
                numero = int.Parse(Console.ReadLine());

                if (numero > 100)
                {
                    contador++;
                }
                else
                    contadorno++;
                Console.WriteLine("la cantidad de numeros mayor a 100 es " + contador);
                Console.WriteLine("la cantidad de numeros menor a 100 es " + contadorno);
            }
        }
    }
}
