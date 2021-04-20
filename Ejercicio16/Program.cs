using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("===Transformador de minutos a horas=== \n-Ingresa los minutos a transformar: ");
            decimal numeros = int.Parse(Console.ReadLine());
            decimal tiempo = numeros / 60;        
            decimal horas = Math.Truncate(tiempo);
            Console.WriteLine($"{numeros} minutos corresponden a: {horas} horas");
            Console.ReadLine();
        }
    }
}
