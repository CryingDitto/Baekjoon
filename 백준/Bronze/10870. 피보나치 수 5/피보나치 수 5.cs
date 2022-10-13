using System;

namespace Baekjoon
{
    class Program
    {     
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibo(num));
        }

        static int Fibo(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}