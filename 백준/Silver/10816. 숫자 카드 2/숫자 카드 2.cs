using System;
using System.Collections.Generic;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] card = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int m = int.Parse(Console.ReadLine());
            int[] numToCheck = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Dictionary<int, int> dict = new Dictionary<int, int>();
            StringBuilder sb = new StringBuilder();
            // push into dictionary
            for(int i = 0; i<n; i++)
            {
                dict[card[i]] = dict.TryGetValue(card[i], out int value) ? value + 1 : 1;
            }

            // search
            for (int i = 0; i < m; i++)
            {
                int res = dict.TryGetValue(numToCheck[i], out int value) ? value : 0;
                sb.Append(res.ToString() + " ");
            }
            Console.Write(sb);
        }
    }
}