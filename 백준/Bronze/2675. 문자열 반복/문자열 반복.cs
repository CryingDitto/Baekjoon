using System.Text;
StringBuilder sb = new StringBuilder();
int num = int.Parse(Console.ReadLine());
for(int i=0; i<num; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    foreach(var c in input[1])
    {
        int jCount = int.Parse(input[0]);
        for (int j=0; j< jCount; j++)
        {
            sb.Append(c);
        }

    }
    Console.WriteLine(sb);
    sb.Clear();
}