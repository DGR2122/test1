using EcuaciónDe2Grado;

namespace Prueba
{
    class Ejercicios
    {
        // Ejercicio: Hacer una función que imprima por pantalla los números del 0 al 99
        public static void Ejercicio1()
        {
            int contador;
            contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                contador++;
            }
        }

        // Ejercicio: Hacer una función que imprima todos los números pares desde 0 hasta n
        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
        }
    }
}
