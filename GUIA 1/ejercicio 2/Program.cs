using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Martinez Rosales Josue Daniel carnet : 25-4699-2024

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");
            string input1 = Console.ReadLine();
            double numero1;

            while (!double.TryParse(input1, out numero1))
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido:");
                input1 = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el segundo número: ");
            string input2 = Console.ReadLine();
            double numero2;

            while (!double.TryParse(input2, out numero2))
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido:");
                input2 = Console.ReadLine();
            }

            if (numero1 > numero2)
            {
                Console.WriteLine($"El número mayor es: {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"El número mayor es: {numero2}");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales");
            }

            Console.ReadKey();
        }

    }


}
