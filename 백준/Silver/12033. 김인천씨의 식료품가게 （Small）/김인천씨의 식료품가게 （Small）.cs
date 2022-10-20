using System;
using System.Collections.Generic;
using System.Linq;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < cases; i++)
            {
                int product = int.Parse(Console.ReadLine());
                List<int> price = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                List<int> discount = new List<int>();
                List<int> normalPrice = new List<int>();
                bool[] visited = new bool[price.Count];
                
                int temp = 0;
                for (int j = 0; j<price.Count; j++)
                {
                    if (!visited[j])
                    {
                        temp = price[j];
                        visited[j] = true;
                        if (temp % 3 == 0)
                        {
                            // 3의 배수이면 할인가일 가능성 존재
                            int index = price.IndexOf(temp / 3 * 4);
                            //Console.WriteLine("Initial Index: " + index);
                            if(index >= 0) // 문제 조건에 따르면 안 해도 되는데 그냥 안전용.
                            {
                                while (visited[index])
                                {
                                    // 이미 사용한 숫자이므로 새로운 index 구함
                                    // 찾은 index 다음 숫자부터 다시 temp/3*4 검색
                                    // visited에서 false인 자리 찾으면 while 탈출
                                    index = index + 1 + price.GetRange(index+1, price.Count - index - 1).IndexOf(temp / 3 * 4);
                                    //Console.WriteLine("New index: " + index);

                                }
                                if (!visited[index])
                                {
                                    //Console.WriteLine("Normal Price Index: "+index);
                                    //normalPrice.Add(price[index]);
                                    discount.Add(temp);
                                    price[index] = 0;
                                    visited[index] = true;
                                }                                
                            }                            
                        }
                    }                    
                }
                // print
                Console.Write($"Case #{i + 1}:");
                foreach(var p in discount)
                {
                    Console.Write($" {p}");
                }
                if (i < cases - 1)
                {
                    Console.Write("\n");
                }
            }

        }
    }
}