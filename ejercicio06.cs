using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Un almacén de pedidos por correo vende cinco productos distintos,
            //cuyos precios de venta son los siguientes: producto 1, $2.98; producto
            // 2, $4.50; producto 3, $9.98; producto 4, $4.49 y producto 5, $6.87.
            //Escriba un programa que lea una serie de pares de números, como se
            //muestra a continuación:
            //a) número del producto
            //b) cantidad vendida
            //Su programa debe utilizar una instrucción switch para determinar el
            //precio de venta de cada producto. Debe calcular y mostrar el valor total
            //de venta de todos los productos vendidos. Use un ciclo controlado por
            //centinela para determinar cuándo debe el programa dejar de iterar para
            //mostrar los resultados finales.
            double totalVenta = 0;

            while (true)
            {
                Console.Write("Ingrese el número del producto (1-5) o 0 para salir: ");
                int producto = int.Parse(Console.ReadLine());

                // Condición de salida
                if (producto == 0)
                    break;

                Console.Write("Ingrese la cantidad vendida: ");
                int cantidad = int.Parse(Console.ReadLine());

                double precio = 0;

                switch (producto)
                {
                    case 1:
                        precio = 2.98;
                        break;
                    case 2:
                        precio = 4.50;
                        break;
                    case 3:
                        precio = 9.98;
                        break;
                    case 4:
                        precio = 4.49;
                        break;
                    case 5:
                        precio = 6.87;
                        break;
                    default:
                        Console.WriteLine("Número de producto inválido.");
                        continue;
                }

                double subtotal = precio * cantidad;
                totalVenta += subtotal;
                Console.WriteLine($"Subtotal de producto {producto}: ${subtotal:F2}");
            }

            Console.WriteLine($"Total de ventas: ${totalVenta:F2}");

        }
    }
}
