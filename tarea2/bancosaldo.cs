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
            int saldo;
            Console.WriteLine("ingrese su dinero en cuenta : ");
            saldo = Convert.ToInt32(Console.ReadLine());
            int retiro;
            Console.WriteLine("ingrese la cantidad que quiere retirar : ");
            retiro = Convert.ToInt32(Console.ReadLine());
            if (saldo > retiro && retiro % 1000 == 0)
            {
                Console.WriteLine("usted puede retirar ");
            }
            else if (saldo < retiro )
            {
                Console.WriteLine("saldo insuficiente ");
            }
            else
            {
                Console.WriteLine("solo billetes de mil ");
            }
        }
    }
}
