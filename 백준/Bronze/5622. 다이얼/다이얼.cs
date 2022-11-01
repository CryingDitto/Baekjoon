using System;
using System.Collections.Generic;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("ABC", 3);
            dict.Add("DEF", 4);
            dict.Add("GHI", 5);
            dict.Add("JKL", 6);
            dict.Add("MNO", 7);
            dict.Add("PQRS", 8);
            dict.Add("TUV", 9);
            dict.Add("WXYZ", 10);

            string input = Console.ReadLine();
            int sum = 0;

            for(int i = 0; i<input.Length; i++)
            {
                char c = input[i];
                foreach (var k in dict.Keys)
                {
                    if (k.Contains(c)) 
                    { 
                        sum += dict[k]; 
                        break; 
                    }
                }
            }
            Console.WriteLine(sum);            
        }
    }
}