using System;
using System.Collections.Generic;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mn = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            SortedDictionary<string, int> sdict = new SortedDictionary<string, int>();
            StringBuilder sb = new StringBuilder();

            for (int i = mn[0]; i<= mn[1]; i++)
            {
                int[] nums = new int[2];
                nums[0] = i / 10; // 십의 자리
                nums[1] = i % 10; // 일의 자리
                for(int j = 0; j<2; j++)
                {
                    int num = nums[j];
                    if (j==0 && num == 0) continue; // 십의 자리가 0

                    switch (num)
                    {
                        case 1:
                            sb.Append("one ");
                            break;
                        case 2:
                            sb.Append("two ");
                            break;
                        case 3:
                            sb.Append("three ");
                            break;
                        case 4:
                            sb.Append("four ");
                            break;
                        case 5:
                            sb.Append("five ");
                            break;
                        case 6:
                            sb.Append("six ");
                            break;
                        case 7:
                            sb.Append("seven ");
                            break;
                        case 8:
                            sb.Append("eight ");
                            break;
                        case 9:
                            sb.Append("nine ");
                            break;
                        case 0:
                            sb.Append("zero ");
                            break;
                    }                    

                }
                sdict.Add(sb.ToString(), i);
                sb.Clear();
            }
            int count = 0;
            foreach(var pair in sdict)
            {
                count++;
                if(count == 10)
                {
                    sb.AppendLine(pair.Value + " ");
                    count = 0;
                }
                else sb.Append(pair.Value + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}