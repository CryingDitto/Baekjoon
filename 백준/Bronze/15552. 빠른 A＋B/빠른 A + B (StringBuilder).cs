using System;
using System.Text;
using System.IO;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            StringBuilder answer = new StringBuilder();            
            string[] nums;

            //StringBuilder만 활용한 버전
            for (int i = 0; i < count; i++)
            {
                nums = Console.ReadLine().Split(' ');
                answer.Append((int.Parse(nums[0]) + int.Parse(nums[1])).ToString() + "\n");
            }
        }
    }
}
