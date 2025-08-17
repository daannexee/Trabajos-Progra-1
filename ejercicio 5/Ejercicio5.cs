using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Cree un programa que solicite 2 números reales y también una clave desde teclado.
 * Según sea la clave deberá realizar la operación con los números solicitados
 * Las claves disponibles son las siguientes:
 * ➢ La clave + realiza una suma.
 * ➢ La clave - realiza una resta.
 * ➢ La clave * realiza una multiplicación.
 * ➢ La clave / realiza una división (Debe validar el no hacer divisiones entre 0).
*/

/* Prado Trejo Emerson Orlando
 * Numero de carnet 25-0093-2020 
 */

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Num1, Num2;
            char Clave;
            char Respuesta;

            Console.WriteLine("Ingrese el Primer numero: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo numero: ");
            Num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la operacion deseada\nsuma:+\nresta:-\nmultiplicacion:*\ndivision:/");
            Clave = char.Parse(Console.ReadLine());

            switch (Clave)
            {
                case '+':
                    Console.WriteLine($"La suma de los numeros es: {Num1 + Num2}");
                    break;
                case '-':
                    Console.WriteLine($"La resta de los numeros es: {Num1 - Num2}");
                    break;
                case '*':
                    Console.WriteLine($"La multiplicacion de los numeros es: {Num1 * Num2}");
                    break;
                case '/':
                    if (Num1 == 0)
                    {
                        do
                        {
                            Console.WriteLine("NO es posible dividir entre 0, digite de nuevo el primer numero");
                            Num1 = double.Parse(Console.ReadLine());
                        } while (Num1 == 0);
                    }
                    Console.WriteLine($"La division de los numeros es: {Num1 / Num2}");
                    break;
                default:
                    Console.WriteLine("Opcion erronea");
                    break;
            }

            Console.ReadKey();

        }
    }
}
