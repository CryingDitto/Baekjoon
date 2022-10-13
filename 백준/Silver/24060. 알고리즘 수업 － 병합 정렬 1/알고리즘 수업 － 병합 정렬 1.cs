using System;
using System.Collections.Generic;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int k = inputs[1];
            int[] sorted = new int[inputs[0]]; // sorted array

            List<int> saveNums = new List<int>();

            MSort(array, 0, array.Length - 1);

            if (saveNums.Count < k)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(saveNums[k-1]);
            }



            void MSort(int[] arr, int start, int end)
            {
                // split
                if (start < end)
                {
                    int mid = (start+end) / 2; // 그냥 end / 2 하면 mid가 뒤로 전진하기 못해서 무한루프 돌게 됨
                    MSort(arr, start, mid);
                    MSort(arr, mid + 1, end);
                    Merge(arr, start, mid, end);
                }
            }

            void Merge(int[] arr, int start, int mid, int end)
            {
                int i = start;
                int j = mid + 1;
                int t = start; // index of sorted array

                while (i <= mid && j <= end)
                {
                    if (arr[i] <= arr[j])
                    {

                        sorted[t++] = arr[i++];
                    }
                    else
                    {
                        sorted[t++] = arr[j++];
                    }
                }

                // 쪼개진 배열 중 하나가 먼저 모든 원소를 소진했을 경우
                if (i > mid)
                {
                    // 앞쪽이 먼저 끝난 경우
                    // 뒤쪽에서 나머지 그대로 sorted에 복사
                    for (int l = j; l <= end; l++)
                    {
                        sorted[t++] = arr[l];
                    }
                }
                else
                {
                    // 뒤쪽이 먼저 끝난 경우
                    // 앞쪽에서 나머지 그대로 sorted에 복사
                    for (int l = i; l <= mid; l++)
                    {
                        sorted[t++] = arr[l];
                    }
                }

                for (int l = start; l <= end; l++)
                {
                    saveNums.Add(sorted[l]);
                    arr[l] = sorted[l]; // copy sorted array to original array
                }

            }
        }
    }
}