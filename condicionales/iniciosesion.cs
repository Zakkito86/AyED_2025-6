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
            string admin;
            string user;
            int contraseña;
            admin = "admin";
            Console.WriteLine("ingrese el nnombre de usuario ");
            user = Console.ReadLine();
            Console.WriteLine("ingrese la contraseña ");
            contraseña = Convert.ToInt32(Console.ReadLine());

            if (user == admin && contraseña == 1234)
            {
                Console.WriteLine("acceso concedido ");
            }
            else
                Console.WriteLine("error de credenciales ");

        }
    }
}
