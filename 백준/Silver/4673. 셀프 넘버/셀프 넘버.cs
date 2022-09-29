using System;
using System.Collections.Generic;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // a list to contain self numbers
            List<int> list = new List<int>();

            int d(int num)
            {
                List<int> numbers = new List<int>();
                int numcopy = num;

                numbers.Add(num % 10); // basically positive integer
                // 각 자리수 리스트에 추가
                while (num >= 10)
                {
                    num /= 10;
                    numbers.Add(num % 10);
                }
                
                // final output : self number
                return numbers.Sum() + numcopy;
            }

            for (int i = 1; i<10000; i++)
            {
                list.Add(d(i));
            }
            
            for (int i = 1; i < 10000; i++)
            {
                if (!list.Contains(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
