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

        public static double Ejercicio1b(double a)
        {
            double celsius = 273;
            return a + celsius * 18 / 10 + 32;
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
            else
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

        public static void Ejercicio6a(int n)
        {
            int result = 0;

            while (n != 0)
            {
                System.Console.WriteLine("Dime el número al que quieres hacer al cuadrado");
                n = System.Convert.ToInt32(System.Console.ReadLine());

                result = n * n;

                System.Console.WriteLine("El resultado es " + result);
            }
        }

        public static void Ejercicio7b(int n)
        {
            int a = 0;
            int b = 0;

            System.Console.WriteLine("Dime el primer número");
            a = System.Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Dime el segundo número");
            b = System.Convert.ToInt32(System.Console.ReadLine());

            n = a;
            n = b;

            for (int i = 2; i < n / 2; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    System.Console.Write(i + ", ");
                }
            }
        }

        public static void Ejercicio8()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i - 3; j < i + 10; j += 3)
                {
                    if (i == j)
                        break;
                    else if (j == 3)
                        continue;
                    System.Console.Write(1 + i + j * 2);
                }
            }
        }

        public static void Ejercicio9a(int n)
        {

            System.Console.WriteLine("Dime el primer número");
            n = System.Convert.ToInt32(System.Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    System.Console.Write("Los factores primos de " + n + " es/son " + i);
                    break;
                }
            }
        }
    }
}

