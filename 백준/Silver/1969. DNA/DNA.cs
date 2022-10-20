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
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] dnas = new string[inputs[0]];
            int length = inputs[1];

            for (int i = 0; i<inputs[0]; i++)
            {
                dnas[i] = Console.ReadLine();
            }
            char[] letters = new char[inputs[0]];

            List<int> ACGT = new List<int>{0,0,0,0}; // TAGC 개수 
            string dnaletter = "ACGT";

            // print outputs
            int hdistance = 0; // hamming distance
            StringBuilder sb = new StringBuilder(); // dna string print

            for (int i = 0; i < length; i++) // 각 dna 내 글자 자리
            {
                for (int j = 0; j < inputs[0]; j++) // 각 dna
                {
                    letters[j] = dnas[j][i]; // 각 dna의 i번째 자리 글자
                    //Console.WriteLine(letters[j]);
                    switch (dnas[j][i])
                    {
                        case 'A':
                            ACGT[0]++;
                            break;
                        case 'C':
                            ACGT[1]++;
                            break;
                        case 'G':
                            ACGT[2]++;
                            break;
                        case 'T':
                            ACGT[3]++;
                            break;

                        default:
                            break;
                    }
                }
                int index = ACGT.IndexOf(ACGT.Max()); // 앞에서부터 검색. Max 개수 가진 글자의 index 찾음
                sb.Append(dnaletter[index]); // 가장 많이 나온 글자를 골라야 Hamming distance 작게 나옴. 동률일 경우 사전상으로 더 앞에 있는 글자 출력.

                foreach (var letter in letters)
                {
                    // calculate Hamming distance
                    if (letter != dnaletter[index]) hdistance++;
                }

                // clearing ACGT letter count list
                for (int k = 0; k < ACGT.Count; k++)
                {
                    ACGT[k] = 0; //initialize acgt into {0,0,0,0}
                }
            }

            Console.WriteLine(sb);
            Console.WriteLine(hdistance);
        }
    }
}