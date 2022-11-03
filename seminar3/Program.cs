// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

//  Console.WriteLine("Введите число");
//  int x = Convert.ToInt32 (Console.ReadLine());

// if (x > 9999)
// {
//     int x1 = x % 10;
//     int x2 = (x % 100)  / 10;
//     int x4 = (x / 1000) % 10;
//     int x5 = x / 10000;

//     if ((x1 == x5) && (x2 == x4))     
//       Console.WriteLine("Является палиндромом");
//     else 
//       Console.WriteLine("Не является палиндромом");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//  Console.WriteLine("Введите координаты первой точки x, y, z");
//  int x1 = Convert.ToInt32( Console.ReadLine() ); 
//  int y1 = Convert.ToInt32( Console.ReadLine() ); 
//  int z1 = Convert.ToInt32( Console.ReadLine() );
//  Console.WriteLine("Введите координаты второй точки x, y, z");
//  int x2 = Convert.ToInt32( Console.ReadLine() ); 
//  int y2 = Convert.ToInt32( Console.ReadLine() ); 
//  int z2 = Convert.ToInt32( Console.ReadLine() );

//  double a =  Math.Pow( x1 - x2, 2);
//  double b =  Math.Pow( y1 - y2, 2);
//  double c =  Math.Pow( z1 - z2, 2);
//  double d = Math.Round( Math.Sqrt( a + b + c ) * 100 ) / 100;
//  Console.Write($"Расстояние между точками равно :{d}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите n");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// Console.Write($"{i*i*i} ");






