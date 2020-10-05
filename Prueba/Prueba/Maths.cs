namespace EcuaciónDe2Grado
{
    class Maths
    {
        public static Equation2solution SolveEquation2(double a, double b, double c)
        {
            double aux1, aux2;
            Equation2solution result;

            result = new Equation2solution();

            aux1 = b * b - 4.0 * a * c;
            aux2 = System.Math.Sqrt(aux1);

            result.solution1 = (-b + aux2) / (2.0 * a);
            result.solution2 = (-b - aux2) / (2.0 * a);
            return result;
        }

        public static double SolveEquation1(double a, double b)
        {
            return -b / a;
        }


        // Ejercicio: Hacer un programa que imprima si un numero es primo o no
        public static bool IsPrime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
