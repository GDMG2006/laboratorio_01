using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1PI_2025_ll_1p_ejercicio9
{
    internal class Program
    {
        static double CalcularAumento(double salario)

        {
            double aumento = 0;

            if (salario >= 0 && salario <= 4999)
                aumento = salario * 0.20;
            else if (salario >= 5000 && salario <= 9999)
                aumento = salario * 0.10;
            else if (salario >= 10000 && salario <= 14999)
                aumento = salario * 0.05;
            else if (salario >= 15000)
                aumento = salario * 0.03;
            else
                Console.WriteLine("Salario inválido.");

            return aumento;
        }

        static void Main()
        {
            Console.Write("Ingrese el salario: ");
            double salario = double.Parse(Console.ReadLine());

            double aumento = CalcularAumento(salario);
            double nuevoSalario = salario + aumento;

            Console.WriteLine($"\nSalario actual: ${salario:F2}");
            Console.WriteLine($"Aumento aplicado: ${aumento:F2}");
            Console.WriteLine($"Nuevo salario: ${nuevoSalario:F2}");

        }
    }
}
