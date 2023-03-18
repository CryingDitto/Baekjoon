string input = Console.ReadLine();

int half = input.Length / 2;
int result = 1;
for (int i = 0; i < half; i++)
{
    if (!input[i].Equals(input[input.Length - 1 - i]))
    {
        result = 0;
        break;
    }
}
Console.WriteLine(result);