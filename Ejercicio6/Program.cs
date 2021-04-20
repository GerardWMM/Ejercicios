using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("==Calculador de números impares== \n-Ingresa un número: ");
            int num = int.Parse(Console.ReadLine());
            int x;

            for(x = 0; x<num; x++)
            {
                if(x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }

            Console.ReadLine();
        }
    }
}
