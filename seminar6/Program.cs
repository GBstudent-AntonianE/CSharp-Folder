// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.Write("Введите числа : ");
// string[] numbers = Console.ReadLine().Split(",");

// void printArray()
// {
//     string result = "[";
//     for(int i = 0; i < numbers.Length-1; i++)
//     {
//       result = result + numbers[i] + ", ";
//     }
//     result = result + numbers[numbers.Length-1] + ']';
//     Console.Write(result);    
// }

// int count = 0;
// for(int i = 0; i<numbers.Length; i++)
// {        
//     if( Convert.ToInt32( numbers[i] ) > 0 )
//     {
//         count++;
//     }
// }

// printArray();
// Console.WriteLine();
// Console.WriteLine($"Чисел больше нуля = " + count);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.Write("Введите к1 : ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b1 : ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите к2 : ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b2 : ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2)
// {
//     Console.Write("Прямые не пересекаются");
// }
// else
// {
//     double x = ( b2 - b1 ) / ( k1 - k2 );
//     double y = k1 * x + b1; 
//     Console.Write($"Прямые пересекаются в точке ({x:f2}; {y:f2})");
// }