using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Haga un programa que diga la cantidad de cifras si es mayor a
            //0 y menor a 10 dirá uno, si es mayor o igual a 10 y menor a 100
            //mostrará dos, si es mayor o igual a 100 o menor a 1000 mostrará tres, si
            //es mayor o igual a 1000 y menor a 10000 mostrará 4, caso contrario
            //mostrará mayor a 5.
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero < 10)
                Console.WriteLine("Uno");
            else if (numero >= 10 && numero < 100)
                Console.WriteLine("Dos");
            else if (numero >= 100 && numero < 1000)
                Console.WriteLine("Tres");
            else if (numero >= 1000 && numero < 10000)
                Console.WriteLine("Cuatro");
            else
                Console.WriteLine("Mayor a 5");





        }
    }
}
