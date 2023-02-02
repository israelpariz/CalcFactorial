namespace CalcFactorial
{
    public static class CalculaFatorial
    {

        public static void ValidaEntrada(int entrada)
        {
            if (entrada < 0) throw new ArgumentException("não é possível calcular fatorial de números negativos");
            if (entrada > 20) throw new ArgumentException("número muito grande para calcular fatorial");
        }

        public static int Factorial(int n)
        {
            ValidaEntrada(n);
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
