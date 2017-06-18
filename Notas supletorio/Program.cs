using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estado_académico_de_estudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            float nt;
            Console.WriteLine("Ingresa la nota del estudiante:");
            nt = float.Parse(Console.ReadLine());

            if (nt >= 7)
            {
                Console.Write("Estudiante Aprobado");

            }

            else
            {
                if (nt >= 3)
                {
                    Console.Write("Estudiante a Supletorio");

                }
                else
                {
                    Console.Write("Estudiante Reprobado");
                }

            }
            Console.ReadKey();
        }

    }
}

