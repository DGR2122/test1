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

        public static int Ejercicio3a(int a, int b, int c)
        {
            a = 0;
            b = 0;
            c = 0;

            System.Console.WriteLine("Dime el primer número");
            a = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Dime el segundo número");
            b = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Dime el tercer número");
            c = System.Convert.ToInt32(System.Console.ReadLine());

            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            //else (c > a && c > b)
            {
                return c;
            }
        }   
        public static void Ejercicio4b(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error Grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error Medio");
                    break;
                case 2:
                    System.Console.WriteLine("Error Leve");
                    break;
                default:
                    System.Console.WriteLine("Error Desconocido");
                    break;
            }
        }

    }
}

