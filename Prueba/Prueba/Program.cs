using EcuaciónDe2Grado;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios.Ejercicio1();

            Ejercicios.Ejercicio2(20);

            Ejercicios.Ejercicio03(657);

            Ejercicios.Ejercicio04(5);

            Ejercicios.Ejercicio05(10);

            Ejercicios.Ejercicio06(23);

            Student s1, s2;
            s1 = new Student();
            s2 = new Student();

            s1.name = "Abel";
            s2.name = "Alex";

            string ss = s1.getNameTwice();
        }
    }
}
