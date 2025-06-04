using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primera nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3;
            int categoria = (promedio > 100) ? -1 : (int)(promedio / 10);

            Console.WriteLine($"\nPromedio obtenido: {promedio:F2}");

            switch (categoria)
            {
                case -1:
                    Console.WriteLine("Error: Promedio fuera de rango.");
                    break;
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Reprueba");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Bueno");
                    break;
                case 9:
                    Console.WriteLine("Muy bueno");
                    break;
                case 10:
                    Console.WriteLine("Sobresaliente");
                    break;
                default:
                    Console.WriteLine("Error: Promedio inválido.");
                    break;

            }
        }
    }
}