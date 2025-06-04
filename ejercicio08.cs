using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio8
{
    internal class Program
    {
        static double CalcularCargos(double horas)

        {
            //Un estacionamiento cobra una cuota mínima de $2.00 por estacionarse
            //hasta tres horas.El estacionamiento cobra $0.50 adicionales por cada
            //hora o fracción que se pase de tres horas. El cargo máximo para
            //cualquier periodo dado de 24 horas es de $10.00.Suponga que ningún
            //automóvil se estaciona durante más de 24 horas a la vez. Escriba un
            //programa que calcule e imprima los cargos por estacionamiento para
            //cada uno de tres clientes que estacionaron su automóvil ayer en este
            //estacionamiento.Debe introducir las horas de estacionamiento para
            //cada cliente.El programa debe imprimir los resultados en un formato
            // tabular ordenado, debe calcular e imprimir el total de los recibos de ayer.
            //El programa debe utilizar la función calcularCargos para determinar el
            //cargo para cada cliente.
            double cargoMinimo = 2.00;
            double cargoPorHoraExtra = 0.50;
            double cargoMaximo = 10.00;
            

            if ( horas <= 3)
                return cargoMinimo;
            else
            {
                double total = cargoMinimo + (Math.Ceiling(horas - 3) * cargoPorHoraExtra);
                return total > cargoMaximo ? cargoMaximo : total;
            }
        }

        static void Main()
        {
            double totalRecibos = 0;
            int numClientes = 3;
            double[] horasEstacionadas = new double[numClientes];
            double[] cargos = new double[numClientes];

            for (int i = numClientes - 1; i >= 0; i--)
            {
                
                Console.Write($"Ingrese las horas de estacionamiento para el cliente {i + 1}: ");
                horasEstacionadas[i] = double.Parse(Console.ReadLine());
                cargos[i] = CalcularCargos(horasEstacionadas[i]);
                totalRecibos += cargos[i];
            }

            Console.WriteLine("\nResumen de Cargos:");
            Console.WriteLine("Cliente\tHoras\tCargo");
            for (int i = 0; i < numClientes; i++)
            {
                Console.WriteLine($"{i + 1}\t{horasEstacionadas[i]:F2}\t${cargos[i]:F2}");
            }

            Console.WriteLine($"\nTotal de recibos: ${totalRecibos:F2}");
            Console.WriteLine("Presione cualquier tecla para salir...");
        }
    }
}
