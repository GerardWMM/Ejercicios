using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("==Verificador de nota== \nIngresa tu nota: ");
            int nota = int.Parse(Console.ReadLine());

            if(nota >= 1 && nota <= 7)
            {
                Console.WriteLine($"tu nota {nota} es correcta.");
            }
            else
            {
                Console.WriteLine($"{nota} está fuera de rango");
            }

            Console.ReadLine();
        }
    }
}
