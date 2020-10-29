using System;
using System.Collections;

namespace Prueba
{
    class EjerciciosExamen
    {
        // Hacer una función que reciba dos enteros y devuelva la suma de esos dos enteros
        public static int Suma (int a, int b)
        {
            return a + b;
        }

        // Hacer una función que reciba dos reales y devuelva la resta de esos dos reales
        public static double Resta (double a, double b)
        {
            return a - b;
        }

        // Hacer una función que reciba dos enteros y devuelva el menor de los dos
        public static int EsMenor (int a, int b)
        {
            if (a < b)
                return a;
            else 
                return b;
        }

        // Hacer una función que reciba dos enteros y devuelva si el primero es menor que el segundo
        public static bool PrimeroMenor (int a, int b)
        {
            if (a < b)
                return true;
            else
                return false;
        }

        // Hacer una función que reciba tres strings y devuelva la concatenación de esos tres strings
        public static string Cat (string a, string b, string c)
        {
            return a + b + c;
        }

        // Hacer una función que reciba dos enteros y devuelva -1 si el primero es menor que el segundo, +1 si el segundo es menor que el primero, y 0 en cualquier otro caso
        public static int Compare (int a, int b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return 1;
            else
                return 0;
        }

        // Hacer una función que reciba un código de error e imprima por pantalla: Error crítico en caso de que el código sea 0 | Error leve en caso de que el código sea 1 |
        // Error moderado en caso de que el código sea 2 | Error desconocido en cualquiero otro caso
        public static void PrintError (int code)
        {
            switch(code)
            {
                case 0:
                    System.Console.WriteLine("Error crítico");
                    break;
                case 1:
                    System.Console.WriteLine("Error leve");
                    break;
                case 2:
                    System.Console.WriteLine("Error moderado");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;
            }
        }
        // Hacer una función que reciba por parámetro un número y escriba lo siguiente: 0,3,6,9,12 ... hasta llegar a ese número. Por ejemplo: función (10) imprimiría: 0, 3, 6, 9
        public static void PrintSerie (int n)
        {
            // for (int i=0; i < n; i+= 3)
            int i = 0;
            while (i <= n)
            {
                System.Console.Write(i + ",");
                i += 3;
            }
        }
    }
}
