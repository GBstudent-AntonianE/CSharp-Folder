// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// void printArray(int[] array)
// {
//     string result = "[";
//     for(int i = 0; i < 9; i++)
//     {
//       result = result + array[i] + ", ";
//     }
//     result = result + array[9] + ']';
//     Console.Write(result);    
// }

// int[] array = new int[10];
// int count = 0;

// for(int i = 0; i<10; i++)
// {    
//     array[i] = new Random().Next(100,1000);
//     if( array[i] % 2 == 0 )
//     {
//         count++;
//     }
// }

// printArray(array);
// Console.WriteLine( " -> " + count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] array = new int[8];
// int sum = 0;

// void PrintArray(int[] array)
// {
//     string result = "[";
//     for(int i = 0; i<8; i++)
//     {    
//         result = result + array[i] + ", ";
//     }   
//     result = result + array[7] + ']';
//     Console.Write(result);    
// }        

// for(int i = 0; i<8; i++)
// {
//     array[i] = new Random().Next(-50,50);
//     if( i % 2 == 1 )
//     {
//         sum = sum + array[i];
//     }
// }

// PrintArray(array);
// Console.WriteLine( " -> " + sum);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void printArray(double[] array)
{
    string result = "[";
    for(int i = 0; i < 4; i++)
    {
      result = result + array[i] + "; ";
    }
    result = result + array[4] + ']';
    Console.Write(result);    
}

double[] array = new double[5];
double max, min;

for(int i = 0; i<5; i++)
{    
    array[i] = new Random().NextDouble() * 100;
}
max = array[0];
min = array[0];
for(int i = 1; i<4; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
}
printArray(array);
Console.WriteLine();
Console.WriteLine( "Разница = " + (max - min));
