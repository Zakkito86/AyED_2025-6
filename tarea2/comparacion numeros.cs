using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("ingrese un numero : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            int num2;
            Console.WriteLine("ingrese un numero : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int num3;
            Console.WriteLine("ingrese un numero ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("el numero mayor es el 1 ");

                }
                else
                    Console.WriteLine("el numero mayor es el 3 ");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("el numero mayor es el 2 ");
            }
            else
                Console.WriteLine("el numero mayor es el 3 ");

        }
    }
}
