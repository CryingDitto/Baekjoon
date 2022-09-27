int number = Convert.ToInt32(Console.ReadLine());           

int function(int num)
{
    if (num == 0) return 1;
    else return num * function(num - 1);
}
Console.WriteLine(function(number));