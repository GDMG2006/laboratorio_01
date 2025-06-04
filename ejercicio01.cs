using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
            
            {
                Console.WriteLine("Ingrese la cantidad de camisas a comprar:");
                int camisas;

                // Validar que el usuario ingrese un número correcto
                if (!int.TryParse(Console.ReadLine(), out camisas) || camisas <= 0)
                {
                    Console.WriteLine("Error: Ingrese un número válido de camisas.");
                    return;
                }

                double descuento = 0;

                // Aplicar descuentos según la cantidad de camisas
                if (camisas <= 10)
                {
                    descuento = 0.10;
                }
                else if (camisas <= 20)
                {
                    descuento = 0.20;
                }
                else if (camisas <= 30)
                {
                    descuento = 0.40;
                }

                // Calcular el precio total con descuento
                double total = (camisas * 100) * (1 - descuento);
                Console.WriteLine($"El total por la compra de {camisas} camisas es: {total:C}");
            }
        }
    }
    
