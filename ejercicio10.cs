using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio10
{
    internal class Program
    {
            static double Centigrados(int fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }

            static double Fahrenheit(int centigrados)
            {
                return (centigrados * 9.0 / 5.0) + 32;
            }

            static void Main()
            {
                Console.WriteLine("Tabla de conversiones de temperatura");
                Console.WriteLine("C°      F°      |   F°      C°");
                Console.WriteLine("--------------------------------");

                for (int c = 0, f = 32; c <= 100 && f <= 212; c++, f++)
                {
                    Console.WriteLine($"{c,-7} {Fahrenheit(c),-7:F2} |   {f,-7} {Centigrados(f),-7:F2}");
                }

            }
        }
}
