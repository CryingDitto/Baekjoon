using System;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] abc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if (abc[2] <= abc[1]) { Console.WriteLine(-1); return; }

            int year = abc[0] / (abc[2] - abc[1]);
            
            Console.WriteLine(year + 1);
        }
    }
}