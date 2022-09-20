using System;
using System.Text;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder answer = new StringBuilder();
            string[] nums;

            for (int i = 0; i < count; i++)
            {
                nums = Console.ReadLine().Split(' ');
                answer.Append((int.Parse(nums[0]) + int.Parse(nums[1])).ToString() + "\n");
            }

            Console.WriteLine(answer);            
        }
    }
}