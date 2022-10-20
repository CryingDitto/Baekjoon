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

            //result = Transform(sNum);

            while (sNum.Length > 1)
            {
                int sum = 0;
                count++;
                foreach (var s in sNum)
                {
                    sum += int.Parse(s.ToString());
                }
                sNum = sum.ToString();
            }

            result = int.Parse(sNum);
            Console.WriteLine(count);
            if (result % 3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");

            }
        }
    }
}