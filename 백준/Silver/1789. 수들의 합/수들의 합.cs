using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            long S = long.Parse(Console.ReadLine()); // 0 ~ 4,294,967,295 표현 가능
            long n = 0;
            
            while (n*(n+1)/2 < S)  
            {
                n++;
            }
            long sum = n * (n + 1) / 2;
            Console.WriteLine(sum - S == 0 ? n : n - 1);

        }
    }
}