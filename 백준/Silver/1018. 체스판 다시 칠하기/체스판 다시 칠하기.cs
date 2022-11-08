using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            StringBuilder sb = new StringBuilder();
            List<int> countList = new List<int>();
            int countw = 0;
            int countb = 0;

            for (int i = 0; i < nm[0]; i++)
            {
                sb.AppendLine(Console.ReadLine());
            }
            string[] inputs = sb.ToString().Split('\n');

            for (int i = 0; i < nm[0]-7; i++)
            {
                for (int j = 0; j < nm[1] - 7; j++)
                {
                    countw = 0;
                    countb = 0;

                    for (int a = i; a<i+8; a++)
                    {
                        for (int c = j; c < j+8; c++)
                        {
                            if ( (a + c) % 2 == 0)
                            {
                                // 첫 글자가 W라고 가정한 경우 (a+c)가 짝수일 때 W여야 함
                                if (inputs[a][c] != 'W') {countw++;}
                                // 첫 글자가 B라고 가정한 경우 (a+c)가 짝수일 때 B여야 함
                                if (inputs[a][c] != 'B') {countb++;}
                            }
                            else
                            {
                                // 첫 글자가 W라고 가정한 경우 (a+c)가 홀수일 때 B여야 함
                                if (inputs[a][c] != 'B') {countw++;}
                                // 첫 글자가 B라고 가정한 경우 (a+c)가 홀수일 때 W여야 함
                                if (inputs[a][c] != 'W') {countb++;}
                            }

                        }
                    }
                    countList.Add(countw);
                    countList.Add(countb);
                }                
            }
           Console.WriteLine(countList.Min());
        }
    }
}