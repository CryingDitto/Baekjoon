using System;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pple = int.Parse(Console.ReadLine());
            int[] wtime = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] ans = new int[pple];

            Array.Sort(wtime);
            ans[0] = wtime[0];
            for(int i = 1; i<wtime.Length; i++)
            {
                ans[i] = ans[i-1] + wtime[i];
            }
            Console.WriteLine(ans.Sum());            
        }
    }
}