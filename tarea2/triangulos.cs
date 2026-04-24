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
            int lado1;
            Console.WriteLine(" ingrese el primer lado ");
            lado1 = Convert.ToInt32(Console.ReadLine());
            int lado2;
            Console.WriteLine("ingrese el segundo lado : ");
            lado2 = Convert.ToInt32(Console.ReadLine());
            int lado3;
            Console.WriteLine("ingrese el tercer lado : ");
            lado3 = Convert.ToInt32(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("el triangulo es equilatero ");
            }
            if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("el triangulo es isoceles ");
            }
            else
                Console.WriteLine("el triangulo es obtuso");
        }
    }
}
