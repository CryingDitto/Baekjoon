using System.Collections.Generic;
using System.Linq;
int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
string[] wbString = new string[nm[0]];
for(int i=0; i<nm[0]; i++)
{
    wbString[i] = Console.ReadLine();
}

List<int> sums = new List<int>();

for(int i = 0; i<nm[0]-7; i++)
{
    for(int j=0; j<nm[1]-7; j++)
    {
        int wCount = 0; // W로 시작했을 때 칠해야 하는 개수
        int bCount = 0; // B로 시작했을 때 칠해야 하는 개수

        for(int row=i; row<i+8; row++)
        {
            for(int col=j; col<j+8; col++)
            {
                if((row+col)%2 == 0)
                {
                    if (wbString[row][col] - 'W' == 0) bCount++; // B 시작이라고 가정
                    else if (wbString[row][col] - 'B' == 0) wCount++; // W 시작이라고 가정
                }
                else
                {
                    if (wbString[row][col] - 'B' == 0) bCount++;
                    else if (wbString[row][col] - 'W' == 0) wCount++;
                }

            }
        }
        sums.Add(wCount);
        sums.Add(bCount);
    }

}
Console.WriteLine(sums.Min());