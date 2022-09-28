Console.WriteLine("Введіть число!");
var n = Console.ReadLine();
try
{
    int x = int.Parse(n);
    Console.WriteLine($"Ви ввели число {x}");
}
catch
{
    Console.WriteLine("Ви не ввели число");
}
