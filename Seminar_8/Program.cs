// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Задайте кол-во строк в массиве: ");
// int pows = int.Parse(Console.ReadLine());

// Console.WriteLine("Задайте кол-во столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());

// Console.WriteLine("Задайте минимальное значение массива: ");
// int minRandomNumber = int.Parse(Console.ReadLine());

// Console.WriteLine("Задайте максимальное значение массива: ");
// int maxRandomNumber = int.Parse(Console.ReadLine());

// ///summary - описание метода
// /// массив m * n 
// /// минимальное и максимальное число - minValue, maxValue
// int[,] GetArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(minRandomNumber, maxRandomNumber + 1);
//         }
//     }
//     return matrix;
// }

// /// выводим на печать массив
// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = GetArray(pows, columns);
// PrintArray(array);

// ///меняем первую и последнюю строку местами
// void ChangeRows (int [,] matrix)
// {
//     int indexMaxRow = matrix.GetLength(0)-1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0,i];
//         matrix[0,i]= matrix[indexMaxRow, i];
//         matrix[indexMaxRow,i] = temp;        
//     }
// }

// ChangeRows(array);
// Console.WriteLine("Результат:");
// PrintArray(array);


// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("Задайте кол-во строк в массиве: ");
// int pows = int.Parse(Console.ReadLine());

// Console.WriteLine("Задайте кол-во столбцов в массиве: ");
// int columns = int.Parse(Console.ReadLine());

// if (pows != columns) Console.WriteLine("Неверно задан массив!");
// return;

// Console.WriteLine("Задайте минимальное значение массива: ");
// int minRandomNumber = int.Parse(Console.ReadLine());

// Console.WriteLine("Задайте максимальное значение массива: ");
// int maxRandomNumber = int.Parse(Console.ReadLine());

// ///summary - описание метода
// /// массив m * n 
// /// минимальное и максимальное число - minValue, maxValue

// int[,] GetArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(minRandomNumber, maxRandomNumber + 1);
//         }
//     }
//     return matrix;
// }

// /// выводим на печать массив

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = GetArray(pows, columns);
// PrintArray(array);

// ///меняем первую и последнюю строку местами

// void ChangeRows(int[,] matrix)
// {
//     int indexMaxRow = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[indexMaxRow, i];
//         matrix[indexMaxRow, i] = temp;
//     }
// }

// ChangeRows(array);
// Console.WriteLine("Результат:");
// PrintArray(array);


// /// меняем местами строки и столбцы

// void PrintReverseArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[j, i] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Результат2:");
// PrintReverseArray(array);


// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int rows = 3;
int columns = 3;

int [,] matrix = new int[rows, columns];

int min = int.MaxValue;

int indexRows = 0;
int indexColumns = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = new Random().Next(11);
        Console.Write(matrix[i,j] + "\t");
        if (min > matrix[i,j])
        {
            min = matrix[i,j];
            indexRows = i;
            indexColumns = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Минимальное значение массива: " + min);

Console.WriteLine("Результат: ");

for (int i = 0; i < rows; i++)
{
    if (indexRows != i)
    {
        for (int j = 0; j < columns; j++)
        {
            if (indexColumns != j)
            {
                Console.Write(matrix[i,j] + "\t");
            }
        }
    }
    Console.WriteLine();
}