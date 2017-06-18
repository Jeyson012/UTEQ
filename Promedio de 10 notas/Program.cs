using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class promedio_de_10_notas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE SUS NOTAS:");
            int notas, i;
            double acum, promedio;
            acum = 0;
            for (i = 1; i <= 10; i++)
            {
                notas = int.Parse(Console.ReadLine());
                acum = acum + notas;
            }

                promedio = acum / 10;
                Console.WriteLine("EL PROMEDIO ES: " + promedio);
                Console.ReadKey();
            
        }
    }
}
