using System;
using System.Collections.Generic;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int room = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            list.Add(1);
            if(room == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 1; ; i++)
                {
                    list.Add(list[i - 1] + 6 * i);
                    if(room <= list[i])
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }
                }
            }
        }
    }
}