using System;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            StringBuilder sb = new StringBuilder();

            if (n < 100) count = n;
            else
            {
                count = 99;
                for (int i = 100; i <= n; i++)
                {
                    sb.Clear();
                    sb.Append(i.ToString());
                    if (sb[0] - sb[1] == sb[1] - sb[2]) count++;
                }
            }            

            Console.WriteLine(count);
        }
    }
}