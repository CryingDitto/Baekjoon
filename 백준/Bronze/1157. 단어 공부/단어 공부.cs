using System;
using System.Collections.Generic;
using System.Linq;

string input = Console.ReadLine();
input = input.ToUpper();
Dictionary<char, int> letterCount = new Dictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    if (!letterCount.ContainsKey(input[i]))
    {
        letterCount.Add(input[i], 0);
    }
    letterCount[input[i]]++;
}

Dictionary<char, int> orderCount = letterCount.OrderByDescending(x => x.Value).ToDictionary(item => item.Key, item => item.Value);
int maxVal = orderCount.First().Value;
char key = orderCount.First().Key;
orderCount.Remove(key);
if(orderCount.Count > 0 && orderCount.First().Value == maxVal)
{
    Console.WriteLine('?');
}
else
{
    Console.WriteLine(key);
}