using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            Console.WriteLine("ingrese su altura");
            altura = Convert.ToDouble(Console.ReadLine());
            double peso;
            Console.WriteLine("ingrese su peso ");
            peso = Convert.ToDouble(Console.ReadLine());
            double imc = peso / (altura*altura);
            if (imc >= 25)
            {
                Console.WriteLine("tiene sobrepeso, tu imc es " + imc );                            
            }
            else
                Console.WriteLine("estas en un peso normal, tu imc es " + imc);
            

        }
    }
}
