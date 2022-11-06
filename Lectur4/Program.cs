//
// string[,] table = new string[2, 5];



// table[1 , 2]="слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }

// }


// int[,] matrix = new int[3,4];

// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }    

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // возвращает строки
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //возвращает столбцы
//         {
//             matr[i,j] = new Random().Next(1,10); //[1,10]
//         }
//     }
// }

// int[,] matrix = new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


//Закрашиваем область

int[,] pic = new int[23,25];

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++) // возвращает строки
    {
        for (int j = 0; j < image.GetLength(1); j++) //возвращает столбцы
        {
           // Console.Write($"{image[i, j]} ");
           if(image [i, j] ==0) Console.Write($" ");
           else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

PrintImage(pic);