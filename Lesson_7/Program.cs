// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задай кол-во строк в массиве: ");
int rows = Int32.Parse(Console.ReadLine());

Console.WriteLine("Задай кол-во столбцов в массиве: ");
int columns = Int32.Parse(Console.ReadLine());

double[,] matrix = new double[rows, columns];

void CreateDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 10 - 5;
        }
    }
}

void RoundingArrayNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double arrayNumber = Math.Round(array[i, j], 1);
            Console.Write(arrayNumber + "\t");
        }
        Console.WriteLine();
    }
}

CreateDoubleArray(matrix);
RoundingArrayNumbers(matrix);

// _____________________________________________________________________________________________


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] matrix = new int[3, 4];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 50);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SearchResult(int[,] array)
// {
//     Console.Write("Введи искомое число: ");
//     int searchNumber = Convert.ToInt32(Console.ReadLine());

//     bool findResult = false;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == searchNumber)
//             {
//                 Console.WriteLine($"Число находится в маcсиве на позиции: {i},{j}");
//                 findResult = true;
//             }
//         }
//     }
//     if (findResult == false) { Console.WriteLine("Число в массиве не обнаружено!"); }
// }

// FillArray(matrix);
// SearchResult(matrix);

// _____________________________________________________________________________________________



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] matrix = new int[3, 4];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 20);
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void ArithmeticMean(int[,] array)
// {
//     int count = 1;

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;

//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         Console.WriteLine($"Cтолбец № {count}: ср. арифм. чисел = {Math.Round(sum / array.GetLength(0), 1)}");
//         count++;
//     }
// }

// FillArray(matrix);
// ArithmeticMean(matrix);
