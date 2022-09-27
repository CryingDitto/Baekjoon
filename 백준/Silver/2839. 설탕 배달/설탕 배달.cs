using System;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());

            int count = 0; int count2 = 0;
            int residual5 = weight % 5;
            int residual3 = weight % 3;

            while (weight > 0)
            {
                if (weight % 5 == 0)
                {
                    count = weight / 5;
                    break;
                }

                weight -= 3;
                count2++;

            }
            if(weight < 0)
            {
                Console.WriteLine("-1");
                return;
            }

            Console.WriteLine(count+count2);
        }
    }
}
