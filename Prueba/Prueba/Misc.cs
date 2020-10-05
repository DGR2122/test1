namespace EcuaciónDe2Grado
{
    class Misc
    {
        // This function return the lowest value
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // This function return the highest value
        public static int GetMaxValue(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        // This function return true if the number is even and false otherwise
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                return false;
        }

        // This function return true if the number is positive and false otherwise
        public static bool IsPositive(int a)
        {
            if (a >= 0)
                return true;
            else
                return false;
        }
    }      
}
