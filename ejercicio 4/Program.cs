using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Martinez Hernández Miguel benjamin carnet: 27-4695-2024
namespace Ejercicio4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero entero:  ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine(numero >= 1 ?  "POSITIVO":numero < 0 ? "NEGATIVO":numero == 0 ? "HA INGRESADO EL NUMERO CERO":"");
            Console.ReadKey();
        }
    }
}
