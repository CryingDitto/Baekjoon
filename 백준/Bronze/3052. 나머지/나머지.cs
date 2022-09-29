using System;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine())%42;
            }

            Console.WriteLine($"{nums.Distinct().Count()}");
        }
    }
}
