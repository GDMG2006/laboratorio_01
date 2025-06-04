using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Haga un programa para facturar en una panadería, da un descuento por
           // comprar a sus clientes con membresía dependiendo el tipo, si es tipo A
          // da 10 % de descuento, si es tipo B da 15 % de descuento y 20 % de
         // descuento.
            Console.WriteLine("Ingrese el tipo de membresía (A, B o C): ");
            char tipoMembresia = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIngrese el monto total de la compra: ");
            decimal montoCompra = decimal.Parse(Console.ReadLine());
            decimal descuento = 0;
            switch (tipoMembresia)
            {
                case 'A':
                    descuento = 0.10m; // 10%
                    break;
                case 'B':
                    descuento = 0.15m; // 15%
                    break;
                case 'C':
                    descuento = 0.20m; // 20%
                    break;
                default:
                    Console.WriteLine("Tipo de membresía no válido.");
                    return;
            }
            decimal montoDescuento = montoCompra * descuento;
            decimal montoFinal = montoCompra - montoDescuento;
            Console.WriteLine($"Monto total antes del descuento: {montoCompra:C}");
            Console.WriteLine($"Descuento aplicado: {montoDescuento:C}");
            Console.WriteLine($"Monto total después del descuento: {montoFinal:C}");
            Console.ReadKey();
        }
    }
}
