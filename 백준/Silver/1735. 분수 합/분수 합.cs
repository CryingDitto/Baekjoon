using System;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] cd = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int up = ab[0] * cd[1] + ab[1] * cd[0];
            int down = ab[1] * cd[1];

            int a = up; int b = down; int r = 0;
            while (a % b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            if (r == 0)
            {
                up /= down;
                down = 1;
                r = 1;
            }
            Console.WriteLine($"{up/r} {down/r}");
        }
    }
}