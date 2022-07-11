// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] randomArray = new int[10];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int PositiveNumbers(int[] array)
{
    int evenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNumbers++;
        }
    }
    return evenNumbers;
}

FillArray(randomArray);
WriteArray(randomArray);

int evenNumbers = PositiveNumbers(randomArray);
Console.WriteLine($"Количество чётных чисел = {evenNumbers}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Write($"Задайте количество элементов в массиве: ");
// int numberElements = Convert.ToInt32(Console.ReadLine());

// int RandomArray(int numberElements)
// {
//     int[] randomNumbers = new int[numberElements];
//     int additionOfNumbers = 0;
//     Console.WriteLine("Получившийся массив: ");

//     for (int i = 0; i < randomNumbers.Length; i++)
//     {
//         randomNumbers[i] = new Random().Next(0, 10);

//         Console.Write(randomNumbers[i] + " ");

//         if (i % 2 != 0)
//         {
//             additionOfNumbers = additionOfNumbers + randomNumbers[i];
//         }
//     }
//     Console.WriteLine();
//     return additionOfNumbers;
// }

// int randomNumbers = RandomArray(numberElements);

// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] randomArray = new double[15];

// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(-10, 10);
// }
// Console.WriteLine("Заданный массив: ");
// Console.WriteLine($"[{String.Join("; ", randomArray)}]");

// double DifferenceOfNumbers(double[] randomArray)
// {
//     double max = 0;
//     double min = 0;
//     double differenceNumbers = 0;

//     for (int i = 0; i < randomArray.Length; i++)
//     {
//         if (randomArray[i] > max)
//         {
//             max = randomArray[i];
//         }
//         if (randomArray[i] < min)
//         {
//             min = randomArray[i];
//         }
//         differenceNumbers = max - min;
//     }
//     return differenceNumbers;
// }
// double differenceNumbers = DifferenceOfNumbers(randomArray);
// System.Console.WriteLine($"Рзница между максимальным и минимальным числом = {differenceNumbers}");