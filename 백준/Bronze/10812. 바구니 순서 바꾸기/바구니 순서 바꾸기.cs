using System;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] basket = Enumerable.Range(0, nm[0]+1).ToArray();

            for (int n = 0; n < nm[1]; n++)
            {
                int[] turn = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int i = turn[0];
                int j = turn[1];
                int k = turn[2];
                int[] temp = new int[j - i + 1];
                for(int backIdx = k; backIdx <= j; backIdx++)
                {
                    temp[backIdx - k] = basket[backIdx];
                }
                int counter = 0;
                for(int frontIdx = k-1; frontIdx >= i; frontIdx--)
                {
                    temp[temp.Length - 1 - counter] = basket[frontIdx];
                    counter++;
                }

                counter = 0;
                foreach(var t in temp)
                {
                    basket[i + counter] = t;
                    counter++;
                }
            }
            for(int i = 1; i < basket.Length; i++)
            {
                Console.Write($"{basket[i]} ");
            }
        }
    }
}