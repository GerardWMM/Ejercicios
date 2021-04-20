using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("===Calculador de promedio=== \n-Ingresa la cantidad de notas a promediar: ");
            int cantidad = int.Parse(Console.ReadLine());

            decimal notas;
            decimal suma = 0;
            decimal promedio = 0;
            int x;

            for (x = 0; x < cantidad; x++)
            {
                Console.Write("Ingresa una nota: ");
                notas = decimal.Parse(Console.ReadLine());

                suma = suma + notas;
                promedio = (suma / cantidad)*0.1M;
            }

            if(promedio > 4.0M)
            {
                Console.WriteLine($"Tu promedio es: {promedio} \n-Aprobaste la materia");
            }
            else
            {
                Console.WriteLine($"Tu promedio es: {promedio} \n-Reprobaste la materia");
            }

            Console.ReadLine();
        }
    }
}
