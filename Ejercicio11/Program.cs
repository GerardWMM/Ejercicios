using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
   
        static void Main(string[] args)
        {
            Console.Write("===Calculador de 3 numeros impar o par=== \n-Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("-Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("-Ingrese el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0)
            {
                Console.WriteLine($"{num1} {num2} {num3} son numeros par");
            }else if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 != 0)
            {
                Console.WriteLine($"{num1} es par, {num2} es par, {num3} es impar");
            }else if(num1 % 2 == 0 && num2 % 2 != 0 && num3 % 2 == 0)
            {
                Console.WriteLine($"{num1} es par, {num2} es impar, {num3} es par");
            }else if(num1 % 2 != 0 && num2 % 2 == 0 && num3 % 2 == 0)
            {
                Console.WriteLine($"{num1} es impar, {num2} es par, {num3} es par");
            }else if(num1 % 2 != 0 && num2 % 2 != 0 && num3 % 2 != 0)
            {
                Console.WriteLine($"{num1} {num2} {num3} son numeros impar");
            }else if(num1 % 2 == 0 && num2 % 2 != 0 && num3 % 2 != 0)
            {
                Console.WriteLine($"{num1} es par, {num2} es impar, {num3} es impar");
            }else if(num1 % 2 != 0 && num2 % 2 == 0 && num3 % 2 != 0)
            {
                Console.WriteLine($"{num1} es impar, {num2} es par, {num3} es impar");
            }else if(num1 % 2 != 0 && num2 % 2 != 0 && num3 % 2 == 0)
            {
                Console.WriteLine($"{num1} es impart, {num2} es impar, {num3} es par");
            }

            Console.ReadLine();
        }
    }
}
