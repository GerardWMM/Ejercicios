using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("===Calculador de numeros par e impar=== \n- Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("-Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 % 2 == 0 && num2 % 2 != 0)
            {
                Console.WriteLine($"{num1} es par y {num2} es impar");
            }else if (num1 % 2 == 0 && num2 % 2 == 0)
            {
                Console.WriteLine($"tanto {num1} como {num2} son par");
            }else if(num1 % 2 != 0 && num2 % 2 == 0)
            {
                Console.WriteLine($"{num1} es impar y {num2} es par");
            }
            else
            {
                Console.WriteLine("Ambos numeros son impar");
            }

            Console.ReadLine();
        }
    }
}
