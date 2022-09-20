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

            for (int i = 0; i < count; i++)
            {
                nums = new StringReader(Console.ReadLine()).ReadLine().Split(' ');
                answer.AppendLine( (int.Parse(nums[0]) + int.Parse(nums[1])).ToString() );
            }
            Console.WriteLine(answer);
        }
    }
}
