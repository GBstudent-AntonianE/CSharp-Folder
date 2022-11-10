// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// Console.Write("Введите число строк    m : ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов n : ");
// int n = Convert.ToInt32(Console.ReadLine());

// float[,] matrix = new float[m,n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i,j] = new Random().NextSingle() * 100 - 50;
//     }
// }

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write($"\t{matrix[i,j]:f2}") ;
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает значение элемента 
// в двумерном массиве, и возвращает позицию этого элемента или же указание, 
// что такого элемента нет.


// int row = 4;
// int colunm = 5;
// int[,] matrix = new int[row,colunm];

// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < colunm; j++)
//     {
//         matrix[i,j] = new Random().Next(0,21);
// //        matrix[i,j] = new Random().Next(-100,101);
//     }
// }

// Console.Write("Введите число от 0 до 20 для поиска: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool found = false;

// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < colunm; j++)
//     {
//         Console.Write($"\t{matrix[i,j]}") ;
//     }
//     Console.WriteLine();
// }

// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < colunm; j++)
//     {
//         if( matrix[i,j] == number)
//         {
//             found = true;
//             Console.WriteLine($"Значение найдено в строке №{i+1},  столбце №{j+1}");
//         }
//     }
// }

// if(!found)
// {
//     Console.WriteLine("Такого числа в массиве нет");
// }



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// int row = 3;
// int colunm = 6;
// int[,] matrix = new int[row,colunm];

// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < colunm; j++)
//     {
//         matrix[i,j] = new Random().Next(10,100);
//     }
// }


// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < colunm; j++)
//     {
//         Console.Write($"\t{matrix[i,j]}") ;
//     }
//     Console.WriteLine();
// }

// float[] avg = new float[colunm];

// for (int j = 0; j < colunm; j++)
// {
//     avg[j] = 0f;
//     for (int i = 0; i < row; i++)
//     {
//         avg[j] = avg[j] + matrix[i,j];
//     }
//     avg[j] = avg[j] / row;
//     Console.Write($"\t{avg[j]:f2}") ;
// }