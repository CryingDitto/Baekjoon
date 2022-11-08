using System;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int m = int.Parse(Console.ReadLine());
            int[] numsToCheck = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            StringBuilder sb = new StringBuilder();

            Array.Sort(nums); // 크기로 정렬
            int half = n / 2 + 1;

            for (int i = 0; i < m; i++)
            {
                int temp = numsToCheck[i];

                sb.AppendLine(Compare(0, n - 1, numsToCheck[i]).ToString());
            }

            Console.Write(sb.ToString());

            int Compare(int start, int end, int num)
            {
                int mid = (start + end) / 2;
                if (nums[mid] == num) return 1;
                else if (num < nums[start] || nums[end] < num) return 0;
                else
                {
                    if (nums[mid] > num) return Compare(start, mid, num);
                    else return Compare(mid + 1, end, num);
                }
            }
        }
    }
}