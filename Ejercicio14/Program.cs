using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("====Simulador de Crédito=== \n1- Ingresa el monto a solicitar: ");
            double monto = int.Parse(Console.ReadLine());
            Console.Write("==Puedes pagar desde 1 cuota hacia adelante==\n2- Ingresa la cantidad de cuotas a pagar: ");
            double cuotas = int.Parse(Console.ReadLine());

            if (cuotas >= 1 && cuotas <= 12)
            {
                //Monto total
                double montoA = monto * 0.1;
                double montoTotal = monto + montoA;
                int resultadoTotal = Convert.ToInt32(montoTotal);

                //Monto cuota
                double montoCuota = montoTotal / cuotas;
                int resultadoCuotas = Convert.ToInt32(montoCuota);
                Console.WriteLine($"-El monto total a pagar es de: {montoTotal}\n-El valor de cada cuota es de: {montoCuota}");

            }
            else if (cuotas >= 13 && cuotas <= 30)
            {
                //Monto total
                double montoA = monto * 0.25;
                double montoTotal = monto + montoA;
                int resultadoTotal = Convert.ToInt32(montoTotal);

                //Monto cuota
                double montoCuota = montoTotal / cuotas;
                int resultadoCuotas = Convert.ToInt32(montoCuota);
                Console.WriteLine($"-El monto total a pagar es de: ${resultadoTotal}\n-El valor de cada cuota es de: ${resultadoCuotas}");

            }
            else if(cuotas >= 31 && cuotas <= 40)
            {
                //Monto total
                double montoA = monto * 0.35;
                double montoTotal = monto + montoA;
                int resultadoTotal = Convert.ToInt32(montoTotal);

                //Monto cuota
                double montoCuota = montoTotal / cuotas;
                int resultadoCuotas = Convert.ToInt32(montoCuota);
                Console.WriteLine($"-El monto total a pagar es de: ${resultadoTotal}\n-El valor de cada cuota es de: ${resultadoCuotas}");

            }
            else if(cuotas > 40)
            {
                //Monto total
                double montoA = monto * 0.5;
                double montoTotal = monto + montoA;
                int resultadoTotal = Convert.ToInt32(montoTotal);

                //Monto cuota
                double montoCuota = montoTotal / cuotas;
                int resultadoCuotas = Convert.ToInt32(montoCuota);

                Console.WriteLine($"-El monto total a pagar es de: ${resultadoTotal}\n-El valor de cada cuota es de: ${resultadoCuotas}");
            }

            Console.ReadLine();
        }
    }
}
