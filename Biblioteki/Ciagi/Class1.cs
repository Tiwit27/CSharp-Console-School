namespace Ciagi
{
    public static class CiagiRekurencja
    {
        public static int CiagFibonacciegoRekurencja(int numer)
        {
            if(numer <= 0)
            {
                return 0;
            }
            if (numer == 1 || numer == 2)
            {
                return 1;
            }
            return CiagFibonacciegoRekurencja(numer - 1) + CiagFibonacciegoRekurencja(numer - 2);
        }

        public static int CiagGeometrycznyRekurencja(int pierwsza, int iloraz, int numer)
        {
            if (numer <= 0)
            {
                return 0;
            }
            if (numer == 1)
            {
                return pierwsza;
            }
            return CiagGeometrycznyRekurencja(pierwsza, iloraz, numer - 1) * iloraz;
        }

        public static int CiagArytmetycznyRekurencja(int pierwsza, int roznica, int numer)
        {
            if (numer <= 0)
            {
                return 0;
            }
            if (numer == 1)
            {
                return pierwsza;
            }
            return CiagArytmetycznyRekurencja(pierwsza, roznica, numer - 1) + roznica;
        }
    }
}
