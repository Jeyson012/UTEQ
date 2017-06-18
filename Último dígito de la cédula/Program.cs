using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class DÍGITO_DE_LA_CÉDULA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese los dígitos");
            int i, num, acumpar, acumimpar, total;
            acumpar = 0;
            acumimpar = 0;
            for(i=1; i<=9; i++)
            {
                num = Int16.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    acumpar = acumpar + num;
                }
                else
                { 
                    num = num * 2;
                    if (num > 9)
                    {
                        num = num - 9;
                    }
                    acumimpar = acumimpar + num;
                }
            }
                total = acumpar + acumimpar;

                if (total % 10 == 0)
                {
                    Console.WriteLine("el último dígito es 0");
                }
                else
                {
            
                    Console.WriteLine("el último dígito es:" + ((total % 10) - 10));
                }
                    Console.ReadKey();
                }
            }

        }
    


