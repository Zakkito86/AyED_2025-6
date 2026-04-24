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
            int canthoras;
            Console.WriteLine("ingrese la cantidad de horas : ");
            canthoras = Convert.ToInt32(Console.ReadLine());
            int cantpago;
            Console.WriteLine("ingrese   con el que pagara: ");
            cantpago = Convert.ToInt32(Console.ReadLine());
            int precio = 4000;
            int horasxtra = 1600;
            int precioxtra = horasxtra * (canthoras - 1) + precio;
            int vuelto1 = cantpago - precio;
            int vuelto2 = cantpago - precioxtra;
            if (canthoras == 1 && cantpago >= precioxtra)
            {
                Console.WriteLine("usted pagara " + precio + " el vuelto es " + vuelto1);
            }
            else if (canthoras > 1 && cantpago >= precioxtra)

            {
                Console.WriteLine("usted pagara " + precioxtra + " el vuelto es " + vuelto2);
            }
            else
            {
                if ( canthoras > 1)
                    {
                    int vuelto = precioxtra - cantpago;
                Console.WriteLine("usted no tiene el dinero suficiente, usted le faltan " + vuelto + " pesos");
                }
                else
                {
                    int vueltoalt = precio - cantpago;
                    Console.WriteLine("usted no tiene el dinero suficiente, usted le faltan " + vueltoalt + " pesos " );

                }

            }
        }
    }
}
