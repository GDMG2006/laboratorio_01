using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Haga un programa que diga si el carácter ingresado es Vocal o No es
            //Vocal.
            Console.Write("Ingrese un carácter: ");
            char caracter = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
                Console.WriteLine("El carácter ingresado es una Vocal.");
            else
                Console.WriteLine("El carácter ingresado No es Vocal.");

        }
    }
}
