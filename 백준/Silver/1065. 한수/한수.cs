using System;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            
            for (int i = 1; i <= n; i++)
            {
                if(i<100) count++; 
                else{
                    string sb = i.ToString();
                    if (sb[0] - sb[1] == sb[1] - sb[2]) count++;
                }                
            }
            Console.WriteLine(count);
        }
    }
}