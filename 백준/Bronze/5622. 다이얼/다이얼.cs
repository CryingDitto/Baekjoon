using System.Collections.Generic;
using System.Linq;

Dictionary<string, int> dict = new Dictionary<string, int>();

dict.Add("ABC", 3);
dict.Add("DEF", 4);
dict.Add("GHI", 5);
dict.Add("JKL", 6);
dict.Add("MNO", 7);
dict.Add("PQRS", 8);
dict.Add("TUV", 9);
dict.Add("WXYZ", 10);

string input = Console.ReadLine();
int sum = 0;
foreach (var s in input)
{
    foreach (var key in dict.Keys)
    {
        if (key.Contains(s))
        {
            sum += dict[key];
            break;
        }
    }

}
Console.WriteLine(sum);