DateTime now = DateTime.ParseExact(Console.ReadLine(), "H m", null);
int cookTime = int.Parse(Console.ReadLine());
now = now.AddMinutes(cookTime);

Console.WriteLine("{0} {1}", now.Hour, now.Minute);