using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.Write("===Nota valida v2=== \n-Ingrese su nota: ");
            int nota = int.Parse(Console.ReadLine());
                if(nota >= 1 && nota <= 7)
                {
                    Console.WriteLine("La nota es valida");
                    break;
                }
                else
                {
                    Console.WriteLine($"{nota} esta fuera de rango");
                }
            }

            Console.ReadLine();
        }
    }
}
