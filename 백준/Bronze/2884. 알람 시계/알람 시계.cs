string[] HM = Console.ReadLine().Split(' ');
int H = Convert.ToInt32(HM[0]);
int M = Convert.ToInt32(HM[1]);
int h = 0;
int m = 0;

if (M >= 45)
{
    m = M - 45;
    h = H;
}
else
{
    m = 60 - (45 - M);
    h = H == 0 ? 23 : (H - 1);
}

Console.WriteLine(h + " " + m);