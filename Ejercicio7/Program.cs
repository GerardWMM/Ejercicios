using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("===Menor a Mayor=== \n-Ingrese el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("-Ingrese el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            int x;

            if(num1 > num2)
            {
                for (x = num2; x <= num1; x++)
                {
                    Console.WriteLine(x);
                }
            }
            else if(num2 > num1)
            {
                for(x = num1; x <= num2; x++)
                {
                    Console.WriteLine(x);
                }
            }

            Console.ReadLine();
        }
    }
}
