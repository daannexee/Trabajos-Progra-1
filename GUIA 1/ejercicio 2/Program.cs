using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Martinez Rosales Josue Daniel carnet: 25-4699-2024

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("Ingrese un numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine($"El numero mayor es: {n1}");
            }
            else if (n2 > n1)
            {
                Console.WriteLine($"El mayor es: {n2}");
            }
            else
            {
                Console.WriteLine("Ambos son iguales");
            }
        }
    }
}
