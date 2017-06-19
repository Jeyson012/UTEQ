using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_de_un_número
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE NÚMERO:");
            int numero;
            numero = int.Parse(Console.ReadLine());
            Int64 acum;
            acum = 1;
            Int64 acum2;
            for(int i=numero; i>1; i--)
            {
                acum2 = 0;
                for(int j=1; j<=i; j++)
                {
                    acum2+= acum;
                }
                acum = acum2;
            }
            Console.WriteLine("el número factorial es: " + acum);
            Console.ReadKey();

        }
    }
}
