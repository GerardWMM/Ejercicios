using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("===Calculador de Velocidad=== \n-Ingrese la distancia a recorrer: ");
            int distancia = int.Parse(Console.ReadLine());
            int velocidad = distancia / 6;
            Console.WriteLine($"Para recorrer {distancia}km la velocidad será de {velocidad} Km/H");
            if(velocidad > 100)
            {
                Console.WriteLine("¡Advertencia! El vehiculo se desplazara a una gran velocidad");
            }
            else
            {
                Console.WriteLine("-La velocidad será moderada-");
            }
            Console.ReadLine();
        }
    }
}
