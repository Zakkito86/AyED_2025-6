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
            int pesoNave;
            Console.Write("ingresar el peso de la nave: ");
            pesoNave = Convert.ToInt32(Console.ReadLine());
            int restaPeso = pesoNave - 5000;

            if (pesoNave < 5000)
                Console.Write("la nave puede despegar pesando " + pesoNave + " kilos " );

            else
                Console.Write("la nave pesa de mas, debes descargar " + restaPeso + " kilogramos");

        }
    }
}
