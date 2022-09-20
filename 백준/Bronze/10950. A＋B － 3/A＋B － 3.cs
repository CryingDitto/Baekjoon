int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    string[] nums =  Console.ReadLine().Split(' ');
    Console.WriteLine(int.Parse(nums[0]) + int.Parse(nums[1]));
}