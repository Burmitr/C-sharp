// Запрос от пользователя ввод массива с конвертацией в целые числа.

// int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
// Console.WriteLine($"[{String.Join("; ", array)}]");



// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int rows = Int32.Parse(Console.ReadLine());
// int columns = Int32.Parse(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 11); // заполняет дробными числами от 0 до 1. * 100 - увеличили диап до 100.    
//         Console.Write(matrix[i, j] + "\t"); // \t - литерал = горизонтальная табуляция
//     }
//     Console.WriteLine();
// }



// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int m = Int32.Parse(Console.ReadLine());
// int n = Int32.Parse(Console.ReadLine());

// int[,] matrix = new int[m,n];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0, 10);
//         Console.Write(matrix[i,j] + " ");
//     }
//     Console.WriteLine();
// }



// *Задача 49: *Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// int rows = Int32.Parse(Console.ReadLine());
// int columns = Int32.Parse(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// Console.WriteLine("Введенный массив: ");

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// int[,] PowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i%2 == 0 && j%2 == 0)
//             {
//                 array[i, j] *= array[i, j];
//             }
//             Console.Write(matrix[i,j] + " ");
//         }
//     Console.WriteLine();    
//     }
//     return array;
// }

// Console.WriteLine("Измененный массив: ");
// PowArray(matrix);



// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int rows = Int32.Parse(Console.ReadLine());
// int columns = Int32.Parse(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// int[,] FillPrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// void PrintSumArray(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += array[i, j];
//             }
//         }
//     }
//     Console.WriteLine("Сумма чисел главной диагонали = " + sum);
// }

// Console.WriteLine("Введенный массив: ");

// FillPrintArray(matrix);

// PrintSumArray(matrix);

