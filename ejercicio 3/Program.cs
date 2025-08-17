using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Figueroa Gonzalez Josue Daniel CARNET : 25-4632-20240
namespace ejer3_Guia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario, contraseña;
            string CORRECTusuario = "PROGRA1";
            string CORRECTcontra = "K0m1d4.";
            int intento = 3;

            for (int i = 1; i <= intento; i++)
            {
                Console.WriteLine("INGRESE SU USUARIO: ");
                usuario = Console.ReadLine();
                Console.WriteLine("INGRESE SU CONTRASEÑA: ");
                contraseña = Console.ReadLine();

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                {
                    Console.WriteLine(" HA OCURRIDO UN ERROR no se puede dejar campos vacios ");
                    continue;
                }

                if (usuario == CORRECTusuario && contraseña == CORRECTcontra)
                {
                    Console.WriteLine("usted ingreso al sistema con exito :) ");
                    return;
                }
                else
                {
                    Console.WriteLine($"sus datos ingresados son incorrectos INTENTO {i} de {intento}.\n");
                }
            }
            Console.WriteLine("Lo sentimos tus intentos han acabado.");
            Console.ReadKey();
        }
    }
}
