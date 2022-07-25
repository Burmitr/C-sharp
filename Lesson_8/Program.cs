// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortNumbersArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j -1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] matrix = GetArray(3, 4);
PrintArray(matrix);
SortNumbersArray(matrix);

Console.WriteLine("Результат сортировки:");
PrintArray(matrix);
//____________________________________________________________________________________________



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] squareMatrix = new int[4, 4];

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(10);
//         }
//     }
// }

// void WriteArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int SumRowsNumbers(int[,] array, int i)
// {
//     int sumNumbers = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         sumNumbers += array[i, j];
//     }
//     return sumNumbers;
// }

// CreateArray(squareMatrix);
// WriteArray(squareMatrix);

// int minSumRowNumber = 0;
// int sumNumbers = SumRowsNumbers(squareMatrix, 0);
// for (int i = 1; i < squareMatrix.GetLength(0); i++)
// {
//     int tempSumRowNumbers = SumRowsNumbers(squareMatrix, i);
//     if (sumNumbers > tempSumRowNumbers)
//     {
//         sumNumbers = tempSumRowNumbers;
//         minSumRowNumber = i;
//     }
// }

// Console.WriteLine($"\n Наименьшая сумма элементов: {sumNumbers} \n в {minSumRowNumber + 1} строке. \n");
//____________________________________________________________________________________________



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

// int[,] firstArray = new int[4, 4];
// int[,] secondArray = new int[4, 4];

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(10);
//         }
//     }
// }

// void WriteArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void MultiplyingArrays(int [,] array1, int [,] array2)
// {
//     int[,] multiplyingArrays = new int[4, 4];

//     for (int i = 0; i < multiplyingArrays.GetLength(0); i++)
//     {
//         for (int j = 0; j < multiplyingArrays.GetLength(1); j++)
//         {
//             multiplyingArrays [i,j] = array1[i,j] * array2[i,j];
//             Console.Write(multiplyingArrays[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// CreateArray(firstArray);
// WriteArray(firstArray);

// Console.WriteLine();

// CreateArray(secondArray);
// WriteArray(secondArray);

// Console.WriteLine();

// Console.WriteLine("Произведение двух матриц: ");

// MultiplyingArrays(firstArray, secondArray);
//____________________________________________________________________________________________

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

// int [,,] multidimensionalArray = new int [2,2,2];

// void CreateArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//         {
//             array[i, j, k] = new Random().Next(1, 100);
//         }
//         }
//     }
// }

// void WriteArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) \t");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// CreateArray(multidimensionalArray);
// WriteArray(multidimensionalArray);
//____________________________________________________________________________________________

