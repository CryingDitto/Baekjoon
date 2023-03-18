using System.Collections.Generic;
int test = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < test; i++)
{
    string input = Console.ReadLine();
    Dictionary<char, bool> check = new Dictionary<char, bool>();
    bool escape = false;
    for (int j = 0; j < input.Length; j++)
    {
        if (check.ContainsKey(input[j]))
        {
            if(j>0 && !input[j].Equals(input[j - 1]))
            {
                escape = true;
                break;
            }
        }
        else
        {
            check.Add(input[j], true);
        }
    }
    if (escape) continue;
    sum++;
}

Console.WriteLine(sum);