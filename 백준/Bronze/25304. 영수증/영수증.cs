int total = int.Parse(Console.ReadLine());
int itemCount = int.Parse(Console.ReadLine());
int price = 0;

for (int i = 0; i < itemCount; i++)
{
    string[] item = Console.ReadLine().Split(' ');
    price += int.Parse(item[0]) * int.Parse(item[1]);

}
if (price == total) Console.WriteLine("Yes");
else Console.WriteLine("No");