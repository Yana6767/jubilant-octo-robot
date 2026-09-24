using System;

namespace пр3яна
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Введите натуральное число N: ");
            int N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("N должно быть натуральным (N > 0).");
                return;
            }

         
            int result = ((201 + N - 1) / N) * N;

            Console.WriteLine($"Минимальное число, большее 200 и кратное {N}: {result}");
        }
    }
}
