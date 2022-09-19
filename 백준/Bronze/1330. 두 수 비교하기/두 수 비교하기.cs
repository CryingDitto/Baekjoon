using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputArr = Console.ReadLine().Split(' ');
            
            if (int.Parse(inputArr[0]) > int.Parse(inputArr[1]))
            {
                Console.WriteLine('>');
            }
            else if (int.Parse(inputArr[0]) < int.Parse(inputArr[1]))
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}