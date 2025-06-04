using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int accountNumber; // Número de cuenta
                               //a) Número de cuenta (un entero)
            Console.Write("Ingrese el número de cuenta: ");
            accountNumber = int.Parse(Console.ReadLine());
            //b) Saldo al inicio del mes
            Console.Write("Ingrese el saldo al inicio del mes: ");
            double initialBalance = double.Parse(Console.ReadLine());
            //c) Total de todos los artículos cargados por el cliente en el mes
            Console.Write("Ingrese el total de artículos cargados por el cliente en el mes: ");
            int totalCharged = int.Parse(Console.ReadLine());
            //d) Total de todos los créditos aplicados a la cuenta del cliente en el mes
            Console.Write("Ingrese el total de créditos aplicados a la cuenta del cliente en el mes: ");
            double totalCredits = double.Parse(Console.ReadLine());
            //e) Límite de crédito permitido.
            Console.Write("Ingrese el límite de crédito permitido: ");
            double creditLimit = double.Parse(Console.ReadLine());

            double newBalance = initialBalance + totalCharged - totalCredits;
            //f) Imprimir el número de cuenta, el nuevo saldo y si el cliente ha excedido el límite de crédito permitido.
            Console.WriteLine($"Número de cuenta: {accountNumber}");
            Console.WriteLine($"Nuevo saldo: {newBalance:C}");
            if (newBalance > creditLimit)
            {
                Console.WriteLine("El cliente ha excedido el límite de crédito permitido.");
            }
            else
            {
                Console.WriteLine("El cliente no ha excedido el límite de crédito permitido.");
            }
            //g) Si el nuevo saldo es negativo, imprimir un mensaje indicando que se debe pagar el saldo total de inmediato.
            if (newBalance < 0)
            {
                Console.WriteLine("El nuevo saldo es negativo. Se debe pagar el saldo total de inmediato.");
            }
            else
            {
                Console.WriteLine("El nuevo saldo es positivo. No se requiere pago inmediato.");
            }


        }
    }

}
  