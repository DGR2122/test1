using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    class EjerciciosExamenPrueba
    {
        public static double Ejercicio1a(double a)
        {
            double metros = 1609;
            return a / metros;           
        }

        public static void Ejercicio2c()
        {
            System.Console.WriteLine("Dime el primer número");
            int a = System.Convert.ToInt32(System.Console.ReadLine());


            System.Console.WriteLine("Dime el segundo número");
            int b = System.Convert.ToInt32(System.Console.ReadLine()); 

            if (a > 0 && b < 0)
            {
                System.Console.WriteLine("Uno de los números es positivo");
            }
            else if (a > 0 && b > 0)
            {
                System.Console.WriteLine("Los dos números son positivos");
            }
            else 
            {
                System.Console.WriteLine("Ninguno de los números es positivo");
            }
            

            
        }
    }
}
