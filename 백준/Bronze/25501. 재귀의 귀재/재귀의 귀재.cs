using System;
namespace Baekjoon
{
    class Program
    {
        static int recurCount = 0;
        static void Main(string[] args)
        {
            int caseNum = int.Parse( Console.ReadLine() );
            
            int isPalinedrome = 0;
            
            for(int i = 0; i<caseNum; i++)
            {
                recurCount = 0;
                string s = Console.ReadLine();
                isPalinedrome = Palindrome(s);

                Console.WriteLine($"{isPalinedrome} {recurCount}");
            }
        }


        static int Recursion(string s, int left, int right)
        {
            recurCount++;
            if (left >= right) return 1;
            else if (s[left] != s[right]) return 0;
            else return Recursion(s, left + 1, right - 1);
        }

        static int Palindrome(string s)
        {
            return Recursion(s, 0, s.Length - 1);
        }
    }
}