using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i< test; i++)
            {
                int[] scores = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                int num = scores[0];
                int sum = scores.Sum() - num;

                var avg = (float)sum / num;
                int stdCount = 0;
                for (int j=1; j<scores.Length; j++)
                {
                    if (scores[j] > avg) stdCount++;
                }

                sb.AppendLine(string.Format("{0:F3}%", (float)stdCount / num * 100));                
            }
            Console.WriteLine(sb);

        }
    }
}