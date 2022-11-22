using System;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int index = 1;
            int addCount = 1;
            int[] nums = new int[1001];
            int[] sums = new int[1001];
            while (true)
            {                
                for(int k=1; k<=addCount; k++)
                {                  
                    nums[index] = addCount;
                    sums[index] = sums[index-1]+nums[index];
                    index++;
                    if (index > 1000) break;
                }
                if (index > 1000) break;
                addCount++;                
            }

            // 구간합
            Console.WriteLine(sums[inputs[1]] - sums[inputs[0]-1]);
        }
    }
}