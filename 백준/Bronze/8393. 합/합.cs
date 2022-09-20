//int sum = 0;
//int input = int.Parse(Console.ReadLine());

//for (int i = 1; i < input+1; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);

// 다른 방법
// 1부터 n까지의 합 공식 n * (n+1) / 2 
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n * (n + 1) / 2);