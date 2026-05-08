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
            int alcancia = 0;

            for (int i = 1 ; i <= 4 ; i++)
            {

                Console.WriteLine("ingrese su ingreso de la semana " + i);
                int ingreso = int.Parse(Console.ReadLine());

                alcancia = alcancia + ingreso;
                Console.WriteLine("el ahorro total es de " + alcancia + " " + ingreso);
            }
        }
    }
}
