// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число A");
// int a = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32 (Console.ReadLine());

// void findPower(int number, int power)
// {
//     int result = number;
//     for (int i = 1; i < power; i++)
//     {
//       result = result * number;
//     }
//     Console.WriteLine("A в степени B равно: " + result);
// }

// findPower(a, b);



// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
 
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32 (Console.ReadLine());

// void calculateSum(int number)
// {
//   int sum = 0;

//   while (number > 0)
//   {
//       sum = sum + number % 10;
//       number = number /10 ;
//   }
//   Console.WriteLine($"Сумма цифр равна {sum}");
// }

// calculateSum(n);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры 
// и выводит массив на экран.

// Console.WriteLine("Введите восемь элементов массива");
// int[] array = new int[8];

// void printArray(int[] array)
// {
//     string result = "[";
//     for(int i = 0; i < 7; i++)
//     {
//       result = result + array[i] + ", ";
//     };
//     result = result + array[7] + ']';
//     Console.WriteLine(result);    
// }

// for(int i = 0; i < 8; i++)
// {
//   array[i] = Convert.ToInt32 (Console.ReadLine());
// };

// printArray( array );


