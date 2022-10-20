using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            string sNum = Console.ReadLine();
            int count = 0;
            int result = 0;

            result = Transform(sNum);

            Console.WriteLine(count);
            if (result % 3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            int Transform(string sNumber)
            {
                int sum = 0;
                if(sNumber.Length == 1)
                {
                    // 길이 1일 때 count 하지 말고 그냥 튕기셈
                    return int.Parse(sNumber);
                }

                count++;
                foreach (var s in sNumber)
                {
                    sum += int.Parse(s.ToString());
                }

                return Transform(sum.ToString());
            }
        }
    }
}