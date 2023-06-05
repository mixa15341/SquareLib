namespace SqureLib
{
    public class Square
    {
        public static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static double Triangle(double a, double b, double c)
        {

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));


        }
        public static bool IsRightTriangle(double a, double b, double c)
        {
            double maxSide = Math.Max(Math.Max(a, b), c);
            if (maxSide == a && a * a == b * b + c * c)
            {
                return true;
            }
            else if (maxSide == b && b * b == a * a + c * c)
            {
                return true;
            }
            else if (c * c == a * a + b * b)
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