using System.Transactions;

namespace KonwersjaCnaFiK
{
    public class KonwerterRafal
    {
        public static double[] CnaFiK(double x)
        {
            double F = (x * (9.0 / 5.0)) + 32;
            double K = x + 273.15;
            return new double[] { F, K };
        }
    }
}
