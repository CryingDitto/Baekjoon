using System;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int max = scores.Max();

            double[] news = new double[count];

            //for (int i = 0; i < count; i++)
            //{
            //    news[i] = (double)scores[i] / max * 100;
            //}
            
            //Linq
            var newscores = from s in scores
                            select (double)s / max * 100;

            Console.WriteLine($"{newscores.Average()}");
        }
    }
}
