using System.Drawing;

namespace imagen
{
    class Program
    {
        public static double GetDistance2D(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return System.Math.Sqrt(vx * vx + vy * vy);
        }

        public static void FillImage(Bitmap bitmap, Color color)
        {
            for (int y = 0; y < bitmap.Height; y++)

            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    bitmap.SetPixel(x, y, color);
                }
            }
        }

        public static void FillCircle(Bitmap bm, Color color, double centerx, double centery, double radius)
        {
            for (int y = 0; y < bm.Height; y++)

            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (GetDistance2D(centerx, centery, x, y) < radius)
                    {
                        bm.SetPixel(x, y, color);
                    }

                }
            }
        }

        public static void PaintJapaneseFlag(Bitmap bm)
        {
            // Vamos a rellenar la imagen de blanco
            FillImage(bm, Color.White);

            // Vamos a poner un círculo
            FillCircle(bm, Color.Red, 250, 150, 50);

            // Vamos a ponerle un marco negro
            for (int y = 0; y < bm.Height; y++)

            {
                for (int x = 0; x < bm.Width; x++)
                {
                    if (y == 0 || y == (bm.Height - 1) || x == (bm.Width - 1) || x == 0)
                    {
                        bm.SetPixel(x, y, Color.Black);
                    }
                }
            }
        }

        public static void PaintRomanFace(Bitmap bm)
        {
            FillImage(bm, Color.White);
            FillCircle(bm, Color.Black, 250, 150, 100);
            FillCircle(bm, Color.White, 250, 150, 95);
            FillCircle(bm, Color.Black, 215, 112, 20);
            FillCircle(bm, Color.White, 210, 107, 18);


        }

        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(500, 300);

            // PaintJapaneseFlag(bitmap);
            PaintRomanFace(bitmap);

            bitmap.Save("C:\\Users\\gonzalez19660\\Desktop\\repos\\prueba.png");

        }       
    }
}
