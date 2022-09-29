using System;
using System.Collections.Generic;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //function
            int addn(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                else
                    return n + addn(n - 1);
            }

            int count = int.Parse(Console.ReadLine());
            string[] strox = new string[count];
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++) {
                strox[i] = Console.ReadLine();
            }

            for (int i=0; i<count; i++)
            {
                string[] ox = strox[i].Split('X');

                var ocount = from o in ox
                             where o.Contains('O')
                             select o.Length;

                foreach(int oc in ocount)
                {
                    list.Add(addn(oc));
                }
                Console.WriteLine(list.Sum());
                list = Enumerable.Repeat(0, count).ToList();
            }
        }
    }
}
