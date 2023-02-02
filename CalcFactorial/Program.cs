using CalcFactorial;

namespace Factorial
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string escolha = "s";
            while (escolha.Equals("s"))
            {
                int n;
                Console.WriteLine("Insira o valor a ser calculado: ");
                try
                {
                    try
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException("digite apenas números inteiros"); ;
                    }
                    CalculaFatorial.ValidaEntrada(n);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Entrada inválida: {ex.Message}");
                    continue;
                }
             
                Console.WriteLine("O fatorial de " + n + " é " + CalculaFatorial.Factorial(n));
                Console.WriteLine("Deseja calcular outro número? (s/n)");
                escolha = Console.ReadLine();
            }
        }
    }
}