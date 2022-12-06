using System;
using System.Collections.Generic;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            List<char> list = new List<char>();
            int count = 0;
            for(int i = 0; i<sb.Length; i++)
            {
                if (!list.Contains(sb[i])) list.Add(sb[i]);
                else
                {
                    if (list[list.Count - 1] == sb[i]) list.RemoveAt(list.Count - 1);
                    else
                    {
                        int index = list.IndexOf(sb[i]);
                        count += list.Count - 1 - index;
                        list.RemoveAt(index);
                    }
                }
            }
            Console.WriteLine(count);            
        }
    }
}