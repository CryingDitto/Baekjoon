using System;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hy = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int money = hy[0];
            int year = hy[1];

            int[] result = new int[year+1];
            result[0] = money; // 원금

            Console.WriteLine(CalcMoney(money, year));

            int CalcMoney(int h, int y)
            {
                for (int i = 1; i < y+1; i++)
                {
                    result[i] = (int)(result[i - 1] * 1.05);
                    if (i >= 3)
                    {
                        result[i] = Math.Max(result[i], (int)(result[i - 3] * 1.2));
                    }
                    if (i >= 5)
                    {
                        result[i] = Math.Max(result[i], (int)(result[i - 5] * 1.35));
                    }
                }
                return result[y];
            }

        }
    }
}