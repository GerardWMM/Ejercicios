using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal notas;
                decimal suma = 0;
                decimal promedio = 0;
                int x;
                Console.Write("===Calculador de notas v2=== \n-Ingresa la cantidad de notas a promediar: ");
                int cantidad = int.Parse(Console.ReadLine());

                for (x = 0; x < cantidad; x++)
                {
                    Console.Write("Ingresa una nota: ");
                    notas = decimal.Parse(Console.ReadLine());

                    suma = suma + notas;
                    promedio = (suma / cantidad) * 0.1M;
                }

                if (promedio > 4.0M && promedio < 7.0M)
                {
                    Console.WriteLine($"Tu promedio es: {promedio} \n-Aprobaste la materia");
                    break;
                }
                else if(promedio < 4.0M && promedio >= 1.0M)
                {
                    Console.WriteLine($"Tu promedio es: {promedio} \n-Reprobaste la materia");
                    break;
                }
                else
                {
                    Console.WriteLine("==El promedio esta fuera de rango==");
                    Console.WriteLine("=ERROR: Se detecto una nota fuera de rango. Repite el proceso=");
                }
            }

        }
    }
}

