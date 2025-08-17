using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ortiz Rosales Julio Alexander 25-4082-2024 


namespace practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double n1, n2, prom;

            Console.Write("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.Write("Ingrese nota de guía:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese nota de parcial:");
            n2 = Convert.ToDouble(Console.ReadLine());

            prom = (n1 * 0.40) + (n2 * 0.60);

            Console.WriteLine($"\nEl promedio de {nombre} es de {prom:F2}.");
			Console.ReadKey();


        }
    }
}
