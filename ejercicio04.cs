using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_ll_1p_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Desarrolle un programa que utilice una instrucción while para determinar
           // el sueldo bruto para cada uno de varios empleados. La empresa paga la
           // “cuota normal” en las primeras 40 horas de trabajo de cada empleado, y
           // paga “cuota y media” en todas las horas trabajadas que excedan de 40.
           // Usted recibe una lista de los empleados de la empresa, el número de
           // horas que trabajó cada empleado la semana pasada y la tarifa por horas
           // de cada empleado. Su programa debe recibir como entrada esta
           // información para cada empleado, debe determinar y mostrar el sueldo
           // bruto de cada empleado.

            double horasTrabajadas, tarifaPorHora, sueldoBruto;
            int contador = 0;

            while (contador < 3)
            {
                Console.Write("Ingrese las horas trabajadas por el empleado: ");
                horasTrabajadas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese la tarifa por hora del empleado: ");
                tarifaPorHora = Convert.ToDouble(Console.ReadLine());
                if (horasTrabajadas <= 40)
                {
                    sueldoBruto = horasTrabajadas * tarifaPorHora;
                }
                else
                {
                    sueldoBruto = (40 * tarifaPorHora) + ((horasTrabajadas - 40) * tarifaPorHora * 1.5);
                }
                Console.WriteLine($"El sueldo bruto del empleado {contador + 1} es: {sueldoBruto:C}");
                
                contador++;
            }
            Console.WriteLine("Cálculo de sueldos finalizado.");
            Console.ReadKey();

        }
    }
}
