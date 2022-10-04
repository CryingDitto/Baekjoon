using System;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //# 빌딩 // X 차
            int[] size = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] answer = new int[5];
            StringBuilder sb = new StringBuilder(); // will contain 4 chars
            int count = 0;
            string[] park = new string[size[0]];
            for (int i =0; i<size[0]; i++)
            {
                park[i] = Console.ReadLine();
            }

            for (int i = 0; i < size[0]-1; i++) //row
            {
                for (int j = 0; j < size[1]-1; j++) //column
                {
                    sb.Append(park[i][j]);
                    sb.Append(park[i][j + 1]);
                    sb.Append(park[i + 1][j]); 
                    sb.Append(park[i + 1][j + 1]);
                    count = 0; // reset
                    
                    if (sb.ToString().Contains("#"))
                    {
                        //building cannot be destroyed
                    }
                    else
                    {
                        for (int k=0; k<sb.Length; k++)
                        {
                            if (sb[k] == 'X') count++;
                        }
                        answer[count]++;
                    }
                    sb.Clear();
                }
            }
            foreach(var a in answer)
            {
                Console.WriteLine(a);
            }
        }
    }
}