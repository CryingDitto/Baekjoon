using System.Text;
int test = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();

for(int i = 0; i<test; i++)
{
    int k = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());

    sb.AppendLine(Calc(k, n).ToString());
}

Console.Write(sb.ToString());

int Calc(int k, int n)
{
    if (n == 1) return 1;
    else if (n == 2) return k + 2;
    else if (k == 1)
    {
        return (n + 1) * n / 2;
    }
    else
    {
        return Calc(k, n - 1) + Calc(k - 1, n);
    }
}
