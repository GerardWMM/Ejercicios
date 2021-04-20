using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("===Calculador de numeros par=== \nIngresa un número: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine($"{num} es un numero par");
            }else if (num % 2 == 0)
            {
                Console.WriteLine($"El número {num} es par");
            }
            else
            {
                Console.WriteLine($"El número {num} es impar");
            }

            Console.ReadLine();
        }
    }
}
