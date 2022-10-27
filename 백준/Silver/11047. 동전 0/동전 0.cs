using System;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] coins = new int[inputs[0]]; // coins to be used
            int count = 0;

            for (int i = 0; i < inputs[0]; i++)
            {
                coins[i] = int.Parse(Console.ReadLine());
            }

            for (int c = coins.Length - 1; c >= 0; c--)
            {
                if (coins[c] <= inputs[1])
                {
                    count += inputs[1] / coins[c];
                    inputs[1] %= coins[c];

                    if (inputs[1] == 0) break;
                }
            }
            Console.WriteLine(count);
        }
    }
}