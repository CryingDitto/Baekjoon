using System;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int t = 0; t<T; t++)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                foreach (var s in inputs[1])
                {
                    for (int i = 0; i < int.Parse(inputs[0]); i++)
                    {
                        sb.Append(s);
                    }
                }
                Console.WriteLine(sb);
                sb.Clear();
            }            
        }
    }
}