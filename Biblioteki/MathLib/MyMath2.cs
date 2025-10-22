namespace MathLib
{
    public class MyMath2
    {
        public static double Iloraz(double x, double y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException("You can not divide by zero"); 
            }
            return x / y;
        }
        public static double Iloczyn(double x, double y)
        {
            return x * y;
        }
    }
}
