namespace EcuaciónDe2Grado
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux = x * x + y * y;
            return System.Math.Sqrt(aux);
        }

        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux1 = x * x + y * y + z * z;
            return System.Math.Sqrt(aux1);
        }

        public static double GetAreaCircle(double r)
        {
            return System.Math.PI * (r * r);
        }

        public static double GetDistance2D(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return GetVector2DLength(vx, vy);
        }

        public static bool AreCircleIntersecting(double x1, double y1, double r1, double x2, double y2, double r2)
        {
            double ValueDistance = GetDistance2D(x1, y1, x2, y2);
            double ValueRadius = r1 + r2;

            if (ValueDistance <= ValueRadius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
