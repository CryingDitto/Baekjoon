int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int result = 0;

if(x * y > 0)
    result = x > 0 ? 1 : 3;
else
    result = x > 0 ? 4 : 2;

Console.WriteLine(result);