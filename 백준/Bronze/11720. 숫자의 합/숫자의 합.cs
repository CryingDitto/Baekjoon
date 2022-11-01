using System;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            string s = Console.ReadLine();
            for (int i = 0; i<n; i++)
            {
                sum += s[i] - '0';
            }
            Console.WriteLine(sum);       
        }
    }
}