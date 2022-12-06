using System;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] stores = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] routine = new int[3] { 0, 1, 2 };
            int ans = 0; int r = 0;
            for(int i=0; i<stores.Length; i++)
            {
                if(stores[i] == routine[r%3])
                {
                    ans++; r++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}