using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            Console.WriteLine("ingrese la distancia desde su vivienda a la institucion : ");
            distancia = Convert.ToInt32(Console.ReadLine());
            int promedio;
            Console.WriteLine("ingrese su promedio : ");
            promedio = Convert.ToInt32(Console.ReadLine());
            if (promedio >= 8 || distancia >= 50 )
            {
                Console.WriteLine("beca concedida ");
            }
            else
                Console.WriteLine("beca rechazada, no cumple con los requisitos ");

        }
    }
}
