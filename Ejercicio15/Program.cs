using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("====Quien es mayor==== \n-Ingrese su nombre: ");
            string nombre1 = Console.ReadLine();
            Console.Write("-Ingrese su edad: ");
            int edad1 = int.Parse(Console.ReadLine());

            Console.Write("-Ahora ingrese el nombre de la otra persona: ");
            string nombre2 = Console.ReadLine();
            Console.Write("-Edad de la otra persona: ");
            int edad2 = int.Parse(Console.ReadLine());

            if(edad1 > edad2)
            {
                Console.WriteLine($"{nombre1} es mayor y {nombre2} es menor");
                int diferencia = edad1 - edad2;
                Console.WriteLine($"La diferencia de edad entre ambos es de: {diferencia} año/s");

            }else if(edad2 > edad1)
            {
                Console.WriteLine($"{nombre2} es mayor y {nombre1} es menor");
                int diferencia = edad2 - edad1;
                Console.WriteLine($"La diferencia de edad entre ambos es de: {diferencia} año/s");
            }

            Console.ReadLine();
        }
    }
}
