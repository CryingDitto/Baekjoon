using System;
using System.Collections.Generic;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            List<int> ans = new List<int>();
            Array.Sort(nums);

            for (int i = nm[0]-1; i>=2; i--)
            {
                for(int j = i-1; j>=1; j--)
                {
                    for (int k = j-1; k>=0; k--)
                    {
                        if(nums[i] +nums[j] + nums[k] <= nm[1])
                        {
                            ans.Add(nums[i] + nums[j] + nums[k]);
                        }
                    }
                }
            }
            Console.WriteLine(ans.Max());            
        }
    }
}