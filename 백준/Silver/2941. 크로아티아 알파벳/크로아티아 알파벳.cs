string input = Console.ReadLine();
int sum = 0;
int i = 0;
while (true)
{
    if (i >= input.Length) break;

    if (i < input.Length - 2)
    {
        if (input[i].Equals('d') && input[i + 1].Equals('z') && input[i + 2].Equals('='))
        {
            i += 2; sum += 2;
        }
    }
    if (i < input.Length - 1)
    {
        if(input[i].Equals('l') || input[i].Equals('n'))
        {
            if (input[i + 1].Equals('j')) 
            { 
                i += 1; sum++; 
            }
        }
        else if(input[i].Equals('c') || input[i].Equals('s') || input[i].Equals('z'))
        {
            if (input[i + 1].Equals('='))
            {
                i += 1; sum++;
            }
            else if(input[i].Equals('c') && input[i + 1].Equals('-'))
            {
                i += 1; sum++;
            }
        }
        else if (input[i].Equals('d'))
        {
            if (input[i + 1].Equals('-'))
            {
                i += 1; sum++;
            }
        }
    }

    i++;
}

Console.WriteLine(input.Length - sum);