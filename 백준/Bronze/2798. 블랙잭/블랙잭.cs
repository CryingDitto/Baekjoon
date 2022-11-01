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

            var descNum = nums.OrderByDescending(n => n).ToArray();

            List<int> sum = new List<int>();
            
            for(int i = 0; i<nm[0] -2; i++)
            {
                if (descNum[i] < nm[1]) // 일단 작아야 2개의 숫자를 더해 nm[1]에 가까운 수를 만들 수 있으므로
                {
                    for (int j = i+1; j < nm[0] - 1; j++)
                    {
                        if(descNum[i] + descNum[j] < nm[1])
                        {
                            for (int k = j+1; k<nm[0]; k++)
                            {
                                if(descNum[i] + descNum[j] + descNum[k] <= nm[1])
                                {
                                    sum.Add(descNum[i] + descNum[j] + descNum[k]);
                                }
                            }
                        }                        
                    }
                }                
            }
            Console.WriteLine(sum.Max());
        }
    }
}