using System;
using System.Linq;
using System.Text;
namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int ex = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            for(int i = 0; i < ex; i++)
            {
                int[] hwn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int h = hwn[2] % hwn[0] == 0 ? hwn[0] : hwn[2] % hwn[0];
                int room = hwn[2] % hwn[0] == 0? hwn[2] / hwn[0] : hwn[2] / hwn[0] + 1;

                if (room >= 10) sb.AppendLine($"{h}{room}");
                else            sb.AppendLine($"{h}0{room}");
            }
            Console.WriteLine(sb);
        }
    }
}