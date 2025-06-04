using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 1001); // Genera un número aleatorio entre 1 y 1000
            int intento;

            Console.WriteLine("¡Bienvenido al juego 'Adivina el número'!");
            Console.WriteLine("Intenta adivinar el número secreto (entre 1 y 1000).");

            do
            {
                Console.Write("Ingresa tu número: ");
                intento = int.Parse(Console.ReadLine());

                if (intento < numeroSecreto)
                    Console.WriteLine("Demasiado bajo. ¡Inténtalo de nuevo!");
                else if (intento > numeroSecreto)
                    Console.WriteLine("Demasiado alto. ¡Sigue intentando!");
                else
                    Console.WriteLine("¡Excelente! ¡Adivinaste el número!");

            } while (intento != numeroSecreto);

        }
    }
}
