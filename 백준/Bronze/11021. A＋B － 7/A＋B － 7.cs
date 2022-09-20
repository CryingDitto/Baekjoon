using System;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] ab;
            StringBuilder sb = new StringBuilder();
            for (int i=0; i < num; i++)
            {
                ab = Console.ReadLine().Split(' ');
                sb.AppendLine("Case #" + (i+1).ToString() + ": " + (int.Parse(ab[0]) + int.Parse(ab[1])).ToString());
            }
            Console.WriteLine(sb);
        }
    }
}