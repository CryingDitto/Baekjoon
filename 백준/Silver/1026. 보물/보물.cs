using System;
using System.Collections.Generic;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            // b의 최대와 a의 최소부터 곱하기 시작하면 될 것
            List<int> bCopy = b.OrderByDescending(x => x).ToList();
            Array.Sort(a);
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += bCopy[i] * a[i];
            }
            Console.WriteLine(sum);
        }
    }
}