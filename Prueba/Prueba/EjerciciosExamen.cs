using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Prueba
{
    class EjerciciosExamen
    {
        // Hacer una función que reciba dos enteros y devuelva la suma de esos dos enteros
        public static int Suma(int a, int b)
        {
            return a + b;
        }

        // Hacer una función que reciba dos reales y devuelva la resta de esos dos reales
        public static double Resta(double a, double b)
        {
            return a - b;
        }

        // Hacer una función que reciba dos enteros y devuelva el menor de los dos
        public static int EsMenor(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        // Hacer una función que reciba dos enteros y devuelva si el primero es menor que el segundo
        public static bool PrimeroMenor(int a, int b)
        {
            if (a < b)
                return true;
            else
                return false;
        }

        // Hacer una función que reciba tres strings y devuelva la concatenación de esos tres strings
        public static string Cat(string a, string b, string c)
        {
            return a + b + c;
        }

        // Hacer una función que reciba dos enteros y devuelva -1 si el primero es menor que el segundo, +1 si el segundo es menor que el primero, y 0 en cualquier otro caso
        public static int Compare(int a, int b)
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
        public static void PrintError(int code)
        {
            switch (code)
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
        public static void PrintSerie(int n)
        {
            // for (int i=0; i < n; i+= 3)
            int i = 0;
            while (i <= n)
            {
                System.Console.Write(i + ",");
                i += 3;
            }
        }

        // Hacer una función que se le pase 3 enteros y devuelva el menor de los tres

        public static int Min3(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b < c)
                    return b;
                else
                    return c;
            }
        }

        // Hacer una función que se le pase 4 enteros y devuelva el menor de los 4

        public static int Min4(int a, int b, int c, int d)
        {
            if (a < b)
            {
                return Min3(a, c, d);
            }
            else
            {
                return Min3(b, c, d);
            }
        }

        // Hacer una función que se le pase un entero e imprima por pantalla las siguientes series de x | serie(10) --> 0,1,2,3,4,5,6,7,8,9,

        public static void PrintSerie2(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write(i + ",");
        }

        // Hacer una función que se le pase un entero e imprima por pantalla las siguientes series de x | serie(10) --> 0,1,2,3,4,5,6,7,8,9

        public static void PrintSerie3(int n)
        {
            if (n > 0)
                System.Console.Write(0);
            for (int i = 1; i < n; i++)
                System.Console.Write("," + i);
        }

        // Hacer una función que se le pase un entero e imprima una línea de tantos asteriscos como ese número | asteriscos (2) --> ** asteriscos (5) --> ***** 

        public static void PrintAsteriscos(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");

        }

        // Hacer una función que se le pase un entero e imprima el siguiente patron * + | asteriscos (2) --> *+* asteriscos (5) --> *+*+*+*+* 

        public static void PrintAsteriscos2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }

        }

        // Hacer una función que se le pase un entero e imprima el siguiente patron *+-/

        public static void PrintAsteriscos3(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int resto = i % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    default:
                        System.Console.Write("/");
                        break;
                }
            }
        }

        // Hacer una función que se le pase un entero e imprima algo como lo siguiente : funcion (3) *** | funcion (4) ****
        //                                                                                           ***               ****                         
        //                                                                                           ***               **** 

        public static void PrintAsteriscosFormas(int n)
        {
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++) 
                    System.Console.Write("*", j);
                System.Console.WriteLine(" ");
            }
        }

        // Hacer una función que devuelva el menor de 16 enteros, solo tiene que ocupar una línea

        /*public static int PrintMin16(int menor4)
        {
            return menor4(menor4(n1,n2,n3,n4),menor4(n5,n6,n7,n8),menor4(n9,n10,n11,n12),menor4(n13,n14,n15,n16));
        }*/

        // Hacer una función que se le pase un entero e imprima algo como lo siguiente : funcion (3) *** | funcion (4) ****
        //                                                                                           +++               ****                         
        //                                                                                           ***               **** 

        public static void PrintFormas(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if((r%2)==0)
                    System.Console.Write("*");
                    else
                    System.Console.Write("+");
                }
                System.Console.WriteLine("");
            }
        }

        // "                                                                          ":  *+*+

        public static void PrintFormas1(int n)
        {
            for (int r= 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    int flag = r + c;
                    if ((flag % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine("");
            }
            
        }

        // "                                                                          ":  *
        //                                                                                **
        //                                                                                *** 
        //                                                                                ****
        
        public static void PrintFormas2(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c <= r ; c++)
                        System.Console.Write("*");
                System.Console.WriteLine("");
            }
        }

        // "                                                                          ":      *
        //                                                                                   **
        //                                                                                  ***
        //                                                                                 **** 
        
        public static void PrintFormas3(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int nespacios = n-r-1;
                int nasteriscos = r+1;
                for (int c = 0; c <= r; c++)
                    System.Console.Write("*");
                System.Console.WriteLine("");
            }
        }

    }
}
