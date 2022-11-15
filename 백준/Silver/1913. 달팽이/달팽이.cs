using System;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numToFind = int.Parse(Console.ReadLine());

            int row=1, col=1;
            int dir = 0;
            int count = n*n;
            int dirCount = 0;
            int limit = n;

            int[,] snail = new int[n,n];
            int frow = 0, fcol = 0;

            while (true)
            {
                snail[row - 1, col - 1] = count;
                if (count == numToFind) { frow = row; fcol = col; }
                if (count == 1) break;
                dirCount++;
                count--;

                // direction change
                if (dir % 4 == 3 && dirCount >= limit - 1)
                {
                    limit -= 2;
                    dir++;
                    dirCount = 0;
                }
                else if (dirCount >= limit)
                {
                    dirCount = 1;
                    dir++;
                }

                if (dir % 4 == 0) row++;      // down
                else if (dir % 4 == 1) col++; // right                
                else if (dir % 4 == 2) row--; // up
                else if (dir % 4 == 3) col--; //left

            }

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    sb.Append($"{snail[i,j]} ");
                }
                sb.Append("\n");
            }
            Console.Write(sb);
            Console.WriteLine($"{frow} {fcol}");
        }
    }
}