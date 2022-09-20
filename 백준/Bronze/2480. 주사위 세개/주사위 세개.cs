string[] numString = Console.ReadLine().Split(' ');
int reward = 0;
if (numString[0] == numString[1] && numString[1] == numString[2])
{
    reward = 10000 + int.Parse(numString[0]) * 1000;
}
else if (numString[0] == numString[1] || numString[0] == numString[2] || numString[1] == numString[2])
{
    if(numString[1] == numString[2])
    {
        reward = 1000 + int.Parse(numString[1]) * 100;
    }
    else
    {
        reward = 1000 + int.Parse(numString[0]) * 100;
    }
}
else
{
    int maxNum = Math.Max(Math.Max(int.Parse(numString[0]), int.Parse(numString[1])), int.Parse(numString[2]));
    reward = 100 * maxNum;
}

Console.WriteLine(reward);