using System;
using System.Collections.Generic;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            List<string> ans = new List<string>();

            int wCount = int.Parse(Console.ReadLine());
            while (wCount > 0)
            {
                for (int i = 0; i < wCount; i++)
                {
                    words.Add(Console.ReadLine());
                }
                words.Sort((x,y) => x.ToLower().CompareTo(y.ToLower()));
                ans.Add(words[0]);
                words.Clear();
                wCount = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ans.Count; i++)
            {
                Console.WriteLine(ans[i]);
            }

        }
    }
}