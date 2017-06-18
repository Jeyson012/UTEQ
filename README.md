using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class multiplicación_con_suma
    {
        static void Main(string[] args)
        {
            int a, b, i;
            double acum;
            acum = 0;
            Console.WriteLine("INGRESE EL VALOR:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= b; i++)
                acum = acum + a;
            Console.WriteLine("LA MULTIPICACIÓN CON SUMAS ES: " + acum);
            Console.ReadKey();
        }
    }
}

