int size = int.Parse(Console.ReadLine());
string[] numStr = Console.ReadLine().Split(' ');
int maxVal = int.Parse(numStr[0]);
int minVal = int.Parse(numStr[0]);

for (int i=1; i<size ; i++)
{
    if (maxVal < int.Parse(numStr[i]))
    {
        maxVal = int.Parse(numStr[i]);
    }
    if (minVal > int.Parse(numStr[i]))
    {
        minVal = int.Parse(numStr[i]);
    }

}

Console.WriteLine("{0} {1}", minVal, maxVal);