using System;
using System.Linq;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i=1; i<=num*2-1; i++)
            {
                if (i <= num)
                {
                    sb.Append(string.Concat(Enumerable.Repeat(' ', num-i)));
                    sb.Append(string.Concat(Enumerable.Repeat('*', 2*i-1)));
                }
                else
                {
                    sb.Append(string.Concat(Enumerable.Repeat(' ', i - num)));
                    sb.Append(string.Concat(Enumerable.Repeat('*', 2 * (2 * num - i) - 1)));
                }
                sb.Append('\n');
            }
            Console.WriteLine(sb);
        }
    }
}