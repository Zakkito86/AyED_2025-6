using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int temperatura = 0;
            for (int i = 1; i <= 7; i++)
            {
                int numero = 0;

                Console.Write("ingrese la temperatura de ese dia ");
                numero = int.Parse(Console.ReadLine());
                temperatura = temperatura + numero;

                if (numero < 0)
                {
                    contador++;
                }
                Console.WriteLine("la temperatura que hizo en la semana fue menor a 0, " + contador + " veces" );
                Console.WriteLine("la temperatura total es de " + temperatura);
            }
        }
    }
}
