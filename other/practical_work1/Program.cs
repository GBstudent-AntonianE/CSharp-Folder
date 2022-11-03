Console.WriteLine("Введите число");
int x = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число");
int y = Convert.ToInt32 (Console.ReadLine());

int max = x;
if (x < y) max = y;

Console.Write("max = ");
Console.WriteLine(max);