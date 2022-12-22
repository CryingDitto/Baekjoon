using System.Text;
int test = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
for(int i=0; i<test; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int printCount = int.Parse(input[0]);
    for (int j=0; j<input[1].Length; j++)
    {
        char s = input[1][j];

        for(int k=0; k<printCount; k++)
        {
            sb.Append(s);
        }
    }
    Console.WriteLine(sb.ToString());
    sb.Clear();
}