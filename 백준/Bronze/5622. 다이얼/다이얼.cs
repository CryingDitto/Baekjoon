using System.Collections.Generic;
using System.Linq;

string s = Console.ReadLine();

Dictionary<string, int> dict = new Dictionary<string, int>();

dict.Add("ABC", 3);
dict.Add("DEF", 4);
dict.Add("GHI", 5);
dict.Add("JKL", 6);
dict.Add("MNO", 7);
dict.Add("PQRS", 8);
dict.Add("TUV", 9);
dict.Add("WXYZ", 10);

int sum = 0;
foreach(var ch in s)
{
    foreach(var key in dict.Keys)
    {
        if (key.Contains(ch))
        {
            sum += dict[key];
            break;
        }
    }
}

Console.WriteLine(sum);