using System;

namespace Fibonacci
{
    class Program
    {
        int Fibo(int N)
        {
            if (N < 2) return N;
            else return Fibo(N - 1) + Fibo(N - 2);
        }

        static void Main(string[] args)
        {
            Program n = new Program();
            Console.WriteLine();
            for (int X = 0; X <= 20; X++)
            {
                Console.WriteLine(" Fibo ({0}) = {1}", X, n.Fibo(X));
            }
            Console.ReadKey();
        }
    }
}
